using Microsoft.EntityFrameworkCore;
using SelfWaiterAuth.Application.Repositories;
using SelfWaiterAuth.Application.Repositories.UserRefreshTokenRepository;
using SelfWaiterAuth.Domain.Entities;
using SelfWaiterAuth.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfWaiterAuth.Persistence.Repositories.UserRefreshTokenRepository
{
    public class UserRefreshTokenRepository : AuthRepository<UserRefreshToken>, IUserRefreshTokenRepository
    {
        public UserRefreshTokenRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
