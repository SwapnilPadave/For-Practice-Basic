using System;

namespace Multi_level_inheritance
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
    public class BabyDoag : Dog
    {
        public void Weep()
        {
            Console.WriteLine("Baby Dog Is Weeping...");
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            BabyDoag bd1 = new BabyDoag();
            bd1.Eat();
            bd1.Bark();
            bd1.Weep();
        }
    }
}
