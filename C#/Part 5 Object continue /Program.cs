using System;
using System.Collections.Generic;

namespace Program
{

  public class Program
  {

    public static void Main(string[] args)
    {
      ClockHand hours = new ClockHand(24);
      ClockHand minutes = new ClockHand(60);
      ClockHand seconds = new ClockHand(60);

      while (true)
      {
        // printing the time
        Console.WriteLine(hours + ":" + minutes + ":" + seconds);

        seconds.Advance();

        if (seconds.value == 0)
        {
          minutes.Advance();

          if (minutes.value == 0)
          {
            hours.Advance();
          }
        }

      }

    }

  }

}
