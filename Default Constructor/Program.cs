using System;

namespace Default_Constructor
{
    class Program
    {
        public Program()
        {
            Console.WriteLine("Default Constructor..");
        }
        public static void Main(string[] args)
        {
            Program p1 = new Program();
            Program p2 = new Program();
        }
    }
}
