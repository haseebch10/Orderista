using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Orderista.Models;

namespace Orderista.Controllers.api
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantsController : ControllerBase
    {
        private AppDbContext restaurantcontext;

        public RestaurantsController(AppDbContext _restaurantcontext )
        {
            this.restaurantcontext = _restaurantcontext;


        }

        public IEnumerable<Restaurant> GetRestaurants()
        {
            return restaurantcontext.Restaurants.ToList();
        }

    }
}