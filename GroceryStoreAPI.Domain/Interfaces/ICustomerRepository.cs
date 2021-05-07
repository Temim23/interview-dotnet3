using GroceryStoreAPI.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GroceryStoreAPI.Domain.Interfaces
{
    public interface ICustomerRepository
    {
        IQueryable<Customer> GetCustomers();

        Customer GetCustomer(int id);

        Customer UpdateCustomer(Customer customer);
        void Add(Customer customer);
    }
}
