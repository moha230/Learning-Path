using System;

namespace Program
{

  public class Program
  {
    public static void Main(string[] args)
    {

      Clock clock = new Clock();

      while (true)
      {
        Console.WriteLine(clock);
        clock.Advance();
        System.Threading.Thread.Sleep(100);
      }

    }
  }

}
