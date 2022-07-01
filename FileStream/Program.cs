using System;
using System.IO;

namespace FileStreams
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream f = new FileStream("C:\\Users\\Nimap\\Desktop\\A.txt", FileMode.OpenOrCreate);
            //for(int i = 65; i <= 90; i++)
            //{
            //    f.WriteByte((byte)i);
            //}
            //f.Close();
            int i = 0;
            while ((i = f.ReadByte()) != -1)
            {
                Console.Write((char)i);
            }
            f.Close();
        }
    }
}
