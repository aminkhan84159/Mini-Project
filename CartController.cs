using Project2_retry.Manager;
using System;

namespace Project2_retry.Controllers
{
    public class CartController
    {
        public static int id;
        public static void CartOperation(int uid)
        {
            Console.WriteLine("Enter   1 to Add Product to cart \n\t2 to Remove product from cart \n\t3 to view cart \n\t4 to view Inventory \n\t5 to go back");
            int type = Convert.ToInt32(Console.ReadLine());

            switch (type)
            {
                case 1:
                    Console.Write("Enter Product's ID : ");
                    id = Convert.ToInt32(Console.ReadLine());

                    CartManager.AddToCart(id, uid);
                    Console.WriteLine();
                    CartOperation(uid);
                    break;
                case 2:
                    Console.Write("Enter Product's ID : ");
                    id = Convert.ToInt32(Console.ReadLine());

                    CartManager.RemoveFromCart(id, uid);
                    CartOperation(uid);
                    break;
                case 3:
                    CartManager.CartList(uid);
                    CartOperation(uid);
                    break;
                case 4:
                    ProductManager.Displayproduct();
                    CartOperation(uid);
                    break;
                case 5:
                    return;
                default:
                    Console.WriteLine("Invalid Option");
                    break;
            }
        }
    }
}
