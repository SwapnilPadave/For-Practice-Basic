using System;

namespace Pyramid_Pattern_2
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
                for(int l = i; l <= 4; l++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
