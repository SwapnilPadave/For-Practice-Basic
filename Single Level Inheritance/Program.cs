using System;

namespace Single_Level_Inheritance
{
    public class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Animal Eating...");
        }
    }
    public class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Dog Is Barking..");
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Dog d = new Dog();
            d.Eat();
            d.Bark();
        }
    }
}
