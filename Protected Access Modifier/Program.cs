using System;

namespace Protected_Access_Modifier
{
    class ProtectedTest
    {
        protected string name = "Swapnil Padave";
        protected void Msg(string msg)
        {
            Console.WriteLine("Hi " + msg);
        }
    }
    class program : ProtectedTest
    {
        static void Main()
        {
            program p = new program();
            Console.WriteLine("Hi " + p.name);
            p.Msg("There..");
        }
    }
}
