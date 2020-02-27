using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortWordsSorted
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join(", ", Console.ReadLine().Split(new char[] { '.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?', ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.ToLower()).Where(x => x.Length < 5).OrderBy(x => x).Distinct()));
            //char[] separators = new char[] { '.', ',', ':', ';', '(',')','[', ']', '"', '\'', '\\', '/', '!', '?', ' '};
            //string[] text = Console.ReadLine().ToLowerInvariant().Split(separators);
            //List<string> result = new List<string>();

            //foreach (var word in text)
            //{
            //    if(!result.Contains(word) && word.Length < 5)
            //    {
            //        result.Add(word);
            //    }
            //}
            //Console.WriteLine(string.Join(", ", result.));
        }
    }
}
