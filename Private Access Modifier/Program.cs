using System;

namespace Private_Access_Modifier
{
    class PrivateTest
    {
        private string name = "Swapnil Padave";
        private void Msg(string msg)
        {
            Console.WriteLine("Hi " + msg);
        }
        static void Main()
        {
            PrivateTest privateTest = new PrivateTest();
            Console.WriteLine("Hi " + privateTest.name);
            privateTest.Msg("There..");
        }
    }
}
