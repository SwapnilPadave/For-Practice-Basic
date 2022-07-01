using System;

namespace Diamond_Problem
{
    interface IA
    {
        void PrintIA();
    }
    interface IB
    {
        void PrintIB();
    }
    interface IC
    {
        void PrintIC();
    }
    public class A :IA
    {  
        public void PrintIA()
        {
            Console.WriteLine("Printing A Method..");
        }
    }
    public class B : IB
    {     

        public void PrintIB()
        {
            Console.WriteLine("Printing B Method.."); 
        }
    }
    public class C : IC
    {           
        public void PrintIC()
        {
            Console.WriteLine("Printing C Method..");
        }
    }
    public class D : IA, IB, IC
    {
        public void PrintIA()
        {
            Console.WriteLine("Printing IA Method Of Class D..");
        }

        public void PrintIB()
        {
            Console.WriteLine("Printing IB Method Of Class D.."); 
        }

        public void PrintIC()
        {
            Console.WriteLine("Printing IC Method Of Class D..");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            D obj = new D();
            obj.PrintIA();
            obj.PrintIB();
            obj.PrintIC();
        }
    }
}
