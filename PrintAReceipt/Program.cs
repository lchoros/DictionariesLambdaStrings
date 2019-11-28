using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintAReceipt
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal[] numbers = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();

            Console.WriteLine("/{0}\\", new string('-', 22));
            decimal total = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("| {0,20:f2} |", numbers[i]);
                total += numbers[i];
            }

            Console.WriteLine("|{0}|", new string('-', 22));
            Console.WriteLine("| Total: {0,13:f2} |", 1000);
            Console.WriteLine("\\{0}/", new string('-', 22));

        }
    }
}
