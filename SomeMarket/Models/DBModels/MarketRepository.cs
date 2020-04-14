using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SomeMarket.Models.DBModels
{
    public class MarketRepository:BaseRepository
    {
        public MarketRepository(string connectionString, IMarketDbContextFactory contextFactory):
            base(connectionString, contextFactory)
        {
        }

        public async Task<List<Product>> GetProducts()
        {
            using (var context = ContextFactory.CreateMarketDbContext(ConnectionString))
            {
                List<Product> result = new List<Product>();
                await foreach(var item in context.Products.AsAsyncEnumerable())
                {
                    result.Add(item);
                }
                return result;
            }
        }
    }
}
