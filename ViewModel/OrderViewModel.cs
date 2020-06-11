using Orderista.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Orderista.ViewModel
{
    public class OrderViewModel
    {
        public List<MenuItem> Items { get; set; }

        public int Total { get; set; }

        public int Quantity { get; set; }

        public int OrderId { get; set; }

        public int RoomNo {get; set;}

        public string PhoneNo { get; set; }

        public Host? Hostel { get; set; }

        public string Name { get; set; }
    }
}
