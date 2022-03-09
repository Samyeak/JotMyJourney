using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace JotMyJourney.Interface.Core
{
    public interface IGenericRepository<T> where T : BaseModel
    {
        DbSet<T> Entity { get; }
        Task<T> GetAsync(int id);
        IEnumerable<T> GetEnumerable();
        Task<IEnumerable<T>> GetListAsync();
        Task AddAsync(T data);
        Task UpdateAsync(T data);
        Task DeleteAsync(int id);
        Task DeleteAsync(T data);
    }
}
