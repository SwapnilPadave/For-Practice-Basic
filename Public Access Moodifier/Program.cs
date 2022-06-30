using System;

namespace Public_Access_Moodifier
{
    class Program
    {
        public string name = "Swapnil Padave";
        public void msg(string msg)
        {
            Console.WriteLine("Hello " + msg);
        }
    }
    class PublicTest
    {
        static void Main()
        {
            Program p = new Program();
            Console.WriteLine("Hello " + p.name);
            p.msg("Developer Trainee..");
        }
    }
}
