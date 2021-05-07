using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using GroceryStoreAPI.Domain.Models;
using GroceryStoreAPI.Application.ViewModels;

namespace GroceryStoreAPI.Application.AutoMapper
{
    public class DomainToViewModelProfile : Profile
    {
        public DomainToViewModelProfile()
        {
            CreateMap<Customer, CustomerViewModel>();
            
        }
    }
}
