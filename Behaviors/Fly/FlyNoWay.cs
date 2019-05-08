using System;

public class FlyNoWay : IFlyBehavior
{
    public void fly()
    {
        Console.WriteLine("I cannot fly!");
    }
}