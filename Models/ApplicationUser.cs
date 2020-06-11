using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Orderista.Models
{
    public class ApplicationUser: IdentityUser
    {
        public string Name { get; set; }

        public int Room { get; set; }

        public Host? Hostel { get; set; }

        public int RollNo { get; set; }

        public int RuId { get; set; }

       

       
       

    }
}
