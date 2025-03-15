//Clean Code - Liskov Substitution Principle
interface IAnimals
{
    void Eat();
    void Walk();
}
interface ISocialAnimals
{
    void Groom();
}

interface IWildAnimal
{
    void Hunt();
}

public class TheTiger : IAnimals, IWildAnimal
{
    public void Eat()
    {
        Console.WriteLine("Tiger is eating");
    }
    public void Walk()
    {
        Console.WriteLine("Tiger can walk");
    }
    public void Hunt()
    {
        Console.WriteLine("Tiger is hunting");
    } 
}

public class TheDog : IAnimals, ISocialAnimals
{
    public void Eat()
    {
       Console.WriteLine("Dog is Eating");
    }
    public void Walk()
    {
        Console.WriteLine("Dog can walk");
    }
    public void Groom()
    {
        Console.WriteLine("Dog an be groomed");
    }
}