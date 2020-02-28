using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogsAggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            SortedDictionary<string, SortedDictionary<string, int>> report = new SortedDictionary<string, SortedDictionary<string, int>>();

            for (int i = 0; i < numberOfLines; i++)
            {
                string[] tokens = Console.ReadLine().Split(' ');
                string ip = tokens[0];
                string name = tokens[1];
                int duration = int.Parse(tokens[2]);

                if(!report.ContainsKey(name))
                {
                    report.Add(name, new SortedDictionary<string, int>());
                }
                if(!report[name].ContainsKey(ip))
                {
                    report[name].Add(ip, 0);
                }

                report[name][ip] += duration;
            }

            foreach (var line in report)
            {
                Console.WriteLine("{0}: {1} [{2}]", line.Key, line.Value.Values.Sum(), string.Join(", ", line.Value.Select(x => x.Key)));
            }
        }
    }
}
