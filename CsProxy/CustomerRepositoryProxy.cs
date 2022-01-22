using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsProxy
{
    public class CustomerRepositoryProxy : IRepository
    {
        IRepository realRepository;
        public CustomerRepositoryProxy()
        {
            realRepository = new CustomerRepository();
        }
        public IList<Customer> GetAll()
        {
            if (Session.CanGetAll)
            {
                return realRepository.GetAll();
            }
            else
            {
                throw new Exception("El usuario no tiene permisos de GetAll");
            }
        }

        public void Save(Customer customer)
        {
            if (Session.CanSave)
            {
                realRepository.Save(customer);
            }
            else
            {
                throw new Exception("El usuario no tiene permisos de Save");
            }

        }
    }
}
