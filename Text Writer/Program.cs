using System;
using System.IO;

namespace Text_Writer
{
    class Program
    {
        static void Main(string[] args)
        {
            //using (TextWriter write = File.CreateText("C:\\Users\\Nimap\\Desktop\\C.txt)"))
            //{
            //    write.WriteLine("Hello Friends..");
            //    write.WriteLine("My Name Is Swapnil..");
            //}
            using (TextReader tr = File.OpenText("C:\\Users\\Nimap\\Desktop\\C.txt)"))
            {
                Console.WriteLine(tr.ReadToEnd());
            }
           
        }
    }
}
