using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Orderista.Models
{
    public interface ICartRepository
    {
        MenuItem Getitem(int Id);
        IEnumerable<Cart> GetAllItems();
        Cart Add(Cart newItem);

        

        void Delete(Cart delItem);

    }

}
