using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintReceipt2
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal[] numbers = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();
            Console.WriteLine("/{0}\\", new string('-', 22));

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("| {0,20:f2} |", numbers[i]);
            }
            Console.WriteLine("|{0}|", new string('-', 22));
            Console.WriteLine("| Total:{0,14:f2} |", numbers.Sum());
            Console.WriteLine("\\{0}/", new string('-', 22));
        }
    }
}
