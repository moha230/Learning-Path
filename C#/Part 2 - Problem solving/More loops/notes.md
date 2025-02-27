# While-loop with a condition

conditional expression 

is a construct that allows you to return different values based on whether a condition is true or false 

helps control the flow of a program by making decisions at runtime.


expression is a combination of values,variables and operators that a program language evaluates to produce a value 


# for-loop

```csharp
int i = 0; // introduce the variable that counts the number of times the loop has executed 
while (i < 10) // definition of a loop and the condition of the loop 
{
  Console.WriteLine(i); contains the functionality to be executed 
  i++; increment 
}
```

same with a for loop 

for (int i = 0; i<10; i++) {
  Console.WriteLine(i);
}

# On Stopping a Loop Execution

The condtion of the loop is evaluated when the execution of a loop starts 

and when the execution of the loop body has reached the closing curly brackets 

# Repeating Functionality

// Create variables needed for the loop

while (true)
{
  // read input

  // end the loop --break

  // check for invalid input -- continue

  // handle valid input
}

// functionality to execute after the loop ends