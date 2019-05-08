using System;

public abstract class Duck
{
    public IFlyBehavior flyBehavior;
    public IQuackBehavior quackBehavior;

    public Duck()
    {
        
    }

    public void SetFlyBehavior (IFlyBehavior fb)
    {
        flyBehavior = fb;
    }

    public void SetQuackBehavior(IQuackBehavior qb)
    {
        quackBehavior = qb;
    }

    public abstract void display();

    public virtual void display2()
    {

    }

    public void performQuack()
    {
        quackBehavior.quack();
    }

    public void performFly()
    {
        flyBehavior.fly();
    }

    public void swim()
    {
        Console.WriteLine("All ducks float, even decoys!");
    }

}