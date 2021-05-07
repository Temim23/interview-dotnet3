using GroceryStoreAPI.Domain.Interfaces;
using GroceryStoreAPI.Domain.Models;
using GroceryStoreAPI.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GroceryStoreAPI.Infra.Data.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private GroceryStoreContext _ctx;
        public CustomerRepository(GroceryStoreContext ctx)
        {
            _ctx = ctx;
        }
       
        public void Add(Customer customer)
        {
            _ctx.Customers.Add(customer);
        }

        public Customer GetCustomer(int id)
        {
            var customer= _ctx.Customers.Find(f=> f.id==id);

            return customer;

        }

        public IQueryable<Customer> GetCustomers()
        {
            return _ctx.Customers.AsQueryable();
        }

        public Customer UpdateCustomer( Customer customer)
        {
            var updatedCustomer = new Customer();
          foreach(var item in _ctx.Customers)
            {
                if(item.id== customer.id)
                {
                    item.id = customer.id;
                    item.name = customer.name;
                    updatedCustomer= item;
                    break;
                }
              
            }

            return updatedCustomer;
        }
    }
}
