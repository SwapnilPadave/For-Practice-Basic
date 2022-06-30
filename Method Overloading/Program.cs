using System;

namespace Method_Overloading
{
    class Calc
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static int Add(int a, int b, int c)
        {
            return a + b + c;
        }
    }
    public class Output
    {
        public static void Main()
        {
            Console.WriteLine(Calc.Add(11, 10));
            Console.WriteLine(Calc.Add(9, 12, 9));
        }
    }

    //class program
    //{
    //    void sum(int a, int b)
    //    {
    //        Console.WriteLine(a + b);
    //    }
    //    void sum(float a, float b)
    //    {
    //        Console.WriteLine(a + b);
    //    }
    //    static void Main()
    //    {
    //        program p = new program();
    //        p.sum(11, 10);
    //        p.sum(9f, 12f);
    //        Console.WriteLine();
    //    }
    //}
}
