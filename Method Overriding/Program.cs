using System;

namespace Method_Overriding
{
    class Animal
    {
        public virtual void Eat()
        {
            Console.WriteLine("Eating..");
        }
    }
    class Dog : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Eating Bread...");
        }
    }
    class Result
    {
        public static void Main()
        {
            Dog d = new Dog();
            d.Eat();
        }
    }
}
