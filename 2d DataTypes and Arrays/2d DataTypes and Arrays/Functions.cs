using System;
using System.Collections.Generic;
using System.Text;

namespace _2d_DataTypes_and_Arrays
{
    class Functions
    {
        static void Main2(string[] args)
        {
            factorial(5);
        }
        static void factorial(int n)
        {
            
            Console.WriteLine("Enter no whose factorial is to be calculated");
            n = Convert.ToInt32(Console.ReadLine());
            int i, p = 1;
            for (i = 1; i < n + 1; i++)
            {
                p = p * i;
            }
            Console.WriteLine("Factorial is " + p);

        }

        

    }
}
