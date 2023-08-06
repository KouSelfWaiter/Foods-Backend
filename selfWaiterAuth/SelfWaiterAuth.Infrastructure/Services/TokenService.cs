using Core.Security.Configurations;
using Core.Security.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using SelfWaiterAuth.Application.Dtos;
using SelfWaiterAuth.Application.Services;
using SelfWaiterAuth.Domain.Entities;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SelfWaiterAuth.Infrastructure.Services
{
    public class TokenService: ITokenService
    {
        private readonly UserManager<UserApp> _userManager;
        private readonly CustomTokenOptions _customTokenOptions;

        public TokenService(UserManager<UserApp> userManager, IOptions<CustomTokenOptions> options)
        {
            _userManager = userManager;
            _customTokenOptions = options.Value;

        }

        public async Task<TokenDto> CreateToken(UserApp userApp)
        {
            var accessTokenExpiration = DateTime.UtcNow.AddMinutes(_customTokenOptions.AccessTokenExpiration);
            var securityKey = SignService.GetSymmetricSecurityKey(_customTokenOptions.SecurityKey);

            SigningCredentials signingCredentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256Signature);

            JwtSecurityToken jwtSecurityToken = new JwtSecurityToken
                (issuer: _customTokenOptions.Issuer,
                expires: accessTokenExpiration,
                notBefore: DateTime.UtcNow,
                signingCredentials: signingCredentials,
                claims: await GetClaims(userApp, _customTokenOptions.Audiences));

            var handler = new JwtSecurityTokenHandler();
            var token = handler.WriteToken(jwtSecurityToken);

            var tokenDto = new TokenDto()
            {
                AccessToken = token,
                RefreshToken = CreateRefreshToken(),
                AccessTokenExpiration = accessTokenExpiration,
                RefreshTokenExpiration = DateTime.UtcNow.AddMinutes(_customTokenOptions.RefreshTokenExpiration)
            };

            return tokenDto;
        }

        private string CreateRefreshToken()
        {
            var numberByte = new Byte[32];

            using var rnd = RandomNumberGenerator.Create();
            rnd.GetBytes(numberByte);

            return Convert.ToBase64String(numberByte);
        }

        private async Task<IEnumerable<Claim>> GetClaims(UserApp userApp, List<string> audiences)
        {        
            var userClaimList = new List<Claim>()
            {
                new Claim(ClaimTypes.NameIdentifier, userApp.Id),
                new Claim(ClaimTypes.Email, userApp.Email),
                new Claim(ClaimTypes.Name, userApp.UserName),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
            };
           
            userClaimList.AddRange(audiences.Select(x => new Claim(JwtRegisteredClaimNames.Aud, x)));
        
            var userRoles = await _userManager.GetRolesAsync(userApp);
            userClaimList.AddRange(userRoles.Select(r => new Claim(ClaimTypes.Role, r)));

            return userClaimList;
        }
    
    }
}
