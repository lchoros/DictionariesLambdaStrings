using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitStringIn20Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int length = text.Length;
            if(text.Length < 20)
            {
                text = text.PadRight(20, '*');
            }
            else
            {
                text = text.Substring(0, 20);
            }
            Console.WriteLine(text);
        }
    }
}
