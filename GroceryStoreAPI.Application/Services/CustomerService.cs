using AutoMapper;
using AutoMapper.QueryableExtensions;
using GroceryStoreAPI.Application.Interfaces;
using GroceryStoreAPI.Application.ViewModels;
using GroceryStoreAPI.Domain.Commands;
using GroceryStoreAPI.Domain.Core.Bus;
using GroceryStoreAPI.Domain.Interfaces;
using GroceryStoreAPI.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GroceryStoreAPI.Application.Services
{
    public class CustomerService : ICustomerService
    {
        private ICustomerRepository _customerRepository;
        private readonly IMediatorHandler _bus;
        private readonly IMapper _autoMapper;

        public CustomerService(ICustomerRepository customerRepository, IMediatorHandler bus, IMapper autoMapper)
        {
            _customerRepository = customerRepository;
            _bus = bus;
            _autoMapper = autoMapper;
        }

        public void Create(CustomerViewModel customerViewModel)
        {
            
            var createCustomerCommand = _autoMapper.Map<CreateCustomerCommand>(customerViewModel);
            _bus.SendCommand(createCustomerCommand);
        }


        public IEnumerable<CustomerViewModel> GetCustomers()
        {
            return _customerRepository.GetCustomers()
               .ProjectTo<CustomerViewModel>(_autoMapper.ConfigurationProvider);
        }

        public CustomerViewModel GetCustomer(int id)
        {
            var customer = _customerRepository.GetCustomer(id);
            return _autoMapper.Map<CustomerViewModel>(customer);
        }

        public CustomerViewModel UpdateCustomer(CustomerViewModel customer)
        {
            var updatedCustomer = _customerRepository.UpdateCustomer(_autoMapper.Map<Customer>(customer));
            return _autoMapper.Map<CustomerViewModel>(updatedCustomer);
        }
    }
}
