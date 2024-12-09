using Project2_retry.Manager;
using System;

namespace Project2_retry.Controllers
{
    public class UserController
    {
        public static void UserOperation()
        {
            Console.WriteLine("Enter   1 to Add User \n\t2 to Delete User \n\t3 to View User \n\t4 to select user \n\t5 to Go back");
            int select = Convert.ToInt32(Console.ReadLine());

            switch (select)
            {
                case 1:
                    UserManager.AddUser();
                    UserOperation();
                    break;
                case 2:
                    UserManager.DeleteUser();
                    UserOperation();
                    break;
                case 3:
                    UserManager.DisplayUser();
                    UserOperation();
                    break;
                case 4:
                    UserManager.SelectUser();
                    UserOperation();
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
