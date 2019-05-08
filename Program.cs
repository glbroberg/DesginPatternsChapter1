using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            // Duck Mallard = new MallardDuck();
            // Mallard.SetFlyBehavior(new FlyWithWings());
            // Mallard.SetQuackBehavior(new MuteQuack());
            // Mallard.display();
            // Mallard.performQuack();
            // Mallard.performFly();

            Duck model = new ModelDuck();
            model.flyBehavior = new FlyRocketPowered();
            model.performFly();
        }
    }
}
