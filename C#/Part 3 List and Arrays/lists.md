# Lists 

its a  pre made tool used for dealing with list of data 

List<T> Methods
├── Add Methods
│   ├── Add (Add an item to the list)
│   └── AddRange (Add multiple items to the list)
├── Remove Methods
│   ├── Remove (Remove the first occurrence of an item)
│   ├── RemoveAll (Remove all items matching a condition)
│   ├── RemoveAt (Remove item at a specific index)
│   └── RemoveRange (Remove a range of items)
├── Find Methods
│   ├── Find (Find the first item matching a condition)
│   ├── FindAll (Find all items matching a condition)
│   └── FindIndex (Find the index of the first item matching a condition)
├── Insert Methods
│   ├── Insert (Insert an item at a specific index)
│   └── InsertRange (Insert a range of items at a specific index)
├── Query Methods
│   ├── Contains (Check if the list contains a specific item)
│   ├── Exists (Check if any item satisfies a condition)
│   ├── IndexOf (Find the index of the first occurrence of an item)
│   ├── LastIndexOf (Find the index of the last occurrence of an item)
│   └── ToArray (Convert the list to an array)
├── Sorting & Reversing
│   ├── Sort (Sort the list)
│   ├── Reverse (Reverse the list)
│   └── TrimExcess (Trim the capacity of the list to fit its count)
├── Other Methods
│   ├── ForEach (Perform an action on each item)
│   ├── CopyTo (Copy the list items to an array)
│   ├── Clear (Remove all items from the list)
│   └── ToString (Return a string representation of the list)


# Using and Creating Lists

* In order to be used it has to be imported into the program.
* `using System.Collections.Generic;`
* it has to initialized 

`List int = new list int()`

Once a list has been created, List assumes that all the variables contained in it are of the correct type.

# Adding to a List and Retrieving a Value from a Specific Place

`add` method is used to add a elements in  a list 


# Retrieving Information from a "Non-Existent" Place

If you try to retrieve information from a place that does not exist on the list, the program will print a ArgumentOutOfRangeException
As you can see, when calling for List[index], we are actually calling method System.Collections.Generic.List`1.get_Item(Int32 index), which is a more complex method, already built in. This is the advantage of built-in methods: We do not have to worry about how to implement a method for data retrieval from a list, as it already exists.

# Numbering and index

Each tool offered by C# has a name and location. The program can use a tool after it has been imported with the using command. The command is given the location and the name of the desired class. For example, the use of a Console from System necessitates placing the command using System; to the top of the program.

The same usually applies to all C# classes. Console is called directly from system, so we can import it with just using System;. If we want to use Lists, we have to go deeper, and use using System.Collections.Generic;.

```bash
System (Root Namespace)
├── System.Collections
│   ├── System.Collections.ArrayList
│   ├── System.Collections.CollectionBase
│   ├── System.Collections.DictionaryBase
│   ├── System.Collections.Hashtable
│   ├── System.Collections.Queue
│   ├── System.Collections.Stack
│   └── System.Collections.IEnumerable
├── System.Collections.Generic
│   ├── System.Collections.Generic.List<T>
│   ├── System.Collections.Generic.Dictionary<TKey, TValue>
│   ├── System.Collections.Generic.Queue<T>
│   ├── System.Collections.Generic.Stack<T>
│   ├── System.Collections.Generic.LinkedList<T>
│   ├── System.Collections.Generic.HashSet<T>
│   ├── System.Collections.Generic.SortedList<TKey, TValue>
│   ├── System.Collections.Generic.SortedSet<T>
│   └── System.Collections.Generic.IEnumerable<T>
├── System.IO
│   ├── System.IO.File
│   ├── System.IO.Directory
│   ├── System.IO.Stream
│   ├── System.IO.FileStream
│   ├── System.IO.StreamReader
│   └── System.IO.StreamWriter
├── System.Linq
│   ├── System.Linq.Enumerable
│   ├── System.Linq.Queryable
│   └── System.Linq.Expressions
├── System.Threading
│   ├── System.Threading.Thread
│   ├── System.Threading.Tasks.Task
│   └── System.Threading.Timer
├── System.Net
│   ├── System.Net.Http.HttpClient
│   ├── System.Net.Socket
│   └── System.Net.WebRequest
└── System.Reflection
    ├── System.Reflection.Assembly
    ├── System.Reflection.MethodInfo
    └── System.Reflection.PropertyInfo
```

# Iterating Over a List

The number of values on a list is provided by the list's `Count` property which returns the number of elements the list contains. The number is an integer (int), and it can be used as a part of an expression or stored in an integer variable for later use.

