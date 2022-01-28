using System;

namespace FirstConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            int first, second;
            int operation;
           
            Console.WriteLine("Please Enter first number:");
            first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter second number:");
            second = Convert.ToInt32(Console.ReadLine());


                                                                       
            Console.WriteLine("Press 1 for Addition\npress 2 for Subtraction\npress 3 for Division\npress 4 for Multiplication");
            operation = Convert.ToInt32(Console.ReadLine());


            switch (operation)
            {
                case 1:
                    Console.WriteLine(first + second);
                    
                    break;

                case 2:
                    Console.WriteLine(first + second);

                    break;

                case 3:
                    Console.WriteLine(first /second);
                    break;

                case 4:
                    Console.WriteLine(first * second);
                    break;


                default:
                    Console.WriteLine("Please enter a valid operation");
                    break;
            }













            /*
            int age;
            Console.WriteLine("Please enter your age:");
            age = Convert.ToInt32(Console.ReadLine());
            if(age>18 && age > 60)
            {
                Console.WriteLine("This person is a senior citizen");

            }
            else if(age >= 18 )
            {
                Console.WriteLine("You are elgible to vote");

            }
            else if (age < 18)
            {
                Console.WriteLine("You are not eligible to vote");
            }
                 
            */



            /*
            int a, b, temp;
            Console.WriteLine("Please enter the value for a:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the value for b:");
            b = Convert.ToInt32(Console.ReadLine());


            if(a > b)
            {
                Console.WriteLine(" a is greater than b");
            }
            else
            {
                Console.WriteLine("a is not greater than b ");
            }
            Console.WriteLine("Before swapping the Values are {0}, {1}", a, b);
            temp = b;
            b = a;
            a = temp;
            Console.WriteLine("After swapping the values are {0},{1}", a, b);
            */

        }
    }
}
