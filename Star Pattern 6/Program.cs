
using System;

namespace Star_Pattern_6
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 5; i++)
            {
                for(int j = 2; j <= i; j++)
                {
                    Console.Write(" ");
                }
                for(int k = i; k <= 5; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
