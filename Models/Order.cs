﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Orderista.Models
{
    public class Order
    {
        public int Id { get; set; }

        public List<Cart> Cartitems { get; set; }
    }
}
