using System;

namespace Internal_Access_Modifier
{
    class InternalTest
    {
        internal string name = "Swapnil Padave";
        internal void Msg(string msg)
        {
            Console.WriteLine("Hi " + msg);
        }
    }
    class program :InternalTest
    {
        static void Main()
        {
            InternalTest internalTest = new InternalTest();
            Console.WriteLine("Hi " + internalTest.name);
            internalTest.Msg("There..");
        }
    }
}
