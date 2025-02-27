using System;
using System.Collections.Generic;


namespace Exercise001
{
  class Program
  {
    static void Main(string[] args)
    {
      Dictionary<string, string> postalCodes = new Dictionary<string, string>();
      postalCodes.Add("00710", "Helsinki");
      postalCodes.Add("90014", "Oulu");
      postalCodes.Add("33720", "Tampere");
      postalCodes.Add("67100", "Kokkola");
      postalCodes.Add("33014", "Tampere");
      
      if (!postalCodes.ContainsKey("67100")) 
      {
        postalCodes.Add("67100", "Karleby");
      }
      Console.WriteLine(postalCodes["67100"]);
  }
  }
}