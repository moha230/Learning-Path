# Types of Exceptions in C#


Exception in C# are categorized into different types 

1. SystemException This are built in exceptions that occure  during runtime 

 *  `DivideByZeroException` Occurs when dividing a number by zero 
 *  `NullReferenceException` Occurs when trying to use an object that is null 
 * `IndexOutOfRangeException` Occurs when trying to access an index does not exist in an array 


 2. ApplicationException - These are user-defined exceptions created by programmers. 

 ## Handling Exceptions

 We use try-catch blocks to handle or prevent a program from crashing 

 ```C#
 try
{
    // Code that might throw an exception
}
catch (Exception e)
{
    // Code that handles the exception
}

 
 
 ```

 The reason for using catch keyword because an exception is referred to as `throwing` an exception.

property from the Exception

All the exceptions have a message, and it can be used with exception.Message.

The code in the catch block is executed immediately if the code in the try block throws an exception. 


## Catching file exceptions

common use of try catch is with reading and writing files 

errors encountered when not using try catch block 

```zsh
Unhandled exception. System.IO.FileNotFoundException: Could not find file '/Users/lachi.dong/Documents/centria/Learning path/C#/Part 11 - Random, files and exceptions/exception/fileDoesNotExist.txt'.
// File name: '/Users/lachi.dong/Documents/centria/Learning path/C#/Part 11 - Random, files and exceptions/exception/fileDoesNotExist.txt'
//    at Interop.ThrowExceptionForIoErrno(ErrorInfo errorInfo, String path, Boolean isDirError)
//    at Microsoft.Win32.SafeHandles.SafeFileHandle.Open(String path, OpenFlags flags, Int32 mode, Boolean failForSymlink, Boolean& wasSymlink, Func`4 createOpenException)
//    at Microsoft.Win32.SafeHandles.SafeFileHandle.Open(String fullPath, FileMode mode, FileAccess access, FileShare share, FileOptions options, Int64 preallocationSize, UnixFileMode openPermissions, Int64& fileLength, UnixFileMode& filePermissions, Boolean failForSymlink, Boolean& wasSymlink, Func`4 createOpenException)
//    at System.IO.Strategies.OSFileStreamStrategy..ctor(String path, FileMode mode, FileAccess access, FileShare share, FileOptions options, Int64 preallocationSize, Nullable`1 unixCreateMode)
//    at System.IO.StreamReader.ValidateArgsAndOpenPath(String path, Encoding encoding, Int32 bufferSize)
//    at System.IO.File.ReadAllText(String path, Encoding encoding)
//    at Program.Main(String[] args) in /Users/lachi.dong/Documents/centria/Learning path/C#/Part 11 - Random, files and exceptions/exception/Program.cs:line 105
//

```

after using a try catch block error in the terminal 

```zsh
Could not find file '/Users/Documents/Learning path/C#/Part 11 - Random, files and exceptions/exception/fileDoesNotExist.txt'.


```

## Shifting the responsibility

In the provided code, the programmer demonstrates two ways to handle exceptions: **handling the exception within the method** and **shifting the responsibility of handling the exception to the caller**. Let’s break down the two approaches and explain how the responsibility is shifted in the second example.

### First Approach: Handling the Exception

In the first code example, the `ReadLines` method handles exceptions internally using a `try-catch` block:

```csharp
public static List<string> ReadLines(string fileName)
{
  List<string> list = new List<string>();
  try
  {
    string[] lines = File.ReadAllLines(fileName);
    list = new List<string>(lines);
  }
  catch (Exception e)
  {
    Console.WriteLine(e.Message); // Handle the exception by printing the message
  }
  return list;
}
```

- **What Happens:** If an exception occurs (e.g., if the file does not exist or cannot be read), it is caught within the `ReadLines` method. The method then prints the exception message but continues to return an empty list (or whatever it has read).
- **Responsibility:** In this case, the `ReadLines` method is responsible for handling any exceptions that arise during file reading.

### Second Approach: Shifting the Responsibility

In the second example, the programmer chooses to shift the responsibility of handling exceptions to the caller of the `ReadLines` method:

```csharp
public static List<string> ReadLines(string fileName)
{
  List<string> list = new List<string>();
  if (!File.Exists(fileName))
  {
    throw new System.IO.FileNotFoundException(); // Throw an exception
  }
  string[] lines = File.ReadAllLines(fileName);
  list = new List<string>(lines);
  return list;
}
```

- **What Happens:** In this case, instead of catching the exception, the method checks if the file exists. If the file does not exist, it throws a `FileNotFoundException`. This means that the method no longer handles the exception itself.
- **Responsibility:** By throwing the exception, the `ReadLines` method passes the responsibility of handling the error to the calling method (in this case, `Main`). The caller can then decide how to handle the exception, which allows for more flexible error management.

### Main Method

In the `Main` method, the programmer handles the exception thrown by `ReadLines`:

```csharp
public static void Main(string[] args)
{
  try
  {
    ReadLines("nonExistingFile.txt").ForEach(Console.WriteLine);
  }
  catch (Exception e)
  {
    Console.WriteLine("Caught in Main!"); // Handle the exception here
  }
}
```

- **What Happens:** The `Main` method calls `ReadLines` and wraps the call in a `try-catch` block. If `ReadLines` throws a `FileNotFoundException`, it is caught in the `catch` block in `Main`, allowing the programmer to handle the error (in this case, printing "Caught in Main!").
  
### Summary

In summary, the programmer shifted the responsibility of exception handling from the `ReadLines` method to the caller (`Main`) by throwing exceptions instead of catching them. This approach provides greater flexibility, as the caller can choose how to respond to errors, which may vary depending on the context in which the method is used.