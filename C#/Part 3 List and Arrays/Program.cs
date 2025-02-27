using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        List<string> inputs = new List<string>();
        CollectInputs(inputs);
        PrintNameAge(inputs);
        SumAge(inputs);
    }

    public static void CollectInputs(List<string> inputs)
    {
        while (true)
        {
            Console.WriteLine("Enter name and age (Name,Age), or press Enter to finish:");
            string input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
            {
                break;
            }
            inputs.Add(input);
        }
    }

    public static void PrintNameAge(List<string> inputs)
    {
        foreach (string input in inputs)
        {
            string[] pieces = input.Split(",");
            Console.WriteLine("Name: " + pieces[0] + ", age: " + pieces[1]);
        }
    }

    public static void SumAge(List<string> inputs)
    {
        int sum = 0;
        int count = 0;

        foreach (string input in inputs)
        {
            string[] parts = input.Split(",");
            sum += Convert.ToInt32(parts[1]);
            count++;
        }

        if (count > 0) {
            Console.WriteLine("Age average: " + ((double)sum / count));
        }
        else {
            Console.WriteLine("No input");
        }
        Console.WriteLine("Sum of the ages is " + sum);
    }

  
}
