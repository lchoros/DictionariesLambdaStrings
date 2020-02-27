using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOccurences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ');
            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            foreach (var item in words)
            {
                if(dictionary.ContainsKey(item))
                {
                    dictionary[item]++;
                }
                else
                {
                    dictionary[item] = 1;
                }
            }

            List<string> result = new List<string>();
            foreach (var key in dictionary.Keys)
            {
                if(dictionary[key] % 2 == 1)
                {
                    result.Add(key);
                }
            }
            Console.Write(string.Join(" ", result));
        }
    }
}
