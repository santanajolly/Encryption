using System;
using System.Threading;

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

            key.CreateDict(username, password);

            Console.WriteLine("You have created your account!\n\n");
            Thread.Sleep(3000);


            //eventually add username and password requirements
        }

        public void Authenticate()
        {
            Console.Write("Enter Username: ");
            string loginusername = Console.ReadLine();

            Console.Write("Enter Password: ");
            string loginpassword = Console.ReadLine();

            if (key.dictionary.ContainsKey(loginusername))
            {
                //username already exists
                menu.MainMenu();
            }
            else if (!key.dictionary.ContainsKey(loginusername))
            {
                //create account?
                //todo


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
