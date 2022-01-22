using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsProxy
{
    public class CustomerRepository:IRepository
    {
        IList<Customer> customers;
        public CustomerRepository()
        {
            customers = new List<Customer>();
        }

        public IList<Customer> GetAll()
        {
            return customers;
        }

        public void Save(Customer customer)
        {
            customers.Add(customer);
        }
    }
}
