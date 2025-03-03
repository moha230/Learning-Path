using System;

namespace Car
{
  // Derived class for Engine
  public class Engine : Part
  {
    public string EngineType { get; }

    // Constructor for Engine class
    public Engine(string engineType, string identifier, string manufacturer, string description)
        : base(identifier, manufacturer, description)
        
    {
      this.EngineType = engineType;
    }
  }
}
