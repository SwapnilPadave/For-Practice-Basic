using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    public class program
    {
        public int id;
        public String name;
        public float salary;
        public program(int i, String n, float s)
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
            program p1 = new program(101, "Swapnil", 89000f);
            program p2 = new program(102, "Mahesh", 79000f);
            p1.display();
            p2.display();

        }
    }
}
