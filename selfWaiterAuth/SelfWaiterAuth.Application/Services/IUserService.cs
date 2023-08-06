using Core.Security.Dtos;
using SelfWaiterAuth.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfWaiterAuth.Application.Services
{
    public interface IUserService
    {
        Task<ResponseDto<BlankDto>> CreateUserAsync(CreateUserDto createUserDto);
        Task<ResponseDto<UserAppDto>> GetUserByUserName(string userName);
        Task<ResponseDto<BlankDto>> CreateUserRolesAsync(string userName);
    }
}
