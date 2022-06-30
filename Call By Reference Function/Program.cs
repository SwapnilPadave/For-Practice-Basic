using System;

namespace Call_By_Reference_Function
{
    class Program
    {
        public void Show(ref int val)
        {
            val += val;
            Console.WriteLine("Value inside the show function " + val);
        }
        public static void Main(string[] args)
        {
            int val = 51;
            Program program = new Program();
            Console.WriteLine("Value Before Calling Function:-" + val);
            program.Show(ref val);
            Console.WriteLine("Value After Calling Function:-" + val);
        }
    }
}
