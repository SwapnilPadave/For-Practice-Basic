using System;

namespace Call_By_Value_Function
{
    class Program
    {
        public void Show(int val)
        {
            val += val;
            Console.WriteLine("Value inside the show function " + val);
        }
        public static void Main(string[] args)
        {
            int val = 51;
            Program program = new Program();
            Console.WriteLine("Value Before Calling Function:-" + val);
            program.Show(val);
            Console.WriteLine("Value After Calling Function:-" + val);
        }
    }
}
