using System;

namespace Exception_Handling
{
    #region Example 1
    //class Example1
    //{
    //    public static void Main()
    //    {
    //        try
    //        {
    //            int a = 10;
    //            int b = 0;
    //            int result = a / b;
    //        }
    //        catch (Exception e)
    //        {
    //            Console.WriteLine(e);
    //        }
    //        Console.WriteLine("Rest Of The Code..");
    //    }
    //}
    #endregion

    class Example2
    {
        public static void Main()
        {
            try
            {
                int a = 10;
                int b = 0;
                int result = a / b;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("Finally Block Executed..");
            }
            Console.WriteLine("Rest Of The Code..");
        }
    }
}
