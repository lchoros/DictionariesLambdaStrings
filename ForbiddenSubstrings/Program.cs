using System;
using System.Collections.Generic;

namespace ForbiddenSubstrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = Console.ReadLine();
            string[] words = sentence.Split(' ');
            string[] forbiddenWords = Console.ReadLine().Split(' '); 

            for (int i = 0; i < forbiddenWords.Length; i++)
            {
                sentence = sentence.Replace(forbiddenWords[i], new string('*', forbiddenWords[i].Length));           
            }
            Console.WriteLine(sentence);
        }
    }
}
