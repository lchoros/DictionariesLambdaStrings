using System;
using System.Collections.Generic;
using System.Linq;

namespace LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lineArgs = Console.ReadLine().ToLower().Split().ToArray();

            var keyMaterialNames = new Dictionary<string, string>();
            keyMaterialNames.Add("shards", "Shadownourne");
            keyMaterialNames.Add("fragments", "Valanyr");
            keyMaterialNames.Add("motes", "Dragonwrath");

            var junkMaterials = new SortedDictionary<string, int>();
            var keyMaterials = new Dictionary<string, int>();
            keyMaterials.Add("shards", 0);
            keyMaterials.Add("fragments", 0);
            keyMaterials.Add("motes", 0);

            for (int i = 0; i < lineArgs.Length - 2; i += 2)
            {
                if(junkMaterials.Contains()
            }
        }
    }
}
