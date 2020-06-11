using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Orderista.Models;
using Orderista.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace Orderista.Controllers
{
    [Authorize(Roles = "Admin, Customers")]
    public class CartController : Controller
    {
        private readonly AppDbContext Menucontext;

        private readonly AppDbContext Cartcontext;
        private readonly UserManager<ApplicationUser> userManager;
    




        private ICartRepository _cartRepository { get; }

        public CartController(UserManager<ApplicationUser> userManager, AppDbContext Menucontext, AppDbContext Cartcontext, ICartRepository cartRepository)
        {
            this.Menucontext = Menucontext;
            this.Cartcontext = Cartcontext;
            _cartRepository = cartRepository;
            this.userManager = userManager;

        }

        [Authorize]
        public ActionResult Index(int restaurantid)
        {

            List<MenuItem> menu = Menucontext.Menu.Where(emp => emp.RestaurantRuId == restaurantid).ToList();

            return View(menu);
        }




        [HttpGet]
        [Authorize]

        public ViewResult AddtoCart()
        {
            return View();
        }


        [HttpPost]
        [Authorize]
        public IActionResult AddtoCart(int id)
        {
           var userId=  userManager.GetUserId(HttpContext.User);



                Cart NewItem = new Cart()
                {
                    
                    
                    ItemMId=id,
                    Quantity =1,
                    Item= Menucontext.Menu.Find(id),
                    UserId= userId,
                    OrderId= 1
                    
                    
                    
                    
                    

                };
                _cartRepository.Add(NewItem);




            return RedirectToAction("ViewCart", "Cart");




            



        }
        [Authorize]
        public ViewResult ViewCart()
        {
            var userId = userManager.GetUserId(HttpContext.User);

            List<MenuItem> Cartmenu = new List<MenuItem>();
            List<Cart> Cartitems = Cartcontext.carts.ToList();
            MenuItem newitem;
            

            foreach (var item in Cartitems)
            {
                if (item.UserId == userId)
                {
                    var z = item.ItemMId;
                    newitem = Cartcontext.Menu.Find(z);
                    Cartmenu.Add(newitem);
                }


            }


            return View(Cartmenu);

        }


               
                //return RedirectToAction("detail", new { id = newEmployee.Id });
           
        


    }
}