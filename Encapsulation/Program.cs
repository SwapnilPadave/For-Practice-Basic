using System;

namespace Encapsulation
{
    class Student
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
    class Program
    {
        public static void Main()
        {
            Student student1 = new Student();
            Student student2 = new Student();
            student1.ID = "999";
            student1.Name = "Swapnil Padave";
            student1.Email = "spadave7@gmail.com";

            student2.ID = "111";
            student2.Name = "Nilesh Pathak";
            student2.Email = "NileshPathak@gmail.com";

            Console.WriteLine("ID=" + student1.ID);
            Console.WriteLine("Name=" + student1.Name);
            Console.WriteLine("Email=" + student1.Email);
            Console.WriteLine();
            Console.WriteLine("ID=" + student2.ID);
            Console.WriteLine("Name=" + student2.Name);
            Console.WriteLine("Email=" + student2.Email);
        }
    }
}
