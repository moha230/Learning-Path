using System;
// without try catch block code 
// using System;

// class Program 
// {
//   static void Main(string[] args)
//   {
//     int x = 10;
//     int y = 0;
//     int results = x/y; //Division by zero causes an exception 
//     Console.WriteLine(results);
//   }
// }


//number exception test 



// class Program 
// {
//   static void Main(string[] args)
//   {
//     try //  try block This block contains code that might throw an exception 
//     {
//       int x = 10;
//       int y = 0;
//       int result = x/y; // this line of code will throw an exception 
//       Console.WriteLine("This my results " +  result);
//     }
//     catch (Exception e) // This catch block handles any exception that occurrs in the try block the 'e' is the variable that holds the exception object  
//     {
//       Console.WriteLine("An error occurred", e.Message); // Print an error message to the console. e.Message provides a description of the exception.
//     }
//   }
// }

//string to number  exception test 

// class Program
// {
//   static void Main(string[] args)
//   {
//     try
//     {
//       // the code that might throw an exception 
//       Console.WriteLine("Give a number");
//       int number = Convert.ToInt32(Console.ReadLine());
//     }
//     catch (Exception e)
//     {
//       Console.WriteLine(e.Message);
//     }



//   }
// }

// Give a number
// helo
// The input string 'helo' was not in a correct format.


// Let's make our integer parser a bit more useful. We'll turn it into a method which prompts the user for a number until they give a valid number. The execution stops only when the user gives a valid number.


// class Program
// {
//   static void Main(string[] args)
//   {

//     ReadNumber();


//   }

//   //create a method that ask for a number 
//   public static int ReadNumber()
//   {
//     while (true)
//     {
//       Console.Write("Give a number : ");
//       try
//       {
//         int readNumber = Convert.ToInt32(Console.ReadLine());
//         return readNumber;
//       }
//       catch (Exception e)
//       {
//         Console.WriteLine(e.Message);
//       }
//     }

//   }

// }

//using try block for file exception 
// class Program
// {
//   static void Main(string[] args)
//   {
//     string text = File.ReadAllText("fileDoesNotExist.txt");
//     Console.WriteLine(text);
//   }
// }


// using the try catch block 
// class Program
// {
//   static void Main(string[] args)
//   {
//     try
//     {
//       string text = File.ReadAllText("fileDoesNotExist.txt");
//       Console.WriteLine(text);

//     }
//     catch (Exception e)
//     {
//       Console.WriteLine(e.Message);
//     }


//   }
// }


// First Approach: Handling the Exception internally in the method block 

// class Program
// {
//   static void Main(string[] args)
//   {
//     //calling the method 
//     ReadLines("text.txt").ForEach(Console.WriteLine);

//   }
//   // create a method that readline of a text file 
//   public static List<string> ReadLines(string fileName)
//   {
//     //creating an instance of a new list 
//     List<string> list = new List<string>();
//     //using the try catch block 
//     try
//     {
//       string[] lines = File.ReadAllLines(fileName);
//       list = new List<string>(lines);

//     }
//     catch (Exception e)
//     {
//       Console.WriteLine(e.Message);
//     }
//     return list;
//   }

// Second Approach: Shifting the Responsibility


class Program
{
  static void Main(string[] args)
  {
    try
    {
       //calling the method 
    ReadLines("text.txt").ForEach(Console.WriteLine);
    }
    catch (Exception e)
    {
      
     Console.WriteLine(e.Message); // Handle the exception here
    }
   

  }
  // create a method that readline of a text file 
  public static List<string> ReadLines(string fileName)
  {
    //creating an instance of a new list 
    List<string> list = new List<string>();
    //using the if statement 
    if (!File.Exists(fileName))
    {
      //throws the exception 
      throw new System.IO.FileNotFoundException();
    }
    string[] lines = File.ReadAllLines(fileName);
    list = new List<string>(lines);
    return list;
    
  }
}