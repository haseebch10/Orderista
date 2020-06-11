using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Orderista.Models
{
    public class MenuItem
    {
     
        public string Photopath { get; set; }

        public string Category { get; set; }


     


        public int RestaurantRuId { get; set; }




        [Key]

        public int MId { get; set; }

        public string ItemName { get; set; }

        public int Price { get; set; }
      
    }
}
