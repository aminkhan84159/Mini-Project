using Project2_retry.Controllers;
using Project2_retry.DataServices;
using Project2_retry.Models;
using System;
using System.Collections.Generic;

namespace Project2_retry.Manager
{
    public class UserManager
    {
        public static int uid { get; set; } = 3;
        public static string uname;

        public static int AddUser()
        {
            Console.Write("Enter Username : ");
            uname = Console.ReadLine();

            if (DbService.ContainsUser(uname))
            {
                Console.WriteLine($"User with name {uname}  already exist \nTry another");
            }
            else
            {
                Cart c = new Cart();
                c.CartID = uid;
                DbService.AddUser(uid, uname,c);
                uid++;
                Console.WriteLine("User Added Successfully");
            }

            return uid;
        }

        public static int SelectUser()
        {
            Console.Write("Enter User ID : ");
            uid = Convert.ToInt32(Console.ReadLine());
            var userId = DbService.SelectUser(uid);

            if (DbService.ContainsUser(uid))
            {
                CartController.CartOperation(userId);
            }
            else
            {
                Console.WriteLine($"User with Id {uid} does not exist");
            }

            return userId;
        }

        public static int DeleteUser()
        {
            Console.Write("Enter User ID : ");
            int Uid = Convert.ToInt32(Console.ReadLine());

            if (DbService.ContainsUser(uid))
            {
                DbService.RemoveUser(Uid);
                uid--;
                Console.WriteLine("User Deleted Successfully");
            }
            else
            {
                Console.WriteLine($"User with Id {uid} doesn't exist");
            }

            return Uid;
        }

        public static List<User> DisplayUser()
        {
            if (DbService.UserCount())
            {
                Console.WriteLine("There are no Users");
            }
            else
            {
                Console.WriteLine("ID  UserName");
                var user  = DbService.DisplayUser();

                foreach (var users in user)
                {
                    Console.WriteLine($"{users.Id}  {users.Name}");
                }
            }

            return DbService.DisplayUser();
        }
    }
}
