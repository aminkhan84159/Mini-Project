using Project2_retry.DataServices;
using Project2_retry.Models;
using System;
using System.Collections.Generic;

namespace Project2_retry.Manager
{
    public class ProductTypeManager
    {
        public static int id { get; set; } = 4;
        public static string AddPType(string name)
        {
            if (DbService.ContainsProductType(name))
            {
                Console.WriteLine($"Product with {name} already exist");
            }
            else
            {
                DbService.AddProductType(id, name);
                id++;
                Console.WriteLine("Added Successfully");
            }

            return name;
        }

        public static string RemovePType(string name)
        {
            var pId = DbService.ContainsProductName(name);

            if (DbService.ContainsProductType(name))
            {
                if (DbService.ContainsProductTypeId(pId))
                {
                    Console.WriteLine("Can't delete this product type ");
                }
                else
                {
                    DbService.RemoveProductType(name);
                    id--;
                    Console.WriteLine("Deleted Successfully");
                }
            }
            else
            {
                Console.WriteLine($"Product with type {name} doesn't exist");
            }

            return name;
        }

        public static List<ProductType> DisplayPType()
        {
            var productTypes = DbService.DisplayProductType();

            foreach (var productType in productTypes)
            {
                Console.WriteLine($"ID : {productType.Id} , Name  : {productType.Name}");
            }

            return DbService.DisplayProductType();
        }
    }
}
