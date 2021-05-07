using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using GroceryStoreAPI.Application.ViewModels;
using GroceryStoreAPI.Domain.Commands;
using GroceryStoreAPI.Domain.Models;

namespace GroceryStoreAPI.Application.AutoMapper
{
    public class ViewModelToDomainProfile : Profile
    {
        public ViewModelToDomainProfile()
        {
            CreateMap<CustomerViewModel, CreateCustomerCommand>()
                .ConstructUsing(c => new CreateCustomerCommand(c.id, c.name));

            CreateMap<CustomerViewModel, Customer>();
               


        }
    }
}
