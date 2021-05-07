using GroceryStoreAPI.Application.Interfaces;
using GroceryStoreAPI.Application.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryStoreAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_customerService.GetCustomers());
        }

        [HttpGet("{id:int}")]
        public IActionResult Get(int id)
        {
            var customer = new CustomerViewModel();
            try
            {
                customer = _customerService.GetCustomer(id);
                if (customer == null)
                {
                    return NotFound();
                }
            }
            catch(Exception ex)
            {
                return Ok(ex.Message);
            }
            
            return Ok(customer);
        }

        [HttpPut]
        public IActionResult Put([FromBody] CustomerViewModel customerViewModel)
        {
            var updatedCustomer = new CustomerViewModel();
            try
            {
                if (customerViewModel == null)
                {
                    return BadRequest();
                }
                else
                {
                    updatedCustomer = _customerService.UpdateCustomer(customerViewModel);

                    if (updatedCustomer == null)
                    {
                        return NotFound();
                    }
                }

            }
            catch(Exception ex)
            {
                return Ok(ex.Message);
            }

            return Ok(updatedCustomer);
        }

        [HttpPost]
        public IActionResult Post([FromBody] CustomerViewModel customerViewModel)
        {
            try
            {
                if (customerViewModel == null)
                {
                    return BadRequest();
                }
                _customerService.Create(customerViewModel);
            }
            catch(Exception ex)
            {
                return Ok(ex.Message);
            }
            return Ok(customerViewModel);
        }
    }
}
