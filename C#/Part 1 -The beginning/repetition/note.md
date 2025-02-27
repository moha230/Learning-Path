

---

### The `break` Keyword

- The `break` keyword is used to exit a loop or terminate a `switch` statement. When encountered, it immediately ends the current loop iteration and jumps to the first statement following the loop.

### Calculations with While Loops

- When the number of user inputs is unknown, a `while (true)` loop can be used to continuously read input until a certain condition is met.
- In this example, the program counts the number of times the user inputs the number 1.

```csharp
int countOnes = 0; // Variable to keep track of the number of 1s

while (true)
{
    Console.WriteLine("Input an integer, 0 quits");
    int number = Convert.ToInt32(Console.ReadLine()); // Read user input
    
    // If the input is 0, exit the loop
    if (number == 0)
    {
        break;
    }
    
    // If the input is 1, increase the count
    if (number == 1) 
    {
        countOnes = countOnes + 1;
    }
}

Console.WriteLine("Amount of ones: " + countOnes); // Output the total number of 1s
```

### Explanation

1. **Loop Behavior:**
   - The `while (true)` loop runs indefinitely, repeatedly prompting the user for input.
   - When the user inputs `0`, the `break` statement exits the loop.

2. **Counting Logic:**
   - If the input is `1`, the program increments the `countOnes` variable.
   - The variable `countOnes` is declared outside the loop, making it accessible throughout the program, even after the loop ends.

3. **Displaying the Result:**
   - Once the loop exits, the program prints the total number of times `1` was entered.
   - Since `countOnes` is in the global scope of the method, it retains its value, allowing the final count to be displayed.

---
