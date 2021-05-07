using System.Collections.Generic;
using GroceryStoreAPI.Application.ViewModels;

namespace GroceryStoreAPI.Application.Interfaces
{
    public interface ICustomerService
    {
        IEnumerable<CustomerViewModel> GetCustomers();

        CustomerViewModel GetCustomer(int id);
        CustomerViewModel UpdateCustomer(CustomerViewModel customer);
        void Create(CustomerViewModel customerViewModel);
    }
}
