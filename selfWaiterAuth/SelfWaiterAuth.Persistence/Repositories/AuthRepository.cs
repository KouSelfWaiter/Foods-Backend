using Microsoft.EntityFrameworkCore;
using SelfWaiterAuth.Application.Repositories;
using SelfWaiterAuth.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfWaiterAuth.Persistence.Repositories
{
    public class AuthRepository<T> : IAuthRepository<T> where T : class
    {
        private readonly AppDbContext _appDbContext;

        public AuthRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public DbSet<T> Table => _appDbContext.Set<T>();

        public async Task<int> SaveAsync()
            => await _appDbContext.SaveChangesAsync();
    }
}
