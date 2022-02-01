using System;
using System.Collections.Generic;
using System.Text;

namespace _2d_DataTypes_and_Arrays
{
    class arrays
    {
        static void Main(string[] args)
        {
            // Program 1

            /*int i, j, size, count = 0;
            int[] arr = new int[100];
            Console.WriteLine("Enter the size of array:");
            size = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter {0} elements into your array:", size);
            for( i=0; i < size; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(i=0; i< size; i++)
            {
                for( j=i+1; j < size; j++ )
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                        break;
                    }
                    
                }
            }

            Console.WriteLine("Total amount of duplicate values found in Array is: "  +count); */

            // Program 2
            /*
            int i, size, lrg = 0, lrg2 =0, j = 0;
            int[] arr = new int[100];
            Console.WriteLine("Enter the size of array:");
            size = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter {0} elements into your array:", size);
            for (i = 0; i < size; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            for (i = 0; i < size; i++)
            {
                if (lrg < arr[i])
                {
                    lrg = arr[i];
                    j = i;
                }
            }
            
            
            for (i = 0; i < size; i++)
            {
                if (i == j)
                {
                    i++;
                    i--;
                }
                else
                {
                    if (lrg2 < arr[i])
                    {
                        lrg2 = arr[i];
                    }
                }
            }

            Console.WriteLine("The second largest element is {0}", lrg2);
            */

            //Program 3

            int i, j, r, c;
            int[,] arr1 = new int[50, 50];
            int[,] brr1 = new int[50, 50];

            Console.Write("\nInput the number of rows and columns of the first matrix :\n");
            Console.Write("Rows : ");
            r = Convert.ToInt32(Console.ReadLine());
            Console.Write("Columns : ");
            c = Convert.ToInt32(Console.ReadLine());


            Console.Write("Input elements in the matrix :\n");
            for (i = 0; i < r; i++)
            {
                for (j = 0; j < c; j++)
                {
                    Console.Write("element - [{0}],[{1}] : ", i, j);
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.Write("\nThe First matrix is :\n");
            for (i = 0; i < r; i++)
            {
                Console.Write("\n");
                for (j = 0; j < c; j++)
                    Console.Write("{0}\t", arr1[i, j]);
            }

            for (i = 0; i < r; i++)
            {
                for (j = 0; j < c; j++)
                {

                    brr1[j, i] = arr1[i, j];
                }
            }

            Console.Write("\n\nThe Transpose of a matrix is : ");
            for (i = 0; i < c; i++)
            {
                Console.Write("\n");
                for (j = 0; j < r; j++)
                {
                    Console.Write("{0}\t", brr1[i, j]);
                }
            }
            









        }



    }
}
