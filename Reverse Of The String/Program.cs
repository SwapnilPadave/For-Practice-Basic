using System;

namespace Reverse_Of_The_String
{
    class Program
    {
        static void Main(string[] args)
        {
            ReverseString("SWAPNIL");
        }
        private static void ReverseString(string stringInput)
        {
            char[] stringArray = stringInput.ToCharArray();
            string reverse = string.Empty;
            for (int i = stringArray.Length - 1; i >= 0; i--)
            {
                reverse += stringArray[i];
            }
            Console.WriteLine(reverse);
            Console.ReadLine();
        }
       
    }
}
