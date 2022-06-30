using System;

namespace Else_If_Statement
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter A Number To Check Grade:-");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n < 0 || n > 100)
            {
                Console.WriteLine("Wrong Number");
            }
            else if (n > 0 && n < 35)
            {
                Console.WriteLine("Fail");
            }
            else if (n >= 35 && n < 50)
            {
                Console.WriteLine("D Grade");
            }
            else if (n >= 50 && n < 75)
            {
                Console.WriteLine("C Grade");
            }
            else if (n >= 75 && n < 85)
            {
                Console.WriteLine("B Grade");
            }
            else if (n >= 85 && n < 90)
            {
                Console.WriteLine("A Grade");
            }
            else if (n >= 90)
            {
                Console.WriteLine("A+ Grade");
            }
        }
    }
}
