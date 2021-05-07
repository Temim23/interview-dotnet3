using GroceryStoreAPI.Domain.Core.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace GroceryStoreAPI.Domain.Commands
{
    public class CustomerCommand : Command
    {
        public int id { get; protected set; }
        public string name { get; protected set; }
        
    }
}
