using System;

namespace Parameterized_Constructor
{
    public class Program
    {
        public int id;
        public String name;
        public float salary;
        public Program(int i, String n, float s)
        {
            id = i;
            name = n;
            salary = s;
        }
        public void display()
        {
            Console.WriteLine(id + " " + name + " " + salary);
        }
    }
    class TestEmployee
    {
        public static void Main(string[] args)
        {
            Program p1 = new Program(101, "Swapnil", 89000f);
            Program p2 = new Program(102, "Nilesh", 79000f);
            Program p3 = new Program(103, "Vijay", 100000f);
            p1.display();
            p2.display();
            p3.display();
        }
    }
}
