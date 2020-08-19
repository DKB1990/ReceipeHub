using ChefDheeraj.Database.Models;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ChefDheeraj.Database.Interfaces
{
    public interface IRepository<T> where T : EntityBase
    {
        Task<T> GetByIdAsync(Expression<Func<T, bool>> filter);
        Task<IQueryable<T>> GetAllAsync();
        Task<T> SaveAsync(T receipe);
    }
}
