using System;
using System.Collections.Generic;


class Program
{
  static void Main(string[] args)
  {

    //creating student object"
    Student alice = new Student("Alice", "S134");
    Student bob = new Student("Bob", "S456");

    Registry registry = new Registry();

    registry.AddStudent(alice);
    registry.AddStudent(bob);

    Console.WriteLine(registry.GetStudent("alice"));
    Console.WriteLine();
    Console.WriteLine(registry.GetStudent("alIce"));
      Console.WriteLine();
    Console.WriteLine(registry.GetStudent("alice"));
      Console.WriteLine();
    Console.WriteLine(registry.GetStudent("alice    "));



    //create a dictionary that has reference type variable 
    //this stores 

    //creating a dictionary in the registry we dont need it her 

    // Dictionary<string, Student> dictionary = new Dictionary<string, Student>();

    //   //creating student object
    //   Student alice = new Student("Alice", "S134");
    //   Student bob = new Student("Bob", "S456");


    //  //adding the students in the dictionary 
    //  dictionary.Add(alice.name, alice);
    //  dictionary.Add(bob.name,bob);

    //  Console.WriteLine(dictionary["Alice"]);

    // if (dictionary.ContainsKey("John"))
    // {
    //   Console.WriteLine(dictionary["John"]);
    // }
    // else
    // {
    //   Console.WriteLine("Student not found");
    // }



    //allows modifying the object in place without re-adding it to the dictionary 















    // // Create a new student object
    // Student student = new Student("Homer Simpson", "123456");

    // // Print student details before studying
    // Console.WriteLine(student);

    // // Simulate studying multiple times
    // student.Study();
    // student.Study();
    // student.Study();
    // student.Study();

    // // Print updated student details
    // Console.WriteLine(student);
  }
}