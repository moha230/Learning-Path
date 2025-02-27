using System;

public class Program 
{
  public static void Main(string[] args)
  {
   // Declaring the variables and assigning user input to them
int first = Convert.ToInt32(Console.ReadLine());
int second = Convert.ToInt32(Console.ReadLine());

// Identifying the operation and declaring variable for the result
int sum = first + second;

// Doing something with the result. In this case
// the result is used in the conditional operations.

if (sum > 100) // if the sum is over 100
{
    Console.WriteLine("too much");
}
else if (sum < 0) // if the sum is less than 0
{
    Console.WriteLine("too little");
}
else // otherwise
{
    Console.WriteLine("ok");
}
  }
}