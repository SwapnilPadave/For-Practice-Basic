using System;

namespace Swapping_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Swapping Two Numbers Without Using Third Variable...");
            int a = 10;
            int b = 11;
            Console.WriteLine("Numbers Before Swapping:- a=" + a + ", b=" + b);
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("Numbers After Swapping:- a=" + a + ", b=" + b);
        }
    }
}
