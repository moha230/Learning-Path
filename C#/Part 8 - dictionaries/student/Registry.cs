using System;
using System.Collections.Generic;
 
class Registry
{
    private Dictionary<string, Student> directory;
 
    public Registry()
    {
        this.directory = new Dictionary<string, Student>();
    }
 
    public void AddStudent(Student student)
    {
        string name = student.name;
 
        if (name == null)
        {
            name = "";
        }
 
        name = name.ToLower();
        name = name.Trim();
 
        if (this.directory.ContainsKey(name))
        {
            Console.WriteLine("The student is already in the registry.");
        }
        else
        {
            directory.Add(name, student);
        }
 
    }
 
    public Student GetStudent(string name)
    {
        name = SanitizedString(name); 
        if (this.directory.ContainsKey(name))
        {
            return this.directory[name]; 
        }
        else
        {
            return null; 
        }
    }
 
    public static string SanitizedString(string input)
    {
        if (input == null)
        {
            return ""; 
        }
 
        input = input.ToLower(); 
        return input.Trim(); 
    }
 
}
