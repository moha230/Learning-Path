using System;

public class Program 
{
  public static void Main(string[] args)
  {
    Console.WriteLine("Let's try if we can travel to the method world:");
    Greet();

        Console.WriteLine("Looks like we can, let's try again:");
Greet();
    Greet();
    Greet();
  }
  //write my own method
  public static void Greet()
  {
     Console.WriteLine("Greetings from the method world!");
  }
}
