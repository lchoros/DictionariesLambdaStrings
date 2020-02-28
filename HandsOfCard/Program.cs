using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOfCard
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            Dictionary<string, int> results = new Dictionary<string, int>();
            Dictionary<char, int> colorMapping = new Dictionary<char, int>();
            Dictionary<string, int> cardMapping = new Dictionary<string, int>();
            colorMapping['S'] = 4;
            colorMapping['H'] = 3;
            colorMapping['D'] = 2;
            colorMapping['C'] = 1;

            cardMapping["A"] = 14;
            cardMapping["K"] = 13;
            cardMapping["Q"] = 12;
            cardMapping["J"] = 11;
            cardMapping["10"] = 10;
            cardMapping["9"] = 9;
            cardMapping["8"] = 8;
            cardMapping["7"] = 7;
            cardMapping["6"] = 6;
            cardMapping["5"] = 5;
            cardMapping["4"] = 4;
            cardMapping["3"] = 3;
            cardMapping["2"] = 2;

            while (command != "JOKER")
            {
                string[] tokens = command.Split(':').ToArray();
                string name = tokens[0].Trim();
                List<string> cards = tokens[1].Split(new[] { ',', ' '}, StringSplitOptions.RemoveEmptyEntries).ToList();
                if (!results.ContainsKey(name))
                {
                    results.Add(name, 0);
                }
                foreach (var card in cards)
                {
                    //var x = cardMapping[card[0].ToString()];
                    results[name] += (cardMapping[card[0].ToString()] * colorMapping[card[1]]);
                }
                command = Console.ReadLine();
            }
            foreach (var result in results.Keys)
            {
                Console.WriteLine("{0}: {1}", result, results[result]);
            }
        }
    }
}
