using SelfWaiterAuth.Application.Dtos;
using SelfWaiterAuth.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfWaiterAuth.Application.Services
{
    public interface ITokenService
    {
        Task<TokenDto> CreateToken(UserApp userApp);
    }
}
