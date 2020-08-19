using ChefDheeraj.Database.Interfaces;
using ChefDheeraj.Database.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ChefDheeraj.Database
{
    public class ChefRepository<T> : IRepository<T> where T : EntityBase
    {
        private readonly DbSet<T> _dbSet;
        private readonly ChefDbContext _dbContext;

        public ChefRepository(ChefDbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<T>();
        }
        public Task<IQueryable<T>> GetAllAsync()
        {
            return Task.FromResult(_dbSet.AsQueryable());
        }

        public Task<T> GetByIdAsync(Expression<Func<T, bool>> filter)
        {
            return _dbSet.FirstOrDefaultAsync(filter);
        }

        public Task<T> SaveAsync(T entity)
        {
            if (string.IsNullOrEmpty(entity.Id))
                entity.Id = Guid.NewGuid().ToString();
            return Task.FromResult(_dbSet.Add(entity).Entity);
        }
    }
}
