using System;

class WeatherMan
{  // Constructor to initialize the Random object    
// 
private Random random;

  public WeatherMan()
  {
    this.random = new Random();
  }

  public string Forecast()
  {
    double probability = this.random.NextDouble();

    if (probability <= 0.1)
    {
      return "It rains";
    }
    else if (probability <= 0.4)
    {
      return "It snows";
    }
    else
    {
      return "The sun shines";
    }
  }
}

