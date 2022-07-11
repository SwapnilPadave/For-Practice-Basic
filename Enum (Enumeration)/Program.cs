﻿using System;

namespace Enum__Enumeration_
{
    //public class Program
    //{
    //    public enum Season
    //    {
    //        Winter, Spring, Summer, Fall
    //    };
    //    public static void Main(string[] args)
    //    {
    //        int x = (int)Season.Winter;
    //        int y = (int)Season.Fall;
    //        Console.WriteLine("Winter={0}", x);
    //        Console.WriteLine("Fall={0}", y);
    //    }
    //}
    class Program
    {
        public enum DayofWeek
        {
            Sunday = 1, Monday, Tuesday = 1, Wednesday, Thursday = 2, Friday, Saturday
        }
        static void Main(string[] args)
        {
            string[] values = Enum.GetNames(typeof(DayofWeek));
            foreach (string s in values)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();
            int[] n = (int[])Enum.GetValues(typeof(DayofWeek));
            foreach (int x in n)
            {
                Console.WriteLine(x);
            }
            Console.ReadLine();
        }
    }
}
