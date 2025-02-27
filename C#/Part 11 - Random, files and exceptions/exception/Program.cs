using System;

class Program 
{
  static void Main(string[] args)
  {
    int x = 10;
    int y = 0;
    int results = x/y; //Division by zero causes an exception 
    Console.WriteLine(results);
  }
}
