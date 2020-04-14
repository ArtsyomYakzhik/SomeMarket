using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace SomeMarket.Models.DBModels
{
    public class MarketDbContext: DbContext
    {
        public MarketDbContext(DbContextOptions<MarketDbContext> options):base(options)
        {

        }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartProduct> CartProducts { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }

    }
}
