using System;
using System.IO;

namespace Stream_Writer
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream f = new FileStream("C:\\Users\\Nimap\\Desktop\\B.txt", FileMode.OpenOrCreate);
            StreamWriter s = new StreamWriter(f);
            s.WriteLine("HELLO C#..");
            s.Close();
            f.Close();
            Console.WriteLine("File Created Successfully..");
        }
    }
}
