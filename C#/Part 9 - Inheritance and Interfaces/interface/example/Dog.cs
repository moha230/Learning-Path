class Dog : Animal // Dog inherits from Animal
{
    public string Breed; // Additional field

    public void Bark()
    {
        Console.WriteLine($"{Name} is barking! Woof Woof!");
    }
}
