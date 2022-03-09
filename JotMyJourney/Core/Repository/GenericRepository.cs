using JotMyJourney.Interface.Core;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JotMyJourney.Core.Repository
{
    public class GenericRepository<T> : BaseRepository, IGenericRepository<T> where T : BaseModel
    {
        public DbSet<T> Entity { get; }
        public GenericRepository(DatabaseContext context) : base(context)
        {
            Entity = Context.Set<T>();
        }

        public virtual async Task<T> GetAsync(int id)
        {
            return await Entity.AsNoTracking().SingleOrDefaultAsync(x => x.Id == id);
        }

        public virtual IEnumerable<T> GetEnumerable()
        {
            return Entity.AsNoTracking().AsEnumerable();
        }

        public virtual async Task<IEnumerable<T>> GetListAsync()
        {
            return await Entity.AsNoTracking().ToListAsync();
        }

        public virtual async Task AddAsync(T data)
        {
            Entity.Add(data);
            await Context.SaveChangesAsync();
        }

        public virtual async Task UpdateAsync(T data)
        {
            Entity.Update(data);
            await Context.SaveChangesAsync();
        }

        public virtual async Task DeleteAsync(int id)
        {
            var data = await Entity.FindAsync(id);
            Entity.Remove(data);
            await Context.SaveChangesAsync();
        }
        public virtual async Task DeleteAsync(T data)
        {
            await Entity.FindAsync(1);
            Entity.Remove(data);
            await Context.SaveChangesAsync();
        }
    }
}
