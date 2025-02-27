using System;
using System.Collections.Generic;

// Define a class named Student
class Student
{
    // Properties to store student details
    public string name { get; set; } // Name of the student
    public string studentNumber { get; set; } // Student's unique ID number

    public int credits { get; private set; } // The number of study credits (private setter to prevent direct modification)

    // Constructor to initialize a new Student object with name and student number
    public Student(string name, string studentNumber)
    {
        this.name = name; // Assign the provided name to the class property
        this.studentNumber = studentNumber; // Assign the provided student number
        this.credits = 0; // Initialize credits to 0 when a student is created
    }

    // Method to simulate studying, which increases the student's study credits
    public void Study()
    {
        this.credits += 1; // Increase credits by 1 each time the student studies
        Console.WriteLine(this.name + " did some studying. Study credits now: " + this.credits);
    }

    // Override the ToString() method to return a formatted string representation of a Student object
    public override string ToString()
    {
        return "Student: " + this.name + 
               " | Student Number: " + this.studentNumber + 
               " | Study Credits: " + this.credits;
    }
}
