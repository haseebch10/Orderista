using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Orderista.Models
{
    public class SQLOrderRepository : IOrderRepository
    {
        private AppDbContext context;

        public SQLOrderRepository(AppDbContext context)
        {
            this.context = context;


        }

        public Order Add(Order NewOrder)
        {

            context.orders.Add(NewOrder);
            context.SaveChanges();
            return NewOrder;




        }
    }
}