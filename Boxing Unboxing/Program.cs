﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Boxing_Unboxing
{
    public class Program
    {
        static void Main()
        {
            //int i = 1;
            //object o = i; // boxing  
            //int j = (int)o; // unboxing  
            //Console.WriteLine(o);
            int i = 12;
            object box = i;
            if (box is int)
            {
                Console.Write("Box contains an int ");
            }
            Console.WriteLine(box);

        }
    }
}
