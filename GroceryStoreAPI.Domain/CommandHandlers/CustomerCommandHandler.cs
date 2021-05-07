using GroceryStoreAPI.Domain.Commands;
using GroceryStoreAPI.Domain.Interfaces;
using GroceryStoreAPI.Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GroceryStoreAPI.Domain.CommandHandlers
{
    public class CustomerCommandHandler : IRequestHandler<CreateCustomerCommand, bool>
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerCommandHandler(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public Task<bool> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
        {
            var customer = new Customer()
            {
                id = request.id,
                name = request.name,
            };

       _customerRepository.Add(customer);

            return Task.FromResult(true);
        }
    }
}
