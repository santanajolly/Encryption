using System;

namespace Encryption
{
    public class UserOptions
    {
        KeyValue key = new KeyValue();
        Menu menu = new Menu();
        public void CreateAccount()
        {
            Console.Write("Enter your desired Username: ");
            string username = Console.ReadLine();
            Console.Write("Enter your desired Password: ");
            string password = Console.ReadLine();

            key.Username = username;
            key.Password = password;

            //eventually add username and password requirements
        }

        public void Login()
        {
            Console.Write("Enter Username: ");
            string loginusername = Console.ReadLine();

            Console.Write("Enter Password: ");
            string loginpassword = Console.ReadLine();

            if (key.dictionary.ContainsKey(loginusername))
            {
                //compare passord?
            }
            else if (!key.dictionary.ContainsKey(loginusername))
            {
                Console.WriteLine("Username not found!");
                menu.MainMenu();

            }
        }

        public void DisplayPass()
        {
            Console.WriteLine("All Stored Values:\n");
            foreach (var pair in key.dictionary)
            {
                Console.WriteLine(pair.Key, pair.Value);
            }
        }
    }
}
