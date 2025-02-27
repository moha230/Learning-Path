using System;
using System.Collections.Generic; // Using the full namespace

namespace NoAliasExample
{
    class Program
    {
        static void Main()
        {
            // Using the full namespace
            List<string> names = new List<string>();
            names.Add("Alice");
            names.Add("Bob");

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
