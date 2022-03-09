using Microsoft.EntityFrameworkCore;
using System.Data;

namespace JotMyJourney.Core.Repository
{
    public abstract class BaseRepository
    {
        public DbContext Context { get; set; }
        public IDbConnection Connection => Context.Database.GetDbConnection();

        public BaseRepository(DatabaseContext context)
        {
            Context = context;
        }
    }
}