using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookApp.Shared
{
    public interface ICrudRepositoryBase<T, TIdentifier>
    {
        Task<T> AddAsync(T model);
        Task<List<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task<bool> UpdateAsync(T model);
        Task<bool> DeleteAsync(TIdentifier id);
    }

    public interface IBookCrudRepository<T> : ICrudRepositoryBase<T, int>
    {
        // Empty   
    }
}
