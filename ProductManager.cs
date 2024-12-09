using Project2_retry.DataServices;
using Project2_retry.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Project2_retry.Manager
{
    public class ProductManager
    {
        public static object AddProduct(Product product)
        {
            DbService.AddProduct(product);
            Console.WriteLine("Product Added Successfully");
            Console.WriteLine();

            return product;
        }

        public static int DeleteProduct(int id)
        {
            if (DbService.ContainsProduct(id))
            {
                DbService.RemoveProduct(id);
            }
            else
            {
                Console.WriteLine($"Product with ID {id} doesn't exixst");
            }

            Console.WriteLine();
            return id;
        }

        public static List<Product> Displayproduct()
        {
            if (DbService.ProductCount())
            {
                Console.WriteLine("The Inventory is Empty");
            }
            else
            {
                var products = DbService.DisplayProducts();

                foreach (var product in products)
                {
                    var productType = DbService.productType.Where(x => x.Id == product.ProductTypeId).FirstOrDefault();
                    Console.WriteLine($"ID : {product.Id} , Name : {product.Name}, Quantity : {product.Quantity} , Price : {product.Price}. ProductType : {productType.Name} ");
                }
            }

            return DbService.DisplayProducts();
        }
    }
}
