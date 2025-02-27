Objects in a list

Adding object to a list

```csharp

public class Person
{
    // Property: Holds the name of the person (read-only after initialization).
    public string name { get; }

    // Property: Holds the age of the person.
    public int age { get; set; }

    // Property: Holds the weight of the person in kilograms.
    public int weight { get; set; }

    // Property: Holds the height of the person in centimeters.
    public int height { get; set; }

    // Constructor: Initializes a new Person object with a given name.
    // All other properties are initialized to default values: age = 0, weight = 0, height = 0.
    public Person(string name)
    {
        this.age = 0;      // Default age: 0
        this.weight = 0;   // Default weight: 0
        this.height = 0;   // Default height: 0
        this.name = name;  // Assign the given name to the name property.
    }

    // Method: Calculates and returns the Body Mass Index (BMI) of the person.
    // Formula: weight (kg) / (height in meters)^2
    public double BodyMassIndex()
    {
        // Convert height from cm to meters.
        double heigthPerHundred = this.height / 100.0;

        // Calculate and return BMI.
        return this.weight / (heigthPerHundred * heigthPerHundred);
    }

    // Method: Increases the person's age by 1 year, but only if they are under 100 years old.
    public void GrowOlder()
    {
        if (this.age < 100)  // Check if age is less than 100.
        {
            this.age = this.age + 1;  // Increment age by 1.
        }
    }

    // Method: Checks if the person is of legal age (18 years or older).
    // Returns true if age is 18 or more, false otherwise.
    public bool IsOfLegalAge()
    {
        return this.age >= 18;
    }

    // Method: Returns a string representation of the person.
    // Format: "<name>, age <age> years"
    public override string ToString()
    {
        return this.name + ", age " + this.age + " years";
    }
}
```