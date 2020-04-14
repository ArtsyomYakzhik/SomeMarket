using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SomeMarket.Models.DBModels
{
    public abstract class BaseRepository
    {
        protected string ConnectionString { get; }
        protected IMarketDbContextFactory ContextFactory { get; }

        public BaseRepository(string connectionString, IMarketDbContextFactory contextFactory)
        {
            ConnectionString = connectionString;
            ContextFactory = contextFactory;
        }
    }
}
