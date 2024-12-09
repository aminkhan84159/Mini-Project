using Project2_retry.DataServices;
using Project2_retry.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Project2_retry.Manager
{
    public class CartManager
    {
        public static int AddToCart(int id, int uid)
        {
            if (DbService.ContainsProduct(id))
            {
                DbService.AddToCart(id, uid);
                Console.WriteLine("Added Successfully");
                DbService.DeleteProductQuantity(id);
            }
            else
            {
                Console.WriteLine("There is no such product");
            }

            return id;
        }
        public static int RemoveFromCart(int id, int uid)
        {
            if (DbService.ContainsProductInCart(id))
            {
                DbService.RemoveFromCart(id, uid);
                Console.WriteLine("Removed Successfully");
            }
            else
            {
                Console.WriteLine($"Product with ID : {id} is not in the cart");
            }

            return id;
        }

        public static List<Cart> CartList(int uid)
        {
            if (DbService.CartCount(uid))
            {
                Console.WriteLine("Nothing in the cart");
            }
            else
            {
                var cart = DbService.DisplayCartProducts();

                foreach (var product in cart.Where(x => x.CartID == uid))
                {
                    product.cart.ForEach(x => 
                    {
                        Console.WriteLine($"ID : {x.Id}, Name : {x.Name}, Price : {x.Price}");
                    });
                }
            }

            return DbService.DisplayCartProducts();
        }
    }
}
