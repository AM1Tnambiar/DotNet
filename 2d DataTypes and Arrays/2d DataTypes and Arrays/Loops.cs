using System;

namespace _2d_DataTypes_and_Arrays
{
    class Loops
    {
        static void Main1(string[] args)
        {
            //Program 1

           /*nt i, n, sum = 0;
            Console.Write("Input Value of terms : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nThe first {0} natural number are :\n", n);
            for (i = 1; i <= n; i++)
            {
                Console.Write("{0} ", i);
                sum += i;
            }
            Console.Write("\nThe Sum of Natural Number upto {0} terms : {1} \n", n, sum);*/

            //Program 2

            int i, j, rows, k = 1;

            Console.WriteLine("Input Number of rows:");
            rows = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= rows; i++)
            {
                for (j = 1; j <= i; j++)
                    Console.Write("{0} ", k++);
                Console.Write("\n");
            }


            string x = "42";
            bool z;
            z = int.TryParse(x, out int value);
            if (z)
            {
                Console.WriteLine("It is a number");
            }
            else
            {
                Console.WriteLine("It is not a number");
            }

        }
    }
}


     
