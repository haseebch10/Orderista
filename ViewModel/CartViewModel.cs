using Orderista.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Orderista.ViewModel
{
    public class CartViewModel
    {
       public List<MenuItem> Items { get; set; }

        public int Total { get; set; }

        public int Quantity { get; set; }
    }
}
