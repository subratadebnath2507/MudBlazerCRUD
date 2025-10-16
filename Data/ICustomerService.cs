using System.Collections.Generic;

namespace MudBlazerCRUD.Data
{
    public interface ICustomerService
    {
        List<Customer> GetAllCustomers();
        Customer GetCustomerById(int id);
        void SaveCustomer(Customer customer);
        void DeleteCustomer(int id);

    }
}
