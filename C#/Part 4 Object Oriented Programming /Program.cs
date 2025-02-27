using System;

namespace Humans
{
  class Program
  {
    static void Main(string[] args)
    {

      List<Person> persons = new List<Person>();

      // Read the names of persons from the user
      while (true)
      {
        Console.WriteLine("Enter the person details separated by a comma, e.g.: Randall, 2");
        string details = Console.ReadLine();
        if (details == "")
        {
          break;
        }

        string[] parts = details.Split(",");
        string name = parts[0];
        int age = Convert.ToInt32(parts[1]);
        persons.Add(new Person(name, age));
      }

      // Print the number of the entered persons, and their individual information
      Console.WriteLine();
      Console.WriteLine("Persons in total: " + persons.Count);
      Console.WriteLine("Persons: ");

      foreach (Person person in persons)
      {
        Console.WriteLine(person);
      }

    }
  }
}
