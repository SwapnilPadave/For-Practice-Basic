using System;

namespace Exception_User_Define_Custom_Exception_
{
    //Example 1
    public class InvalidAgeException : Exception
    {
        public InvalidAgeException(string message) : base(message)
        {

        }
    }
    public class TestUserDefinedException
    {
        static void validate(int age)
        {
            if (age < 18)
            {
                throw new InvalidAgeException("Sorry, Age must be greater than 18");
            }
        }
        public static void Main(string[] args)
        {
            try
            {
                validate(12);
            }
            catch (InvalidAgeException e)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine("Rest of the code");
        }
    }

    #region Example 2
    //Example 2
    //public class InvalidPasswordException : Exception
    //{
    //    public InvalidPasswordException(string msg) : base(msg)
    //    {

    //    }
    //}
    //public class TestUserDefineException
    //{
    //    static void validate(int password)
    //    {
    //        if (password < 12)
    //        {
    //            throw new InvalidPasswordException("Sorry Wrong Password..");
    //        }
    //    }
    //    public static void Main(string[] args)
    //    {
    //        try
    //        {
    //            validate(14);
    //        }
    //        catch (InvalidPasswordException p)
    //        {
    //            Console.WriteLine(p);               
    //        }
    //        Console.WriteLine("Please Login Again.");
    //    }       
    //}
    #endregion
}
