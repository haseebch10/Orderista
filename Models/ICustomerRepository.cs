using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Orderista.Models
{
    public interface ICustomerRepository
    {
        Customer GetCustomer(int Id);
        IEnumerable <Customer> GetAllCustomers();
        Customer Add(Customer customer);

        Customer Update(Customer customerchanges);

        Customer Delete(int id);

    }
}
