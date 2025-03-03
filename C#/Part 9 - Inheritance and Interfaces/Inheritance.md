# Inheritance


Every class added to the program create or add functionality to the programming language 

An essential solution rise from the interaction between objects which are created from classes.

An object is an independent unit that has a state 

which can be modified by using the methods that the object provides 


# step 1 basic inheritance: 

inheritance allows a class to inherit properties and methods from another class.
The class that inherits is called the `derived class` and the class that it inherits from is called the `base class`.

```C#
// Base class
class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }

    // Constructor for Animal class
    public Animal(string name, int age)
    {
        Name = name;
        Age = age;
    }

    // Method for Animal class
    public void Speak()
    {
        Console.WriteLine("The animal makes a sound.");
    }
}

// Derived class
class Dog : Animal
{
    // Constructor for Dog class
    public Dog(string name, int age) : base(name, age)
    {
    }

    // Override method for Dog class
    public void Speak()
    {
        Console.WriteLine("The dog barks.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating an instance of Dog
        Dog dog = new Dog("Buddy", 3);
        dog.Speak(); // The dog barks.
        Console.WriteLine($"Name: {dog.Name}, Age: {dog.Age}");
    }
}
```

the reason why we use the base key word is to call the constructor of the base class. 


# Access modifiers private, protected, and public

* Private members are visible only in derived classes


Let's break this down step-by-step to explain the visibility and access control of members in a base class and its derived classes in object-oriented programming. We'll explain the concept using a class structure and how private, protected, and public members behave differently in inheritance.

### Step 1: Understanding the visibility of members
1. **Private members** are only accessible within the class they are declared. Derived classes **cannot** access private members of the base class directly.
2. **Protected members** are accessible within the base class and derived classes but not outside them.
3. **Public members** are accessible both within the class and from outside, including derived classes.

### Step 2: Example with private members

Let's say we have a base class `Part` that has private members. We define a derived class `Engine`, and we will see what happens if we try to access these private members.

```cpp
#include <iostream>
using namespace std;

// Base class
class Part {
private:
    int identifier;         // private member
    string manufacturer;    // private member
    string description;     // private member

public:
    Part(int id, string mfg, string desc)
        : identifier(id), manufacturer(mfg), description(desc) {}

    void printDetails() {
        cout << "Identifier: " << identifier << endl;
        cout << "Manufacturer: " << manufacturer << endl;
        cout << "Description: " << description << endl;
    }
};

// Derived class
class Engine : public Part {
public:
    Engine(int id, string mfg, string desc) : Part(id, mfg, desc) {}

    void display() {
        // Cannot directly access private members from Part
        // cout << identifier; // Error: 'identifier' is private within this context
        // cout << manufacturer; // Error: 'manufacturer' is private within this context
        // cout << description; // Error: 'description' is private within this context
        printDetails();  // We can access private members indirectly through a public method
    }
};

int main() {
    Engine engine(1, "Ford", "V8 Engine");
    engine.display();
    return 0;
}
```

#### Explanation:
- The private members `identifier`, `manufacturer`, and `description` of the `Part` class cannot be accessed directly from the `Engine` class because they are marked as `private` in the `Part` class.
- However, we can access them indirectly by calling the public method `printDetails()` from the `Engine` class.

### Step 3: Changing the access level to `public`

Now let's change the access control of the members to `public` in the `Part` class. This allows the derived class `Engine` to access the members directly.

```cpp
#include <iostream>
using namespace std;

// Base class with public members
class Part {
public:
    int identifier;         // public member
    string manufacturer;    // public member
    string description;     // public member

    Part(int id, string mfg, string desc)
        : identifier(id), manufacturer(mfg), description(desc) {}
};

// Derived class
class Engine : public Part {
public:
    Engine(int id, string mfg, string desc) : Part(id, mfg, desc) {}

    void display() {
        // Now we can directly access public members
        cout << "Identifier: " << identifier << endl;
        cout << "Manufacturer: " << manufacturer << endl;
        cout << "Description: " << description << endl;
    }
};

int main() {
    Engine engine(1, "Ford", "V8 Engine");
    engine.display();
    return 0;
}
```

#### Explanation:
- Since the members `identifier`, `manufacturer`, and `description` are now `public`, the `Engine` class can directly access and use them in its own methods.
- The `display()` method of the `Engine` class now prints the values of these members directly.

### Step 4: Visibility of private members in nested derived classes

If a derived class is nested within the base class, it can access the private members of the base class. Here's an example to demonstrate that:

```cpp
#include <iostream>
using namespace std;

class Part {
private:
    int identifier;
    string manufacturer;
    string description;

public:
    Part(int id, string mfg, string desc)
        : identifier(id), manufacturer(mfg), description(desc) {}

    void printDetails() {
        cout << "Identifier: " << identifier << endl;
        cout << "Manufacturer: " << manufacturer << endl;
        cout << "Description: " << description << endl;
    }

    // Nested derived class
    class Engine : public Part {
    public:
        Engine(int id, string mfg, string desc) : Part(id, mfg, desc) {}

        void display() {
            // Accessing private members from the base class directly
            cout << "Identifier: " << identifier << endl;  // No error
            cout << "Manufacturer: " << manufacturer << endl;  // No error
            cout << "Description: " << description << endl;  // No error
        }
    };
};

int main() {
    Part::Engine engine(1, "Ford", "V8 Engine");
    engine.display();
    return 0;
}
```

#### Explanation:
- In this case, the `Engine` class is nested inside the `Part` class.
- Since it is nested inside the base class, the `Engine` class can access the private members of `Part` directly, even though they are private in the base class.

### Conclusion:
- **Private members** in a base class are not directly accessible from derived classes, unless they are nested within the base class itself.
- **Public members** in a base class can be accessed directly from any derived class.
- **Protected members** are accessible from the derived class but not outside of the class hierarchy.
