using System;

namespace _2d_DataTypes_and_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] samplearray = new int[2, 2] { { 1, 2 }, { 3, 4 } };

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(samplearray[i, j] + "\t");



                }
                Console.WriteLine();
            }
        }
    }
}
