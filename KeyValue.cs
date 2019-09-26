using System.Collections.Generic;

namespace Encryption
{
    public class KeyValue
    {
        UserOptions useroption = new UserOptions();

        public Dictionary<string, string> dictionary = new Dictionary<string, string>();

        public string Username { get; set; }
        public string Password { get; set; }
        public void CreateDict()
        {
            dictionary.Add(Username, Password);
        }




    }

}

