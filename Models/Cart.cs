using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Orderista.Models
{
    public class Cart
    {
        
        public  MenuItem Item { get; set; }

        [Key]

        public int id { get; set; }

        public int ItemMId { get; set; }

        public int Quantity { get; set; }

        public ApplicationUser User { get; set; }

        public string UserId { get; set; }

        public int OrderId { get; set; }








    }
}
