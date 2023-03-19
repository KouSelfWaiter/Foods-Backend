using Core.Persistence.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Persistence.Repositories
{
    public interface IRepository<T>
        where T : Entity
    {
        DbSet<T> Table { get; }
        Task<int> SaveAsync();
    }
}
