using Core.Security.Dtos;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using SelfWaiterAuth.Application.Dtos;
using SelfWaiterAuth.Application.Repositories.UserRefreshTokenRepository;
using SelfWaiterAuth.Application.Services;
using SelfWaiterAuth.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfWaiterAuth.Persistence.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly ITokenService _tokenService;
        private readonly UserManager<UserApp> _userManager;
        private readonly IUserRefreshTokenRepository _userRefreshTokenRepository;


        public AuthenticationService(ITokenService tokenService, UserManager<UserApp> userManager, IUserRefreshTokenRepository userRefreshTokenRepository)
        {
            _tokenService = tokenService;
            _userManager = userManager;
            _userRefreshTokenRepository = userRefreshTokenRepository;
        }


        public async Task<ResponseDto<TokenDto>> CreateTokenAsync(LoginDto loginDto)
        {
            if (loginDto == null) throw new ArgumentNullException(nameof(loginDto));

            var user = await _userManager.FindByEmailAsync(loginDto.Email);

            if (user == null) return ResponseDto<TokenDto>.Fail("Email or Password is wrong", true, 400);

            if (!await _userManager.CheckPasswordAsync(user, loginDto.Password))
                return ResponseDto<TokenDto>.Fail("Email or Password is wrong", true, 400);

            var token = await _tokenService.CreateToken(user);

            var userRefreshToken = await _userRefreshTokenRepository.Table.Where(rt => rt.UserId == user.Id).FirstOrDefaultAsync();

            if (userRefreshToken == null)
            {
                await _userRefreshTokenRepository.Table.AddAsync(new UserRefreshToken { UserId = user.Id, Code = token.RefreshToken, Expiration = token.RefreshTokenExpiration });
            }
            else
            {
                userRefreshToken.Code = token.RefreshToken;
                userRefreshToken.Expiration = token.RefreshTokenExpiration;
            }

            await _userRefreshTokenRepository.SaveAsync();

            return ResponseDto<TokenDto>.Sucess(token, 200);
        }

        
        public async Task<ResponseDto<TokenDto>> CreateTokenByRefreshToken(string refreshToken)
        {
            var existReFreshToken = await _userRefreshTokenRepository.Table.Where(rt => rt.Code.Equals(refreshToken)).FirstOrDefaultAsync();

            if (existReFreshToken == null) return ResponseDto<TokenDto>.Fail("RefreshToken Not Found", true, 404);

            if (DateTime.UtcNow > existReFreshToken.Expiration) return ResponseDto<TokenDto>.Fail("RefreshToken time out", true, 404);

            var user = await _userManager.FindByIdAsync(existReFreshToken.UserId);
            if (user == null) throw new Exception("Data Binding Error Check AuthenditcationService relation userId -> refreshToken");

            var token = await _tokenService.CreateToken(user);

            existReFreshToken.Code = token.RefreshToken;
            existReFreshToken.Expiration = token.RefreshTokenExpiration;

            await _userRefreshTokenRepository.SaveAsync();

            return ResponseDto<TokenDto>.Sucess(token, 200);
        }

        public async Task<ResponseDto<BlankDto>> RevokeRefreshToken(string refreshToken)
        {
            var existRefreshToken = await _userRefreshTokenRepository.Table.Where(rt => rt.Code.Equals(refreshToken)).FirstOrDefaultAsync();
            if (existRefreshToken == null) return ResponseDto<BlankDto>.Fail("RefreshToken Not Found", true, 404);

            _userRefreshTokenRepository.Table.Remove(existRefreshToken);
            await _userRefreshTokenRepository.SaveAsync();

            return ResponseDto<BlankDto>.Sucess(204);
        }

     
    }
}
