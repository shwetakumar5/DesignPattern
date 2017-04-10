using System;
//creating interfaces
public interface FlyableDuck
{
      void fly();
}

public interface QuackableDuck
{
     void quack();
}

//creating behavior classes
public class FlyWithWings:FlyableDuck
{
    public void fly()
    {
        Console.WriteLine("I am flying.");
    }
}

public class FlyNoWings: FlyableDuck
{
    public void fly()
    {
        Console.WriteLine("I can't fly. :(");
    }
}

public class Quacking: QuackableDuck
{
    public void quack()
    {
        Console.WriteLine("Quack Quack!!");
    }
}

public class NoQuack : QuackableDuck
{
    public void quack()
    {
        Console.WriteLine("Can't quack :(");
    }
}
public class SqueakQuack : QuackableDuck
{
    public void quack()
    {
        Console.WriteLine("Squeak quack!!");
    }
}

//creating abstrack class
public abstract class Duck
{
    public QuackableDuck quackableDuck;
    public FlyableDuck flyableDuck;
    public Duck() { }
    public abstract void display();
    public void perfomFly()
    {
        flyableDuck.fly();     
    }
    public void perfomQuack()
    {
        quackableDuck.quack();
    }
    public void swim()
    {
        Console.WriteLine("All ducks swim :)");
    }
}

//subclass
public class MallardDuck:Duck
{
    public MallardDuck()
     {
        quackableDuck = new Quacking();
        flyableDuck = new FlyWithWings();
     }
    public override void display()
    {
        Console.WriteLine("I am Mallard Duck.");
    }
}

public class DuckSimulator
{
    public static void Main(String[] args)
    {
        MallardDuck mallard = new MallardDuck();
        mallard.display();
        mallard.perfomFly();
        mallard.perfomQuack();
        Console.ReadKey();
    }
}