using System;

namespace Car
{
    // Base class for parts
    public class Part
    {
        public string Identifier { get; }
        public string Manufacturer { get; }
        public string Description { get; }

        // Constructor for Part class
        public Part(string identifier, string manufacturer, string description)
        {
            this.Identifier = identifier;
            this.Manufacturer = manufacturer;
            this.Description = description;
        }
    }
}
