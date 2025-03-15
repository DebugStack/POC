// BAD CODE - As per Liskov Substitution Principle, the derived class should be able to replace the base class without affecting the functionality of the program.
// In the below code, the derived class Tiger is not able to replace the base class Animals as the Groom method is not implemented in the derived class.
// Hence, the code is violating the Liskov Substitution Principle.
public abstract class Animals
{
  public  virtual void Eat()
    {
        Console.WriteLine("Animals can eat");
    } 
   public virtual void Groom()
    {
        Console.WriteLine("Animals needs grooming");
    }
}

public class Tiger : Animals
{
    public override void Eat()
    {
        Console.WriteLine("Tiger is eating");
    }
    public override void Groom()
    {
        throw new System.NotImplementedException();
    }
}

public class Dog
{
    public virtual void Eat()
    {
        Console.WriteLine("Dog is eating");
    }
    public virtual void Groom()
    {
        Console.WriteLine("Dog is grooming");
    }
}