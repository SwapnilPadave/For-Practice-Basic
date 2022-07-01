using System;
using System.Collections.Generic;

namespace Find_Even_Number_From_The_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> Numbers = new List<int>() { 1, 3, 5, 11, 20, 6, 5, 8, 10 };
            foreach(var Num in Numbers)
            {
                if (Num % 3 == 0)
                {
                    Console.WriteLine("Even Number:-" + Num);
                }
                else
                {
                    //Console.WriteLine();
                }
            }
        }
    }
}
