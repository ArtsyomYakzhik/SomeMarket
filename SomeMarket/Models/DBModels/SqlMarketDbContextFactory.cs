using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SomeMarket.Models.DBModels
{
    public class SqlMarketDbContextFactory : IMarketDbContextFactory
    {
        public MarketDbContext CreateMarketDbContext(string connectionString)
        {
            var optionsBuilder = new DbContextOptionsBuilder<MarketDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new MarketDbContext(optionsBuilder.Options);

        }
    }
}
