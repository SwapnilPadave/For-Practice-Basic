using System;

namespace Square_Root_Of_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter A Number:- ");
            int number = Convert.ToInt32(Console.ReadLine());
            double SqrtNumber = Math.Sqrt(number);
            Console.WriteLine("Square Root of {0} is {1}", number, SqrtNumber);
            Console.ReadLine();
        }
    }
}
