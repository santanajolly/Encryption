using System;


namespace Encryption
{
    class Menu
    {
        public void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("                       ACCOUNT AUTHENTICATION         \n\n");
            Console.WriteLine("                 Please Select 1 - 3 to Continue     \n                                                ");

            Console.WriteLine("           **********************************************        ");
            Console.WriteLine("          [1. Create Account                             ]                     ");
            Console.WriteLine("          !                                              !                       ");
            Console.WriteLine("          [2. Authenticate Account                       ]                     ");
            Console.WriteLine("          !                                              !                       ");
            Console.WriteLine("          [3. Exit                                       ]                     ");
            Console.WriteLine("           ***********************************************       ");
        }

        UserOptions useroptions = new UserOptions();
        public void UserOption()
        {
            MainMenu();
            string userinput = (Console.ReadLine());

            try
            {
                switch (userinput)
                {
                    case "1":
                        useroptions.CreateAccount();
                        //method to create account
                        break;
                    case "2":
                        useroptions.Login();
                        //method to login
                        break;
                    case "3":
                        Console.Write("Are you sure you want to exit?  \n Type y for yes or n for no");
                        string confirm = Console.ReadLine();
                        string lowerconfirm = confirm.ToLower();
                        if (lowerconfirm == "y")
                        {
                            useroptions.DisplayPass();
                        }
                        else if (lowerconfirm == "n")
                        {
                            MainMenu();
                        }
                        else
                        {
                            Console.WriteLine("Invalid Response");
                            MainMenu();
                        }

                        //method to display stored passwords
                        break;
                    default:
                        Console.WriteLine("Invalid Response");
                        MainMenu();
                        break;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Response");
                MainMenu();
            }
        }

    }
}
