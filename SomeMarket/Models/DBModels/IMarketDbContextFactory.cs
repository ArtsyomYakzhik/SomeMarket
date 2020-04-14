using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SomeMarket.Models.DBModels
{
    public interface IMarketDbContextFactory
    {
        public MarketDbContext CreateMarketDbContext(string connectionString);
    }
}
