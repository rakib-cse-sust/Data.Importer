using Application.Contracts.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.Repositories
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected RepositoryContext _repositoryContext { get; set; }

        public RepositoryBase(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _repositoryContext.Set<T>().AsNoTracking().ToListAsync();
        }

        public async Task Add(T entity)
        {
            await _repositoryContext.Set<T>().AddAsync(entity);
        }

        public async Task AddRange(IEnumerable<T> entities)
        {
            await _repositoryContext.Set<T>().AddRangeAsync(entities);
        }
    }
}
