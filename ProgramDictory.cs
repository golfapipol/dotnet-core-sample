using System;
using System.Collections.Generic;

namespace dotnet_sample
{
    class ProgramDictory
    {
        private enum Unit { item, pound, ounce, dozen };

        static void Main(string[] args)
        {
            var inventory = new Dictionary<string, int>();
            inventory.Add("hammer, ball pein", 18);
            inventory.Add("hammer, cross pein", 5);
            inventory.Add("screwdriver, Phillips #2", 14);

            Console.WriteLine($"Inventory on {DateTime.Now:d}");
            Console.WriteLine(" ");
            Console.WriteLine($"{"Item",-25}    {"Quantity",10}");
            Console.WriteLine(" "); 
            foreach (var item in inventory)
                Console.WriteLine($"{item.Key,-25}     {item.Value,10}");
        }
    }
}
