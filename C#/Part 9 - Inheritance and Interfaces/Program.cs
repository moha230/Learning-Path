// using System;



// //starting point of my application program
// class Program
// {
//   static void Main(string[] args)
//   {
//     // Creating an instance of Dog
//     Dog dog = new Dog("Buddy", 3);
//     dog.Speak(); // The dog barks.
//     Console.WriteLine($"Name: {dog.Name}, Age: {dog.Age}");
//   }
// }


// //create a basic base class 

// class Animal
// {
//   public string Name { get; set; }
//   public int Age { get; set; }

//   //constructor for Animal class 
//   public Animal(string name, int age)
//   {
//     this.Name = name;
//     this.Age = age;
//   }

//   //method for Animal class 
//   public void Speak()
//   {
//     Console.WriteLine("The animal makes a sound");

//   }
// }


// //derived class 

// class Dog : Animal
// {
//   //Constructor for Dog class 
//   public Dog(string name, int age) : base(name, age)
//   {
//   }

//   // Override method for Dog class
//   public void Speak()
//   {
//     Console.WriteLine("The dog barks.");
//   }
// }


//lets create a program that deals with parts and engines 

using System;

namespace Car
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating an instance of Engine
            Engine engine = new Engine("Combustion", "hz", "Volkswagen", "VW GOLF 1L 86-91");
            
            // Displaying the properties
            Console.WriteLine($"Engine Type: {engine.EngineType}");
            Console.WriteLine($"Identifier: {engine.Identifier}");
            Console.WriteLine($"Manufacturer: {engine.Manufacturer}");
            Console.WriteLine($"Description: {engine.Description}");
        }
    }
}
