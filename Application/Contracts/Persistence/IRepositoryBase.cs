using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Contracts.Infrastructure
{
    public interface IRepositoryBase<T> where T : class
    {
        Task<IEnumerable<T>> GetAll();
        Task Add(T entity);
        Task AddRange(IEnumerable<T> entities);
    }
}
