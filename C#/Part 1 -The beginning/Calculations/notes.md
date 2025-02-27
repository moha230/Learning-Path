# Calculations


## Statement and expression

* expression is combination of values that change into a value during calculation or evaluation.

* the evaluation happens before the assignment so the calculation is done before the value is set to the variable. 

```python
the right hand side expression is evaluated first and then the results is assigned to the variable on the left hand side. 

int x = 5 + 2 

step 1 : evaluate the expression on the right hand side 5 + 3 which is the results in 8
step 2 : Assign the results to the variable X
their for x results to 8

```
* an expression does not change the value of a variable 

```python
An expression in itself does not change the value of any variable unless the result of the expression is explicitly assigned back to a variable. For example:

int y = 10;
y + 2 
Step 1: The expression y + 2 is evaluated, resulting in 12.
Step 2: The result 12 is not assigned to any variable, so the value of y remains 10.
```
* unless the results of the expression is set as a value or given as a parameter to a method such as print

```C#
to change the value of the variable the results of the expression needs to be assigned to the variable or used in a function like ConsoleWriteLine().

z = 4;
z = z + 3;

ConsoleWriteLine(z + 3);

Step 1: The expression z + 3 is evaluated, resulting in 10.
Step 2: The value 10 is printed, but the variable z remains unchanged.
```

## Calculations and printing

when one side of the addition is a string the other side is also changed to a string when the program is run. 
Console.WriteLine("Four: " + (2 + 2));

step 1 the expression inside the parantheses (2 + 2) is evaluated the result is 4 
step 2 the results is converted in a string and concatenated with the string "Four: "
Step 3 the final output "Four: 4"

The reason for ths is becouse the evaluation happens before any string concatenation 

in this example the integer 2 is turned int a string 
Console.WriteLine("But! Twenty-two: " + 2 + 2);

Step 1: The evaluation starts from left to right. The first part "But! Twenty-two: " is a string.

Step 2: Since "But! Twenty-two: " is a string, when 2 is added to it, the integer 2 is automatically converted to the string "2".

Step 3: The result now is "But! Twenty-two: 2".

Step 4: The next 2 is added to the resulting string, so it is also converted to the string "2".

Step 5: The final output is "But! Twenty-two: 22".

take aways 

* parantheses control evalutaion order 
* string concatenation converts numbers to strings 
*Left-to-right evaluation in concatenation: Without parentheses, the addition happens sequentially from left to right, leading to each number being converted to a string and concatenated.

``Let's clarify this step by step using the given examples:

### 1. **Evaluation with Brackets:**
```csharp
Console.WriteLine("Four: " + (2 + 2));
```

- **Step 1:** The expression inside the parentheses `(2 + 2)` is evaluated first. `2 + 2` results in `4`.
- **Step 2:** The result, `4`, is then converted to a string and concatenated with the string `"Four: "`.
- **Step 3:** The final output is `"Four: 4"`.

Here, because the calculation is done inside parentheses, the addition happens before any string concatenation.

### 2. **Evaluation without Brackets:**
```csharp
Console.WriteLine("But! Twenty-two: " + 2 + 2);
```

- **Step 1:** The evaluation starts from left to right. The first part `"But! Twenty-two: "` is a string.
- **Step 2:** Since `"But! Twenty-two: "` is a string, when `2` is added to it, the integer `2` is automatically converted to the string `"2"`.
- **Step 3:** The result now is `"But! Twenty-two: 2"`. 
- **Step 4:** The next `2` is added to the resulting string, so it is also converted to the string `"2"`.
- **Step 5:** The final output is `"But! Twenty-two: 22"`.

### Key Takeaways:
- **Parentheses control evaluation order:** `(2 + 2)` is calculated first before being converted to a string.
- **String concatenation converts numbers to strings:** When you add a number to a string, the number is converted to a string, and the result is concatenated.
- **Left-to-right evaluation in concatenation:** Without parentheses, the addition happens sequentially from left to right, leading to each number being converted to a string and concatenated.

In the first case, parentheses force arithmetic first. In the second case, concatenation occurs step by step, treating each number as a string.
``

# Multiplication and division

```Csharp
Console.WriteLine(3*2);
Console.WriteLine(13 / 5);    // output: 2

```

if we change one or both of the numbers to be double the results will aslo be a double. 

```Csharp
Console.WriteLine(13/5.0);
Console.WriteLine(13 / 5);    // output: 2
int x = 13;
int y = 5;
Console.WriteLine((double)x / y);  // output: 2.6
```

int first = 13;
int second = 6;
int third = 42;
double average = (first + second + third) / 3.0; //divide by the amount of numbers
Console.WriteLine(average);  // prints 20.333333333333332

The divider for the average is 3.0, which is a double. Even though we declare average as a double, if all the operands are integers, the value for average would evaluate as 20.

operands are value or variables that operat act upon in expresions it can be constant varaible or an expression that evaluates to a value.

# Common misconceptions with variables

when computer runs source code is run one command at a time progressing exaclty as the cod says 

when a vlaue is set to a variable 

The right side of the equal sign 

row 1: int first = (1 + 1);
row 2: int second = first + 3 * (2 + 5);
row 3:
row 4: first = 5;
row 5:
row 6: int third = first + second;
row 7: Console.WriteLine(first);
row 8: Console.WriteLine(second);
row 9: Console.WriteLine(third);

row 1: create variable first
row 1: evaluate the calculation 1 +1 and assign the value to the variable first
row 1: the value of variable first is now 2
row 2: create variable second
row 2: calculate 2 + 5, 2 + 5 -> 7
row 2: calculate 3 * 7, 3 * 7 -> 21
row 2: calculate first + 21
row 2: copy the value of the variable first into the calculation, the value of first is 2
row 2: calculate 2 + 21, 2 + 21 -> 23
row 2: assign the value for variable second as 23
row 2: the value of variable second is now 23
row 3: (empty, do nothing)
row 4: assign the value for variable first as 5
row 4: the value of variable first is now 5
row 5: (empty, do nothing)
row 6: create variable third
row 6: calculate first + second
row 6: copy the value for variable first arvo into the calculation, the value of variable first is now 5
row 6: calculate 5 + second
row 6: copy the value for variable second arvo into the calculation, the value of variable second is now 23
row 6: calculate 5 + 23 -> 28
row 6: assign the value for variable third as 28
row 6: the value of variable third is now 28
row 7: print variable first
row 7: copy the value for variable first arvo to be printed, the value of variable first is now 5
row 7: print value 5
row 8: print variable second
row 8: copy the value for variable second arvo to be printed, the value of variable second is now 23
row 8: print value 23
row 9: print variable third
row 9: assign the value for variable third arvo to be printed, the value of variable third is now 28
row 9: print value 28