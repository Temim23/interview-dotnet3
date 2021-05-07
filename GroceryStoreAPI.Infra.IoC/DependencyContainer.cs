using GroceryStoreAPI.Application.Interfaces;
using GroceryStoreAPI.Application.Services;
using GroceryStoreAPI.Domain.CommandHandlers;
using GroceryStoreAPI.Domain.Commands;
using GroceryStoreAPI.Domain.Core.Bus;
using GroceryStoreAPI.Domain.Interfaces;
using GroceryStoreAPI.Infra.Bus;
using GroceryStoreAPI.Infra.Data.Context;
using GroceryStoreAPI.Infra.Data.Repository;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace GroceryStoreAPI.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Domain InMemoryBus MediatR
            services.AddScoped<IMediatorHandler, InMemoryBus>();

            //Domain Handlers
            services.AddScoped<IRequestHandler<CreateCustomerCommand, bool>, CustomerCommandHandler>();

            //Application Layer 
            services.AddScoped<ICustomerService, CustomerService>();

            //Infra.Data Layer
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<GroceryStoreContext>();
        }
    }
}
