namespace Animals // Declare a namespace named 'Animals'
{
  using System; // Import the System namespace for console output and other utilities

  class Program // Define a class named 'Program' to contain the entry point of the application
  {
    static void Main(string[] args) // Main method, the entry point of the application
    {
      // Print "bark" to the console
      Console.WriteLine("bark");

      // CREATE an instance of a class
      // This assumes there's a class 'Animal' defined somewhere in the project
      Animal cat = new Animal("viiru");

      // Output the instance of the class to the console
      // The output will depend on the 'ToString()' implementation of the 'Animal' class
      Console.WriteLine(cat);

      //print a method to the console
      Console.WriteLine(cat.TalkToOwner());

      //creates an instance of dog
      Animal dog = new Animal("lipa"); 
      Console.WriteLine(dog);
      Console.WriteLine(dog.TalkToOwner());

    }
  }
}
