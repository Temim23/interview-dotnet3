using GroceryStoreAPI.API.Controllers;
using GroceryStoreAPI.Application.Interfaces;
using GroceryStoreAPI.Application.ViewModels;
using NSubstitute;
using System;
using Xunit;

namespace GroceryStoreAPI.Test.Controllers
{
    public class CustomersControllerTests
    {
        private ICustomerService subCustomerService;

        public CustomersControllerTests()
        {
            this.subCustomerService = Substitute.For<ICustomerService>();
        }

        private CustomersController CreateCustomersController()
        {
            return new CustomersController(
                this.subCustomerService);
        }

        [Fact]
        public void Get_StateUnderTest_ExpectedBehavior1()
        {
            // Arrange
            var customersController = this.CreateCustomersController();

            // Act
            var result = customersController.Get();

            // Assert
            Assert.True(true);
        }

        [Fact]
        public void Get_StateUnderTest_ExpectedBehavior2()
        {
            // Arrange
            var customersController = this.CreateCustomersController();
            int id = 0;
          
            // Act
            var result = customersController.Get(id);

            // Assert
            Assert.True(true);
        }

        [Fact]
        public void Put_StateUnderTest_ExpectedBehavior1()
        {
            // Arrange
            var customersController = this.CreateCustomersController();
            CustomerViewModel customerViewModel = null;

            // Act
            var result = customersController.Put(
                customerViewModel);

            // Assert
            Assert.True(true);
        }

        [Fact]
        public void Post_StateUnderTest_ExpectedBehavior1()
        {
            // Arrange
            var customersController = this.CreateCustomersController();
            CustomerViewModel customerViewModel = null;

            // Act
            var result = customersController.Post(
                customerViewModel);

            // Assert
            Assert.True(true);
        }
    }
}
