
int countOnes = 0;
while (true)
{
  // Create a variable as storage for counting 1s
  
  Console.WriteLine("Input an integer, 0 quits");
  // Read user input
  int number = Convert.ToInt32(Console.ReadLine());
  // If the input is 0, exit the loop
  if(number == 0)
  {
    break;
  }
   // If the input is 1, add to count
   if(number == 1) 
   {
     // Increase the value of countOnes by 1
    countOnes = countOnes + 1;
   
   }
   
}

Console.WriteLine("Amount of ones: " + countOnes);