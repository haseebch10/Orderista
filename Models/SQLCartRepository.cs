using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Orderista.Models
{
    public class SQLCartRepository : ICartRepository
    {
        private AppDbContext context;

        public SQLCartRepository(AppDbContext context)
        {
            this.context = context;
            

        }

        public Cart Add(Cart Newitem)
        {
            /*var items = context.carts.ToList();
            int z = 0;

            

            foreach (var item in items)
            {
                if (item.Item.MId == Newitem.Item.MId)
                {
                    item.Quantity++;
                    z++;

                }

                
            }

            if(z!=0)
            {
            */
                context.carts.Add(Newitem);
                context.SaveChanges();
                return Newitem;
                

          //  }

            

            
        }

        public void Delete(Cart delItem)
        {
            var items = context.carts.ToList();
         





            foreach (var item in items)
            {
                if (item.Item.MId == delItem.Item.MId )
                {
                    item.Quantity--;
                    if(item.Quantity==0)
                    {
                        context.carts.Remove(item);
                        context.SaveChanges();

                    }

                }
            }

         

        }

        public IEnumerable<Cart> GetAllItems()
        {
            return context.carts;

        }

        public MenuItem Getitem(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
