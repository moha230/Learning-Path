
using System;

class program
{
  public static void Main(string[] args)
  {
    // //creating a random object o generate random numbers 
    // Random random = new Random();

    // // Generate a random number between 0 and 9 

    // int randomNumber = random.Next(10);

    // Console.WriteLine("Random Number: " + randomNumber);

    // //generate a random number in a range 

    // int temperature = random.Next(-30,51); //between -30 and 50
    // Console.WriteLine("Random temperature : " + temperature);

    // //generate a random decimal (double)

    // double randomDouble = random.NextDouble();
    // Console.WriteLine("Random Decimal: " + (randomDouble * 100));


    //simulating a dice roll 

    Random dice = new Random();
    int roll = dice.Next(0, 7); //simulates rolling a 6-sided dice 
    Console.WriteLine("You rolled: " + roll);
    // Create a WeatherMan object
    WeatherMan forecaster = new WeatherMan();

    string forecast = forecaster.Forecast();
    Console.WriteLine("Weather forecast: " + forecast);

  }
}