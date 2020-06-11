using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Orderista.Models
{
    public interface RestaurantMenu 
    {
        MenuItem Getitem(int id);
        List <MenuItem> GetMenu(int id);
        MenuItem Add(MenuItem menuitem);

        MenuItem Update(MenuItem Menuchanges);

        MenuItem Delete(int id);


    }
}
