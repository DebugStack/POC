//Clean Code - Liskov Substitution Principle
interface IAnimals
{
    void Eat();
}
interface ISocialAnimals
{
    void Eat();
    void Groom();
}

interface IWildAnimals
{
    void Eat();
    void Hunt();
}

public class Tiger : IAnimals, IWildAnimals
{
    public void Eat()
    {
        Console.WriteLine("Tiger is eating");
    }
    public void Hunt()
    {
        Console.WriteLine("Tiger is hunting");
    }
}

public class Dog : IAnimals, ISocialAnimals
{
    public void Eat()
    {
        Console.WriteLine("Dog is eating");
    }
    public void Groom()
    {
        Console.WriteLine("Dog is grooming");
    }
}