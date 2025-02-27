# Reading and Printing Strings

C# provides a rich set of string methods that allow you to manipulate, analyze, and format strings effectively. Below is a list of commonly used string methods in C#:

### 1. **Basic Information and Length**
- `Length`: Returns the number of characters in the string.
  ```csharp
  string str = "Hello";
  int len = str.Length; // 5
  ```

### 2. **Case Conversion**
- `ToLower()`: Converts the string to lowercase.
- `ToUpper()`: Converts the string to uppercase.
  ```csharp
  string str = "Hello";
  string lower = str.ToLower(); // "hello"
  string upper = str.ToUpper(); // "HELLO"
  ```

### 3. **Substring and Searching**
- `Substring(int startIndex)`: Returns a substring starting from the specified index.
- `Substring(int startIndex, int length)`: Returns a substring of the specified length.
- `IndexOf(string value)`: Returns the index of the first occurrence of the specified value.
- `LastIndexOf(string value)`: Returns the index of the last occurrence of the specified value.
- `Contains(string value)`: Returns `true` if the string contains the specified value.
  ```csharp
  string str = "Hello World";
  string sub = str.Substring(0, 5); // "Hello"
  int index = str.IndexOf("World"); // 6
  bool contains = str.Contains("World"); // true
  ```

### 4. **Modification and Replacement**
- `Replace(string oldValue, string newValue)`: Replaces all occurrences of a substring with a new substring.
- `Trim()`: Removes leading and trailing whitespace.
- `TrimStart()`: Removes leading whitespace.
- `TrimEnd()`: Removes trailing whitespace.
- `PadLeft(int totalWidth)`: Pads the string on the left with spaces to a specified length.
- `PadRight(int totalWidth)`: Pads the string on the right with spaces to a specified length.
  ```csharp
  string str = "  Hello World  ";
  string trimmed = str.Trim(); // "Hello World"
  string replaced = str.Replace("World", "C#"); // "  Hello C#  "
  ```

### 5. **Splitting and Joining**
- `Split(char[] separator)`: Splits a string into an array based on the specified delimiter.
- `Join(string separator, string[] values)`: Combines an array of strings into a single string with a specified delimiter.
  ```csharp
  string str = "Apple,Banana,Cherry";
  string[] fruits = str.Split(','); // ["Apple", "Banana", "Cherry"]
  string joined = string.Join(", ", fruits); // "Apple, Banana, Cherry"
  ```

### 6. **Comparison**
- `Equals(string value)`: Compares two strings for equality.
- `Compare(string strA, string strB)`: Compares two strings and returns an integer indicating their relative position.
- `CompareTo(string value)`: Compares the current string with another string.
  ```csharp
  string str1 = "Hello";
  string str2 = "World";
  bool isEqual = str1.Equals(str2); // false
  int compare = str1.CompareTo(str2); // -1
  ```

### 7. **Formatting**
- `Format(string format, params object[] args)`: Formats strings using placeholders.
  ```csharp
  string formatted = string.Format("Name: {0}, Age: {1}", "John", 25); // "Name: John, Age: 25"
  ```

### 8. **Checking and Validation**
- `IsNullOrEmpty(string value)`: Checks if the string is `null` or empty.
- `IsNullOrWhiteSpace(string value)`: Checks if the string is `null`, empty, or consists only of white spaces.
  ```csharp
  string str = "";
  bool isEmpty = string.IsNullOrEmpty(str); // true
  ```

### 9. **Escaping and Literals**
- `Escape` characters: Use `\\`, `\n`, `\t`, etc., for special characters.
- Verbatim literals: Use `@` before strings for verbatim text (e.g., `@"C:\Path\To\File"`).

These methods are part of the `System.String` class and can be used in various scenarios to handle strings effectively in C#.