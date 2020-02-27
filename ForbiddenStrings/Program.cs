using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForbiddenStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = Console.ReadLine();
            string[] forbiddenWords = Console.ReadLine().Split(' ');

            for (int i = 0; i < forbiddenWords.Length; i++)
            {
                sentence = sentence.Replace(forbiddenWords[i], new string('*', forbiddenWords[i].Length));
            }
            Console.WriteLine(sentence);
        }
    }
}
