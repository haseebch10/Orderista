using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Orderista.Models;
using Orderista.ViewModel;

namespace Orderista.Controllers
{
    [Authorize(Roles = "Restaurants, Admin, Customers")]
    public class OrderController : Controller
    {
        private readonly AppDbContext Cartcontext;
        private readonly AppDbContext Menucontext;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly AppDbContext Ordercontext;

        private IOrderRepository _orderRepository { get; }

        public OrderController(AppDbContext Menucontext, IOrderRepository orderRepository, UserManager<ApplicationUser> userManager, AppDbContext Cartcontext, AppDbContext Ordercontext)
        {
            this.Cartcontext = Cartcontext;
           
            this.userManager = userManager;
            _orderRepository = orderRepository;

            this.Ordercontext = Ordercontext;

            this.Menucontext = Menucontext;


        }

        [Authorize]
        public IActionResult Index()
        {
            var userId = userManager.GetUserId(HttpContext.User);

            List<Cart> OrderItems = Cartcontext.carts.Where(emp => emp.UserId == userId).ToList();

             return View(OrderItems);
           
        }

        [Authorize]

        public IActionResult PlaceOrder()
        {
            

            var userId = userManager.GetUserId(HttpContext.User);


            List<Cart> OrderItems = Cartcontext.carts.Where(emp => emp.UserId == userId).ToList();





            Order NewOrder = new Order()
            {
               Cartitems=OrderItems
              
            };
            _orderRepository.Add(NewOrder);


            return RedirectToAction("Index", "Home");









            //return RedirectToAction("ViewCart", "Cart");

        }

        public async Task<IActionResult> RestaurantOrder()
        {
            var userId = userManager.GetUserId(HttpContext.User);


            int restaurantid = 0;


            foreach (var user in userManager.Users)
            {
                if(user.Id==userId)
                {
                     restaurantid = user.RuId;

                }

              


            }



            List<OrderViewModel> model = new List<OrderViewModel>();

            List<Order> orders = Ordercontext.orders.ToList();


           // List<Cart> OrderItems = Cartcontext.carts.Where(emp => emp.OrderId == 4 && emp.Item.RestaurantRuId == 4).ToList();

            

            List<MenuItem> bucket = new List<MenuItem>();




            //List<Cart> OrderItems = Cartcontext.carts.Where(emp => emp. == userId).ToList();

            foreach (var ord in orders)
             {
                 OrderViewModel orderViewModel = new OrderViewModel();
                 orderViewModel.Items = new List<MenuItem>();
                 orderViewModel.OrderId = ord.Id;
                 List<Cart> OrderItems = Cartcontext.carts.Where(emp => emp.OrderId ==ord.Id && emp.Item.RestaurantRuId==restaurantid).ToList();
                int sum = 0;
                 foreach (var order in OrderItems)
                 {
                    var userid = order.UserId;
                    var user = await userManager.FindByIdAsync(userid);

                    orderViewModel.Hostel = user.Hostel;
                    orderViewModel.PhoneNo = user.PhoneNumber;
                    orderViewModel.RoomNo = user.Room;
                    orderViewModel.Name = user.Name;
                    // orderViewModel.Items.Add(order.Item);
                   
                    var a = Menucontext.Menu.Find(order.ItemMId);
                    sum = sum + a.Price;
                    orderViewModel.Items.Add(a);





                }
                orderViewModel.Total = sum;
                 model.Add(orderViewModel);
             }






             return View(model);
             

           
        }
    }
}