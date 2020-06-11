using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Orderista.Models
{
    public interface IOrderRepository
    {
        Order Add(Order NewOrder);
    }
}
