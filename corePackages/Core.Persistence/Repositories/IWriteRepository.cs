using Core.Persistence.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.Persistence.Repositories
{
    public interface IWriteRepository<T>: IRepository<T>
        where T : Entity
    {
        Task<bool> AddAsync(T entity);
        Task<bool> AddRangeAsync(List<T> entity);
        bool Remove(T entity);
        bool RemoveRange(List<T> entity);
        Task<bool> RemoveAsync(string id);
        bool Update(T entity);
    }
}
