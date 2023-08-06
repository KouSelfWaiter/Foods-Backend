using Core.Security.Dtos;
using Microsoft.AspNetCore.Identity;
using SelfWaiterAuth.Application.Dtos;
using SelfWaiterAuth.Application.Services;
using SelfWaiterAuth.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfWaiterAuth.Persistence.Services
{
    public class UserService : IUserService
    {
        private readonly UserManager<UserApp> _userManager;
        private readonly RoleManager<IdentityRole<string>> _roleManager;

        public UserService(UserManager<UserApp> userManager, RoleManager<IdentityRole<string>> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async Task<ResponseDto<BlankDto>> CreateUserAsync(CreateUserDto createUserDto)
        {
            var user = new UserApp()
            {
                Id = Guid.NewGuid().ToString(),
                Email = createUserDto.Email,
                UserName = createUserDto.UserName,
            };

            var result = await _userManager.CreateAsync(user, createUserDto.Password);

            if (!result.Succeeded)
            {
                var errors = result.Errors.Select(x => x.Description).ToList();

                return ResponseDto<BlankDto>.Fail(new ErrorDto(errors, true), 400);
            }

            return ResponseDto<BlankDto>.Sucess(201);
        }

        public async Task<ResponseDto<BlankDto>> CreateUserRolesAsync(string userName)
        {
            if (!await _roleManager.RoleExistsAsync("admin"))
            {
                await _roleManager.CreateAsync(new() {Id= Guid.NewGuid().ToString(), Name = "admin" });
            }

            var user = await _userManager.FindByNameAsync(userName);
            if (user == null) throw new Exception("User not found");

            await _userManager.AddToRoleAsync(user, "admin");

            return ResponseDto<BlankDto>.Sucess(201);

        }

        public async Task<ResponseDto<UserAppDto>> GetUserByUserName(string userName)
        {
            var user = await _userManager.FindByNameAsync(userName);
            if (user == null) return ResponseDto<UserAppDto>.Fail("UserName not Found", true, 404);

            return ResponseDto<UserAppDto>.Sucess(new() { Id=user.Id, UserName=user.UserName, Email=user.Email}, 200);
        }
    }
}
