using System;

namespace Enum_Set_Starting_Index
{
    public class Program
    {
        public enum Season
        {
            Winter = 99, Spring, Summer, Fall
        };
        public static void Main(string[] args)
        {
            int x = (int)Season.Winter;
            int y = (int)Season.Fall;
            Console.WriteLine("Winter= {0}", x);
            Console.WriteLine("Fall= {0}", y);
        }
    }
}
