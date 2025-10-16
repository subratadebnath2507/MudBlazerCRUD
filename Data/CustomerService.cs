using System.Collections.Generic;
using System.Linq;

namespace MudBlazerCRUD.Data
{
    public class CustomerService: ICustomerService
    {
        private readonly ApplicationDbContext _dbcontext;
        public CustomerService(ApplicationDbContext context)
        {
            _dbcontext = context;
        }

        public void DeleteCustomer(int id)
        {
            var customer = _dbcontext.Customers.FirstOrDefault(x => x.Id == id);
            if (customer != null)
            {
                _dbcontext.Customers.Remove(customer);
                _dbcontext.SaveChanges();
            }
        }

        public Customer GetCustomerById(int id)
        {
            return _dbcontext.Customers.SingleOrDefault(x => x.Id == id);
        }

        public List<Customer> GetAllCustomers()
        {
            return _dbcontext.Customers.ToList();
        }
        
        public void SaveCustomer(Customer customer)
        {
            if (customer.Id == 0)
            {
                _dbcontext.Customers.Add(customer);
            }
            else
            {
                var existingCustomer = _dbcontext.Customers.FirstOrDefault(x => x.Id == customer.Id);
                if (existingCustomer != null)
                {
                    existingCustomer.FirstName = customer.FirstName;
                    existingCustomer.LastName = customer.LastName;
                    existingCustomer.PhoneNumber = customer.PhoneNumber;
                }
            }
            _dbcontext.SaveChanges();
        }
       
    }
}
