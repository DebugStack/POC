//Clean Code - Liskov Substitution Principle
interface IAnimals
{
    void Eat();
    void Walk();
}
public abstract class SocialAnimals
{
    public virtual void Groom()
    {
        Console.WriteLine("Only Social animals can be groomed in home");
    }
}

public abstract class WildAnimals
{
    public virtual void Hunt()
    {
        Console.WriteLine("Only Wild animals can hunt");
    }
}

public class TheTiger : WildAnimals, IAnimals
{
    public void Eat()
    {
        Console.WriteLine("Tiger is eating");
    }
    public void Walk()
    {
        Console.WriteLine("Tiger can walk");
    }
    public override void Hunt()
    {
        Console.WriteLine("Tiger is hunting");
    }
}

public class TheDog : SocialAnimals, IAnimals
{
    public void Eat()
    {
        Console.WriteLine("Dog is Eating");
    }
    public void Walk()
    {
        Console.WriteLine("Dog can walk");
    }
    public override void Groom()
    {
        Console.WriteLine("Dog an be groomed");
    }
}