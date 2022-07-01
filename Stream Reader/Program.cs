using System;
using System.IO;

namespace Stream_Reader
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream f = new FileStream("C:\\Users\\Nimap\\Desktop\\B.txt", FileMode.OpenOrCreate);
            StreamReader s = new StreamReader(f);
            //string line = s.ReadLine();
            //Console.WriteLine(line);
            string line = "";
            while ((line = s.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
            s.Close();
            f.Close();
        }
    }
}
