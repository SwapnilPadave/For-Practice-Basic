using System;

namespace Enum_traversing_all_values_using_getNames
{
    public class Program
    {
        public enum Days { sun, mon, tue, wed, thu, fri, sat };

        public static void Main()
        {
            foreach (string s in Enum.GetNames(typeof(Days)))
            {
                Console.WriteLine(s);
            }
        }
    }
}
