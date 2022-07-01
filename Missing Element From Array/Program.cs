using System;

namespace Missing_Element_From_Array
{
    class Find_Missing_Number
    {
        static void Main(string[] args)
        {

            int[] arr = { 1, 2, 3, 4, 6, 7, 8, 9, 10 };

            int missNum, Totalsum;

            Totalsum = (arr.Length + 1) * (arr.Length + 2) / 2;


            foreach (int item in arr)
            {
                Totalsum = Totalsum - item;
            }
            missNum = Totalsum;

            Console.WriteLine("missing number  : {0}", missNum);
        }

    }
}
