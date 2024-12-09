using Project2_retry.Manager;
using Project2_retry.Models;
using System;

namespace Project2_retry.Controllers
{
    public class ProductController
    {
        public static int id { get; set; } = 10;
        public static string name;
        public static int quantity;
        public static int price;
        public static void ProductOperation()
        {
            Console.WriteLine("Enter   1 to Add Product \n\t2 to Delete Product \n\t3 to View Products \n\t4 to go back");
            int select = Convert.ToInt32(Console.ReadLine());

            switch (select)
            {
                case 1:
                    Console.WriteLine("Select Product type");
                    Console.WriteLine("Enter   1 for Electronics \n\t2 for Groceries \n\t3 for Fashion");
                    int type = Convert.ToInt32(Console.ReadLine());

                    switch (type)
                    {
                        case 1:
                            Console.Write("Enter Product's Name : ");
                            name = Console.ReadLine();
                            Console.Write("Enter Product's Quantity : ");
                            quantity = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter Product's Price : ");
                            price = Convert.ToInt32(Console.ReadLine());

                            ProductManager.AddProduct(new Product { Id = id, Name = name, Price = price, Quantity = quantity, ProductTypeId = type });
                            id++;
                            Console.WriteLine();
                            ProductOperation();
                            break;
                        case 2:
                            Console.Write("Enter Product's Name : ");
                            name = Console.ReadLine();
                            Console.Write("Enter Product's Quantity : ");
                            quantity = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter Product's Price : ");
                            price = Convert.ToInt32(Console.ReadLine());

                            ProductManager.AddProduct(new Product { Id = id, Name = name, Price = price, Quantity = quantity, ProductTypeId = type });
                            id++;
                            Console.WriteLine();
                            ProductOperation();
                            break;
                        case 3:
                            Console.Write("Enter Product's Name : ");
                            name = Console.ReadLine();
                            Console.Write("Enter Product's Quantity : ");
                            quantity = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter Product's Price : ");
                            price = Convert.ToInt32(Console.ReadLine());

                            ProductManager.AddProduct(new Product { Id = id, Name = name, Price = price, Quantity = quantity, ProductTypeId = type });
                            id++;
                            Console.WriteLine();
                            ProductOperation();
                            break;
                        default:
                            Console.WriteLine("Invalid Option");
                            break;
                    }
                    break;
                case 2:
                    Console.Write("Enter Product's ID :");
                    int did = Convert.ToInt32(Console.ReadLine());

                    ProductManager.DeleteProduct(did);
                    Console.WriteLine();
                    ProductOperation();
                    break;
                case 3:
                    ProductManager.Displayproduct();
                    Console.WriteLine();
                    ProductOperation();
                    break;
                case 4:
                    return;
                default:
                    Console.WriteLine("Invalid Option");
                    break;
            }
        }
    }
}
