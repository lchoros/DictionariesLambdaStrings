using System;

namespace OccurerencesInString
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string word = Console.ReadLine();
            int occurences = 0;
            int offset = 0;
            int occurenceIndex = text.IndexOf(word, offset);
            while (occurenceIndex > -1)
            {
                offset = occurenceIndex + 1;
                occurenceIndex = text.IndexOf(word, offset);
                occurences++;
            }
            Console.WriteLine(occurences);
        }
    }
}
