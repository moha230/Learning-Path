using System;
using MyList = System.Collections.Generic.List<string>; // Creating an alias

namespace AliasExample
{
    class Program
    {
        static void Main()
        {
            // Using the alias instead of the full namespace
            MyList names = new MyList();
            names.Add("Charlie");
            names.Add("Diana");

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
