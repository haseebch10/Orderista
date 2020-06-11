using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Orderista.Models
{
    public class Restaurant
    {

       
      
        [Key]
        public int RuId { get; set; }
        public string Name { get; set; }
        //[Display(Name = "Office Email")]

        public List<MenuItem> Menu { get; set; }








        //[Required, MaxLength(11, ErrorMessage = "Invalid Phone format ")]

        public int Phone { get; set; }
    }
}
