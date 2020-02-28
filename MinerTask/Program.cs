using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            while (command != "stop")
            {
                string quantity = Console.ReadLine();
                if(quantity == "stop")
                {
                    break;
                }
                Console.WriteLine("{0} -> {1}", command, quantity);
                command = Console.ReadLine();
            }
        }
    }
}
