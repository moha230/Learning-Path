class Program
{
    static void Main()
    {
        Dog myDog = new Dog();
        myDog.Name = "Buddy";
        myDog.Age = 3;
        myDog.Breed = "Golden Retriever";

        myDog.Describe(); // Inherited method
        myDog.Bark(); // New method from Dog class

        Cat myCat = new Cat();
        myCat.Name = "Whiskers";
        myCat.Age = 2;
        myCat.Describe(); // Inherited from Animal
        myCat.Play(); // Implemented from IPet
    }
}
