using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capital_City_Finder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> countries = new List<string>
            {
                "Philippines", "Japan", "France", "Brazil", "Australia",
            "Canada", "Germany", "India", "Italy", "Mexico"
            };
            List<string> capitals = new List<string>
            {
                 "Manila", "Tokyo", "Paris", "Brasilia", "Canberra",
            "Ottawa", "Berlin", "New Delhi", "Rome", "Mexico City"
            };

            Console.WriteLine("Country Capital Lookup");
            Console.WriteLine("Available countries:");
            foreach (string country in countries)
            {
                Console.WriteLine($"- {country}");
            }

            Console.Write("\nEnter a country name: ");
            string input = Console.ReadLine();
            bool found = false;

            for (int i = 0; i < countries.Count; i++)
            {
                if (countries[i].Equals(input, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Capital: {capitals[i]}");
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine("Country not found.");
            }
        }
    }
}
