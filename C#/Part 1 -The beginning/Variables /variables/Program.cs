public class Program {
  public static void Main(){
    //Prompt the user to inter an integer 
    Console.WriteLine("Give me an integer value: ");

    // Declare and assign the input as a string 
    string userInput =  Console.ReadLine();

    //convert the string into an integer but must store it in a variable 

    int intValue = Convert.ToInt32(userInput);

    //give out the input to the console 

    Console.WriteLine("You gave " + intValue);

    Console.Write("Give double value: ");

    //Assign a new value to user input 

    userInput = Console.ReadLine();

    //convert the string to a double type 
    double doubleValue = Convert.ToDouble(userInput);

    Console.WriteLine("You gave " + doubleValue);

  } 
}