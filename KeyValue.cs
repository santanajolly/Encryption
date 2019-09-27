using System.Collections.Generic;

namespace Encryption
{
    public class KeyValue
    {

        public Dictionary<string, string> dictionary = new Dictionary<string, string>();

        public string Username { get; set; }
        public string Password { get; set; }
        public void CreateDict(string username, string password)
        {
            dictionary.Add(this.Username, this.Password);
        }




    }

}

