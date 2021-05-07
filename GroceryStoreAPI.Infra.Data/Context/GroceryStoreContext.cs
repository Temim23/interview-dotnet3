using GroceryStoreAPI.Domain.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace GroceryStoreAPI.Infra.Data.Context
{
    public class GroceryStoreContext
    {
        public GroceryStoreContext()
        {
            var filePath= Environment.CurrentDirectory.ToString()+"\\database.json";

            using (StreamReader file = File.OpenText(filePath))
            {
                //(@"E:\Assesment\GroceryStoreAPI.Infra.Data\database.json")
                using (JsonTextReader reader = new JsonTextReader(file))
                {
                    JObject jObject = (JObject)JToken.ReadFrom(reader);

                    var data = jObject.ToObject<CustomerData>();
                    Customers = data.Customers;
                }

            }
            
        }

        public List<Customer> Customers { get; set; }
    }
}

public class CustomerData
{
    public List<Customer> Customers { get; set; }
}
