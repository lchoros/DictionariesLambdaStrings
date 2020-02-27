using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CensorEmail
{
    class Program
    {
        static void Main(string[] args)
        {
            string email = Console.ReadLine();
            string text = Console.ReadLine();
            int index = email.IndexOf('@');
            string username = email.Substring(0, index);
            Console.WriteLine(text.Replace(username, new string('*', username.Length)));
        }
    }
}
