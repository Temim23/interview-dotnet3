using System;
using System.Collections.Generic;
using System.Text;


namespace GroceryStoreAPI.Domain.Commands
{
    public class CreateCustomerCommand : CustomerCommand
    {
        public CreateCustomerCommand(int id, string name)
        {
            id = id;
            name = name;
           
        }
    }
}
