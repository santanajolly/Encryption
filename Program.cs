using System;

namespace Encryption
{
    class Program
    {
        static void Main(string[] args)
        {
            bool name = true;
            Menu menu = new Menu();
            UserOptions user = new UserOptions();
            menu.MainMenu();
            string userinput = Console.ReadLine();
            try
            {
                switch (userinput)
                {
                    case "1":
                        user.CreateAccount();
                        menu.MainMenu();

                        //method to create account
                        break;
                    case "2":
                        user.Authenticate();
                        //method to login
                        break;
                    case "3":
                        Console.Write("Are you sure you want to exit?  \n Type y for yes or n for no");
                        string confirm = Console.ReadLine();
                        if (confirm.ToLower() == "y")
                        {
                            user.DisplayPass();
                        }
                        else if (confirm.ToLower() == "n")
                        {
                            menu.MainMenu();
                        }
                        else
                        {
                            Console.WriteLine("Invalid Response");
                            menu.MainMenu();
                        }

                        //method to display stored passwords
                        break;
                    default:
                        Console.WriteLine("Invalid Response");
                        menu.MainMenu();
                        break;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Response");
                menu.MainMenu();
            }
        }
    }
}
