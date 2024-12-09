using Project2_retry.Controllers;
using Project2_retry.DataServices;
using Project2_retry.Models;
using System;

namespace Project2_retry
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Product Management System".PadLeft(70));

            DbService.products.Add(new Product { Id = 1, Name = "Monitor", Price = 15000, Quantity = 10, ProductTypeId = 1 });
            DbService.products.Add(new Product { Id = 2, Name = "KeyBoard", Price = 250, Quantity = 10, ProductTypeId = 1 });
            DbService.products.Add(new Product { Id = 3, Name = "Speaker", Price = 100, Quantity = 10, ProductTypeId = 1 });
            DbService.products.Add(new Product { Id = 4, Name = "Shirt", Price = 150, Quantity = 10, ProductTypeId = 2 });
            DbService.products.Add(new Product { Id = 5, Name = "Jeans", Price = 550, Quantity = 10, ProductTypeId = 2 });
            DbService.products.Add(new Product { Id = 6, Name = "Hoodie", Price = 35, Quantity = 10, ProductTypeId = 2 });
            DbService.products.Add(new Product { Id = 7, Name = "Jack Fruit", Price = 150, Quantity = 10, ProductTypeId = 3 });
            DbService.products.Add(new Product { Id = 8, Name = "Paneer", Price = 500, Quantity = 10, ProductTypeId = 3 });
            DbService.products.Add(new Product { Id = 9, Name = "Dates", Price = 100, Quantity = 10, ProductTypeId = 3 });

            DbService.productType.Add(new ProductType { Id = 1, Name = "Electronics" });
            DbService.productType.Add(new ProductType { Id = 2, Name = "Groceries" });
            DbService.productType.Add(new ProductType { Id = 3, Name = "Fashion" });

            Cart cart1 = new Cart();
            DbService.users.Add(new User { Id = 1, Name = "Jack" });
            DbService.userCart.Add(cart1);
            cart1.CartID = 1;

            Cart cart2 = new Cart();
            DbService.users.Add(new User { Id = 2, Name = "Oggy" });
            DbService.userCart.Add(cart2);  
            cart2.CartID = 2;

            Start();
            Console.ReadLine();
        }

        public static void Start()
        {
            Console.WriteLine("Enter   1 for User Operation \n\t2 for Product Operation \n\t3 for product type operation \n\t4 to Exit");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    UserController.UserOperation();
                    Start();
                    break;
                case 2:
                    ProductController.ProductOperation();
                    Start();
                    break;
                case 3:
                    ProductTypeController.ProductTypeOperation();
                    Start();
                    break;
                case 4:
                    System.Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid Option");
                    break;
            }
        }
    }
}
