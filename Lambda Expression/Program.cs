using System;
using System.Collections.Generic;
using System.Linq;

namespace Lambda_Expression
{
    //Example 1
    class Program
    {
        static void Main()
        {
            List<int> numbers = new List<int>() { 36, 71, 12,
                             15, 29, 18, 27, 17, 9, 34};
            Console.Write("List Numbers:-");
            foreach (var values in numbers)
            {
                Console.Write("{0} ", values);
            }
            Console.WriteLine();
            var square = numbers.Select(x => x * x);
            Console.Write("Square:-");
            foreach (var values in square)
            {
                Console.Write("{0} ", values);
            }
            Console.WriteLine();

            var DivBy3 = numbers.FindAll(x => (x % 3) == 0);
            Console.Write("Divide By 3:-");
            foreach (var values in DivBy3)
            {
                Console.Write("{0} ", values);
            }
            Console.WriteLine();
        }
    }
    #region Example 2
    //class Student
    //{
    //    public int RollNo { get; set; }
    //    public string Name { get; set; }
    //}
    //class CGI
    //{
    //    public static void Main()
    //    {
    //        List<Student> Details = new List<Student>()
    //        {
    //            new Student{RollNo=1,Name="Swapnil"},
    //            new Student{RollNo=2,Name="Nilesh"},
    //            new Student{RollNo=3,Name="Ajay"},
    //            new Student{RollNo=4,Name="Vijay"},
    //            new Student{RollNo=5,Name="Sanket"}
    //        };
    //        var newDetails = Details.OrderBy(x => x.Name);
    //        foreach (var values in newDetails)
    //        {
    //            Console.WriteLine(values.RollNo + " " + values.Name);
    //        }

    //    }
    //}
    #endregion
}
