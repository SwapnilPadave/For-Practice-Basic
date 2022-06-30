using System;

namespace Sealed_Class
{
    public sealed class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Animal Is Eating...");
        }
    }
    public class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Dog Is Barking..");
        }
    }
    public class TestSealed
    {
        public static void Main()
        {
            Dog d = new Dog();
            d.Bark();
            d.Eat();
        }
    }
}
