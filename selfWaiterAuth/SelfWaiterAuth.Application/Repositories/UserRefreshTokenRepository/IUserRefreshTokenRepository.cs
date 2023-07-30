using SelfWaiterAuth.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfWaiterAuth.Application.Repositories.UserRefreshTokenRepository
{
    public interface IUserRefreshTokenRepository: IAuthRepository<UserRefreshToken>
    {
    }
}
