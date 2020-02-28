using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            SortedDictionary<string, string> phonebook = new SortedDictionary<string, string>();
            while (command != "END")
            {
                string[] tokens = command.Split(' ');
                switch (tokens[0])
                {
                    case "A":
                        string name = tokens[1];
                        string phone = tokens[2];
                        phonebook[name] = phone;
                        break;
                    case "S":
                        string name2 = tokens[1];
                        if (phonebook.ContainsKey(name2))
                        {
                            Console.WriteLine("{0} -> {1}", name2, phonebook[name2]);
                        }
                        else
                        {
                            Console.WriteLine("Contact {0} does not exist.", name2);
                        }
                        break;
                    case "ListAll":
                        foreach (var item in phonebook.Keys)
                        {
                            Console.WriteLine("{0} -> {1}", item, phonebook[item]);
                        }
                        break;
                    default:
                        break;
                }
                command = Console.ReadLine();
            }
        }
    }
}
