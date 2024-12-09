using Project2_retry.Manager;
using System;

namespace Project2_retry.Controllers
{
    public class ProductTypeController
    {
        public static string type;
        public static void ProductTypeOperation()
        {
            Console.WriteLine("Enter   1 to Add product type \n\t2 to Delete product type \n\t3 to view product type \n\t4 to go back");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter Product's type : ");
                    type = Console.ReadLine();
                    ProductTypeManager.AddPType(type);
                    Console.WriteLine();
                    ProductTypeOperation();
                    break;
                case 2:
                    Console.Write("Enter Product's type : ");
                    type = Console.ReadLine();
                    ProductTypeManager.RemovePType(type);
                    Console.WriteLine();
                    ProductTypeOperation();
                    break;
                case 3:
                    ProductTypeManager.DisplayPType();
                    Console.WriteLine();
                    ProductTypeOperation();
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
