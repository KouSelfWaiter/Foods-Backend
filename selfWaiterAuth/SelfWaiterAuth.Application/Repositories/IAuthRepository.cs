using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfWaiterAuth.Application.Repositories
{
    public interface IAuthRepository<T> where T : class
    {
        Task<int> SaveAsync();
        DbSet<T> Table { get; }
    }
}
