
using System;

namespace Star_Pattern_4
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 5; i++)
            {
                for(int j = i; j <= 5; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for(int i = 2; i <= 5; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
