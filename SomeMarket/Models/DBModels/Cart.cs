using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SomeMarket.Models.DBModels
{
    public class Cart
    {
        public int Id { get; set; }
        public int OrderStatus { get; set; }

        public List<CartProduct> CartProducts { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }


    }
}
