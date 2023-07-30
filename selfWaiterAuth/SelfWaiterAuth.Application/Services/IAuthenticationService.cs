using Core.Security.Dtos;
using SelfWaiterAuth.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfWaiterAuth.Application.Services
{
    public interface IAuthenticationService
    {
        Task<ResponseDto<TokenDto>> CreateTokenAsync(LoginDto loginDto);
        Task<ResponseDto<TokenDto>> CreateTokenByRefreshToken(string refreshToken);
        Task<ResponseDto<BlankDto>> RevokeRefreshToken(string refreshToken);   
    }
}
