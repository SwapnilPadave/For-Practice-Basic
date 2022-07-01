using System;

namespace Second_Big_No
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Find The Second Big No In Array..");
            var array = new int[] { 12, 35, 1, 10, 34, 1 };
            int FBigNo = 0, SBigNo = 0;
            for(int i = 0; i < array.Length; ++i)
            {
                int arrItem = array[i];
                if (arrItem > FBigNo)
                {
                    SBigNo = FBigNo;
                    FBigNo = arrItem;
                }
                else if(arrItem>SBigNo && arrItem < FBigNo)
                
                    SBigNo = arrItem;          
            }
            Console.WriteLine($"Secong Big No :{SBigNo}");
            Console.ReadLine();
        }
    }
}
