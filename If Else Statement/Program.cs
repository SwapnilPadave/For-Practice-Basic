using System;

namespace If_Else_Statement
{
    class Program
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number:");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("Number Is Even");
            }
            else
            {
                Console.WriteLine("Number Is Odd");
            }
        }

    }
}
