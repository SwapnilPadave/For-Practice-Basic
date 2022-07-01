using System;

namespace Checked_And_Unchecked
{
    class Program
    {
        static void Main(string[] args)
        {
            //checked 
            unchecked
            {
                int val = int.MaxValue;
                Console.WriteLine(val + 2);
            }
        }
    }
}
