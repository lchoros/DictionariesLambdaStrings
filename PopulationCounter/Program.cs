using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopulationCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            Dictionary<string, Dictionary<string, int>> population = new Dictionary<string, Dictionary<string, int>>();
            while (command != "report")
            {
                string[] tokens = command.Split('|');
                string city = tokens[0];
                string country = tokens[1];
                int populationCount = int.Parse(tokens[2]);

                if(!population.ContainsKey(country))
                {
                    population.Add(country, new Dictionary<string, int>());
                }
                if(!population[country].ContainsKey(city))
                {
                    population[country].Add(city, 0);
                }
                population[country][city] += populationCount;

                command = Console.ReadLine();
            }

            population = population.OrderByDescending(m => m.Value.Values.Sum()).ToDictionary(m => m.Key, m => m.Value);

            foreach (var country in population)
            {
                Console.WriteLine("{0} (total population: {1})", country.Key, country.Value.Values.Sum());
                foreach (var city in country.Value)
                {
                    Console.WriteLine("=>{0}: {1}", city.Key, city.Value);
                }
            }
        }
    }
}
