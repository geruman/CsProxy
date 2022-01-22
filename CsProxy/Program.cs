using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsProxy
{
    class Program
    {
        static void Main(string[] args)
        {
            IRepository customers = new CustomerRepositoryProxy();
            Session.CanSave = true;
            Session.CanGetAll = true;
            customers.Save(new Customer("Juan"));
            customers.Save(new Customer("Pedro"));
            customers.Save(new Customer("Pablo"));
            Console.WriteLine("Listado de clientes: ");
            foreach(Customer customer in customers.GetAll())
            {
                Console.WriteLine(customer.Name);
            }
            Console.WriteLine("Pulse una tecla para continuar...");
            Console.ReadKey();
        }
    }
}
