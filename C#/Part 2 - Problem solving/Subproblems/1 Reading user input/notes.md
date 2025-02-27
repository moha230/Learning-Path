# subproblems 

## Reading user input

.NET Framework
├── Common Language Runtime (CLR)
│   ├── Garbage Collection
│   ├── Just-In-Time (JIT) Compilation
│   ├── Exception Handling
│   └── Security
├── .NET Framework Class Library (FCL)
│   ├── System
│   │   ├── Collections
│   │   ├── IO
│   │   ├── Text
│   │   └── Threading
│   ├── System.Data
│   ├── System.Drawing
│   ├── System.Net
│   ├── System.Web
│   └── System.Windows.Forms
├── ASP.NET
│   ├── Web Forms
│   ├── MVC
│   └── Web API
├── ADO.NET
│   ├── DataSet
│   ├── DataTable
│   └── DataAdapter
└── Windows Presentation Foundation (WPF)
    ├── XAML
    ├── Controls
    └── Data Binding

system namspace is part of the .net class libraray . iit contains exxential class and base classes that define commonly used data types events event handlers 

namespace is way to orginize a group related classes interfaces, structs, enums, and delegates
It helps to avoid naming conflicts by providing a way to distinguish between classes that might have the same name but reside in different namespaces

using System;

public class Program 
{
  public static void Main(string[] args)
  {
    Console.ReadLine();
  }
}

i know why we using system 

In C#, you declare a class as public to make it accessible from other parts of your application or from other assemblies. Here’s why you might be writing public class:
Accessibility: Declaring a class as public means it can be accessed from any other code in your project or from other projects that reference it. This is important for classes that need to be used widely.
Entry Point: The Main method, which serves as the entry point of a C# application, must be within a public class if you want it to be accessible when the application starts. The Main method itself can be public or private, but the class containing it is typically public.
Best Practices: Using public for the main class of your application is a common practice to ensure that the class is accessible and can be instantiated or referenced as needed.
Here’s your example with a bit more context: