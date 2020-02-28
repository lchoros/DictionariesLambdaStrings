using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogs
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            var userLogs = new SortedDictionary<string, Dictionary<string, int>> ();

            while (command != "end")
            {
                string[] tokens = command.Split();
                int index = tokens[0].IndexOf('=');
                string ip = tokens[0].Substring(index + 1).Trim();

                index = tokens[2].IndexOf('=');
                string name = tokens[2].Substring(index + 1).Trim();

                if (!userLogs.ContainsKey(name))
                {
                    userLogs.Add(name, new Dictionary<string, int>());
                }

                if(!userLogs[name].ContainsKey(ip))
                {
                    userLogs[name].Add(ip, 0);
                }
                userLogs[name][ip]++;
                command = Console.ReadLine();
            }

            foreach (var user in userLogs)
            {
                Console.WriteLine("{0}:", user.Key);
                Console.WriteLine(string.Join(", ", user.Value.Select(x => x.Key + " => " + x.Value).ToArray())+".");
            }
        }
    }
}
