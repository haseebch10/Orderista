using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Orderista.Models
{
    public class Customer
    {
        [Key]
        public int CuId { get; set; }
        public string Name { get; set; }
        //[Display(Name = "Office Email")]
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$",
        ErrorMessage = "Invalid email format")]
        [Required]
        public string Email { get; set; }

        [Required]

        [MaxLength (3, ErrorMessage= "Room No can not exceed 3 digits")]
        public int Room { get; set; }

        public Host? Hostel { get; set; }

        [Required, MaxLength(11, ErrorMessage="Invalid Phone format ")]

        public int Phone { get; set; }

    }
}
