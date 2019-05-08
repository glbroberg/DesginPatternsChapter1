using System;

public class Squeak : IQuackBehavior
{
    void IQuackBehavior.quack()
    {
        Console.WriteLine("Squeak");
    }
}
