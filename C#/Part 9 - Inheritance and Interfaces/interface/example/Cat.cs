class Cat : Animal, IPet
{
    public void Play()
    {
        Console.WriteLine($"{Name} is playing with a ball!");
    }
}
