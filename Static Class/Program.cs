using System;

namespace Static_Class
{
    public static class Program
    {
        public static float PI = 3.14f;
        public static int cube(int n)
        {
            return n * n * n;
        }
    }
    class TestMyMath
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Value of PI is:- " + Program.PI);
            Console.WriteLine("Cube of 11 is:- " + Program.cube(11));
        }
    }
}
