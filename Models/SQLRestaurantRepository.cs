using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Orderista.Models
{
    public class SQLRestaurantRepository: IRestaurantRepository
    {
        private AppDbContext context;

        public SQLRestaurantRepository(AppDbContext context)
        {
            this.context = context;

        }

        public Restaurant Add(Restaurant restaurant)
        {
            context.Restaurants.Add(restaurant);
            context.SaveChanges();
            return restaurant;
        }

        public Restaurant Delete(int Ruid)
        {
            Restaurant restaurant = context.Restaurants.Find(Ruid);
            if (restaurant != null)
            {
                context.Restaurants.Remove(restaurant);
                context.SaveChanges();
            }
            return restaurant;
        }

       
        public IEnumerable<Restaurant> GetAllRestaurants()
        {
            return context.Restaurants;
        }

     

        public Restaurant GetRestaurant(int RuId)
        {
            return context.Restaurants.Find(RuId);
        }

        public Restaurant Update(Restaurant restaurantchanges)
        {
            var restaurant = context.Restaurants.Attach(restaurantchanges);
            restaurant.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return restaurantchanges;
        }
    }
}
