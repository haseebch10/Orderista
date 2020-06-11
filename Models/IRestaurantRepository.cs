using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Orderista.Models
{
    public interface IRestaurantRepository
    {
        Restaurant GetRestaurant(int RuId);
        IEnumerable<Restaurant> GetAllRestaurants();

      
        Restaurant Add(Restaurant restaurant);

        Restaurant Update(Restaurant restaurantchanges);

        Restaurant Delete(int Ruid);
    }
}
