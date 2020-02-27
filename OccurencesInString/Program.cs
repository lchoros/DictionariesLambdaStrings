using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OccurencesInString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLowerInvariant();
            string word = Console.ReadLine().ToLowerInvariant();
            int offset = 0;
            int counter = 0;
            int occurenceIndex = input.IndexOf(word, offset);
            while (occurenceIndex > - 1)
            {
                counter++;
                offset = occurenceIndex + 1;
                occurenceIndex = input.IndexOf(word, offset);
            }
            Console.WriteLine(counter);
        }
    }
}
