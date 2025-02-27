using System;
using System.Collections.Generic;

class Program
{
  static void Main(string[] args)
  {
    //create a dictionary
    Dictionary<string, double> cafeItems = new Dictionary<string, double>();
    //adding the items in the dictionary 
    cafeItems.Add("Coffee", 2.50);
    cafeItems.Add("Tea", 2.20);
    cafeItems.Add("Cake", 4.40);
    cafeItems.Add("Croissant", 6.5);


    //lets print the items from the key 
    //Console.WriteLine(cafeItems["Coffee"]);

    //exceptions 
    if (!cafeItems.ContainsKey("Coffee"))
    {
      cafeItems.Add("Coffee", 6.40);
    }

    foreach (var item in cafeItems)
    {
      Console.WriteLine(item.Key + ": " + item.Value);
    }

    //another way to see whats going on in the key values pairs

    foreach (KeyValuePair<string, double> cafe in cafeItems)
    {
      Console.WriteLine("Key = {0},Value = {1}",cafe.Key,cafe.Value);
    }

  }
}