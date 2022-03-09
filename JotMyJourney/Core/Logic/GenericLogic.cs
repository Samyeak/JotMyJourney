using JotMyJourney.Interface.Core;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace JotMyJourney.Core.Logic
{
    public class GenericLogic<T> where T : BaseModel
    {
        private readonly IGenericRepository<T> Repo;
        public GenericLogic(IGenericRepository<T> repo)
        {
            Repo = repo;
        }

        public virtual async Task<T> GetAsync(int id)
        {
            return await Repo.GetAsync(id);
        }

        public virtual IEnumerable<T> GetEnumerable()
        {
            return Repo.GetEnumerable();
        }

        public virtual async Task<IEnumerable<T>> GetListAsync()
        {
            return await Repo.GetListAsync();
        }

        public virtual async Task AddAsync(T data)
        {
            await Repo.AddAsync(data);
        }

        public virtual async Task UpdateAsync(T data)
        {
            await Repo.UpdateAsync(data);
        }

        public virtual async Task DeleteAsync(int id)
        {
            await Repo.DeleteAsync(id);
        }
        public virtual async Task DeleteAsync(T data)
        {
            await Repo.DeleteAsync(data);
        }
    }
}
