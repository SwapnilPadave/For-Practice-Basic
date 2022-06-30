using System;

namespace Enum__Enumeration_
{
    public class Program
    {
        public enum Season
        {
            Winter, Spring, Summer, Fall
        };
        public static void Main(string[] args)
        {
            int x = (int)Season.Winter;
            int y = (int)Season.Fall;
            Console.WriteLine("Winter={0}", x);
            Console.WriteLine("Fall={0}", y);
        }
    }
}
