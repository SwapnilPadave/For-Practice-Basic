using System;

namespace Find_Duplicate_Number
{
    class program 
    {
        static void printRepeating(int[] arr, int size)
        {
            int i, j;

            Console.Write("Duplicate Elements are :");
            for (i = 0; i < size - 1; i++)
            {
                for (j = i + 1; j < size; j++)
                {
                    if (arr[i] == arr[j])
                        Console.Write(arr[i] + " ");
                }
            }
        }
        // driver code
        public static void Main()
        {
            int[] arr = { 4, 2, 4, 5, 2, 3, 1, 6, 7, 3 };
            int arr_size = arr.Length;

            printRepeating(arr, arr_size);
        }
    }
}
