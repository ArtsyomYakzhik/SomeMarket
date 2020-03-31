using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SomeMarket.Controllers
{
    public class Home: Controller
    {
        public IEnumerable<string> Index()
        {
            return new List<string>() { "Sam: Sasi" };
        }
    }
}
