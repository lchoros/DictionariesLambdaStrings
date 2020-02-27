using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = numbers.Length / 4;
            List<int> firstRowLeftPart = numbers.Take(k).Reverse().ToList();
            List<int> firstRowRightPart = numbers.Reverse().Take(k).ToList();
            List<int> firstRow = firstRowLeftPart.Concat(firstRowRightPart).ToList();
            List<int> secondRow = numbers.Skip(k).Take(k*2).ToList();
            List<int> result = firstRow.Select((x, index) => x + secondRow[index]).ToList();
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
