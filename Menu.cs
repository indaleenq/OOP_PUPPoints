using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUPPoints
{
    internal static class Menu
    {

        static List<string> StudentMenu = new List<string>();
        static List<string> FacultyMenu = new List<string>();

        private static void CreateMenus()
        {
            StudentMenu.Add("View Points");
            StudentMenu.Add("Use Points");
            StudentMenu.Add("Logout");

            FacultyMenu.Add("Give Points");
            FacultyMenu.Add("Logout");
        }

        public static void Show(string user)
        {
            CreateMenus();

            string usertype = "";

            Console.WriteLine("\nSelect actions below:");

            if (user.Contains("FN"))
            {
                usertype = "Faculty";
                for (int i = 0; i < FacultyMenu.Count; i++)
                {
                    Console.WriteLine($"Enter {i + 1} to {FacultyMenu[i]}");
                }
            }
            else if (user.Contains("BN"))
            {
                usertype = "Student";
                for (int i = 0; i < StudentMenu.Count; i++)
                {
                    Console.WriteLine($"Enter {i + 1} to {StudentMenu[i]}");
                }
            }

            Console.Write("input menu to select: ");

            int selectedMenu = Convert.ToInt32(Console.ReadLine());

            ProcessSelectedMenu(selectedMenu, usertype);
        }

        private static void ProcessSelectedMenu(int menu, string usertype)
        {
            if (usertype == "Student")
            {
                switch (menu)
                {
                    case 1:
                        StudentFunction.ViewPoints();
                        break;
                    case 2:
                        StudentFunction.UsePoints();
                        break;
                    default:
                        Console.WriteLine("Menu not existing...");
                        break;
                }
            }
            else if (usertype == "Faculty")
            {

            }
            else
            {
                Console.WriteLine("Invalid user type.");
            }
        }
    }
}
