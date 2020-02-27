using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountLettersInString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLowerInvariant();


            Dictionary<char, int> dictionary = new Dictionary<char, int>();

            foreach (char item in input)
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
            foreach (var item in dictionary)
            {
                Console.WriteLine("{0} -> {1}", item.Key, item.Value);
            }
            //int[] counts = new int[input.Max() + 1];

            //foreach (char letter in input)
            //{
            //    if (letter >= 65 && letter <= 90)
            //    {
            //        counts[letter]++;
            //    }
            //    else
            //    {
            //        counts[letter]++;
            //    }
            //}

            //for (int i = 0; i < counts.Length; i++)
            //{
            //    if(counts[i] > 0)
            //    {
            //        Console.WriteLine("{0} -> {1}", (char)i,  counts[i]);
            //    }
            //}
        }
    }
}
