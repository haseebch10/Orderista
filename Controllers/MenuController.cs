using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Orderista.Models;

namespace Orderista.Controllers
{
    //[Authorize(Roles = "Admin, Customers")]
    public class MenuController : Controller
    {
        private readonly AppDbContext Menucontext;


        public MenuController(AppDbContext Menucontext)
        {
            this.Menucontext = Menucontext;
        }

        public ActionResult Index(int id)
            {
                
                List<MenuItem> menu = Menucontext.Menu.Where(emp => emp.RestaurantRuId == id).ToList();

                return View(menu);
            }
        
    }
}