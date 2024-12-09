using Project2_retry.Models;
using System.Collections.Generic;
using System.Linq;

namespace Project2_retry.DataServices
{
    public class DbService
    {
        public static List<User> users = new List<User>();
        public static List<Product> products = new List<Product>();
        public static List<Cart> userCart = new List<Cart>();
        public static List<ProductType> productType = new List<ProductType>();

        //User
        public static int AddUser(int id, string name, Cart cart)
        {
            users.Add(new User { Id = id, Name = name });
            userCart.Add(cart);
            return id;
        }

        public static int RemoveUser(int id)
        {
            users.RemoveAt(id);
            return id;
        }

        public static int SelectUser(int id)
        {
            var user = users.Where(x => x.Id == id).FirstOrDefault();
            return user.Id;
        }

        public static List<User> DisplayUser()
        {
            return users;
        }

        public static bool UserCount()
        {
            if (users.Count == 0)
            {
                return true;
            }
            else
                return false;
        }

        public static bool ContainsUser(int id)
        {
            if (users.Exists(x => x.Id == id))
            {
                return true;
            }
            else
                return false;
        }
        public static bool ContainsUser(string name)
        {
            if (users.Exists(x => x.Name == name))
            {
                return true;
            }
            else
                return false;
        }

        //ProductType
        public static bool ContainsProductType(string name)
        {
            if (productType.Exists(x => x.Name == name))
            {
                return true;
            }
            else
                return false;
        }

        public static int ContainsProductName(string name)
        {
            var pt  = productType.Where(x => x.Name == name).FirstOrDefault();
            return pt.Id;
        }

        public static int AddProductType(int id, string name)
        {
            productType.Add(new ProductType { Id = id, Name = name });
            return id;
        }

        public static int RemoveProductType(string name)
        {
            var productTypes = productType.Where(x => x.Name == name).FirstOrDefault();
            productType.RemoveAt(productTypes.Id-1);
            return productTypes.Id-1;
        }

        public static List<ProductType> DisplayProductType()
        {
            return productType;
        }

        //Product
        public static bool ContainsProductTypeId(int id)
        {
            if (products.Exists(x => x.ProductTypeId == id))
            {
                return true;
            }
            else
                return false;
        }

        public static bool ContainsProduct(int id)
        {
            if (products.Exists(x => x.Id == id))
            {
                return true;
            }
            else
                return false;
        }

        public static object AddProduct(Product product)
        {
            products.Add(product);
            return product;
        }

        public static int RemoveProduct(int id)
        {
            products.RemoveAt(id);
            return id;
        }

        public static bool ProductCount()
        {
            if (products.Count == 0)
            {
                return true;
            }
            else
                return false;
        }

        public static List<Product> DisplayProducts()
        {
            return products;
        }

        //Cart
        public static bool ContainsProductInCart(int id)
        {
            if (userCart.Exists(x => x.cart.Exists(y => y.Id == id)))
            {
                return true;
            }
            else
                return false;
        }

        public static int AddToCart(int id, int uid)
        {
            var product = products.Where(x => x.Id == id).FirstOrDefault();
            userCart.Where(x => x.CartID == uid).FirstOrDefault().cart.Add(product);
            return id;
        }

        public static int RemoveFromCart(int id , int uid)
        {
            userCart.Where(x =>x.CartID == id).FirstOrDefault().cart.RemoveAt(id-1);
            return id;
        }

        public static bool CartCount(int uid)
        {
            if (userCart.Where(x =>x.CartID == uid).FirstOrDefault().cart.Count() == 0)
            {
                return true;
            }
            else
                return false;
        }
        public static List<Cart> DisplayCartProducts()
        {
            return userCart;
        }

        public static int DeleteProductQuantity(int id)
        {
            products.Where(x => x.Id == id).FirstOrDefault().Quantity -= 1;
            return id;
        }
    }
}
