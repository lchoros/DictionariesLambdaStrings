using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            var x = str;
            //Console.WriteLine(string.Join("", str.Reverse()));
            var res = new string(str.ToCharArray().Reverse().ToArray());
            Console.WriteLine(res);
        }
    }
}
