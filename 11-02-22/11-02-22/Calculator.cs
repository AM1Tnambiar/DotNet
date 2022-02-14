using System;

namespace _11_02_22
{
    class Calculator
    {
        delegate double ArithmeticDelegate(double x, double y);

        static void Menu()
        {
            Console.WriteLine("Select an arithmetic operation");
            Console.WriteLine("1)Addition");
            Console.WriteLine("2)Subtraction");
            Console.WriteLine("3)Multiplication");
            Console.WriteLine("4)Division");
            Console.WriteLine("5)Remainder");
            Console.WriteLine("6)Quit");
        }

        static double Add(double a, double b)
        {
            return a + b;
        }

        static double Subtract(double a, double b)
        {
            return a - b;
        }

        static double Multiply(double a, double b)
        {
            return a * b;
        }

        static double Divide(double a, double b)
        {
            return a / b;
        }

        static double Modulus(double a, double b)
        {
            return a % b;
        }

        static void Main(string[] args)
        {
            int operation;
            ArithmeticDelegate arithmetic;
            double x, y;

            do
            {
                Console.WriteLine("Enter two numbers seperated by Enter");
                x = double.Parse(Console.ReadLine());
                y = double.Parse(Console.ReadLine());
                Console.Clear();

                Menu();
                operation = int.Parse(Console.ReadLine());

                switch (operation)
                {
                    //Addition
                    case 1:
                        arithmetic = new ArithmeticDelegate(Add);
                        break;
                    //Subtraction
                    case 2:
                        arithmetic = new ArithmeticDelegate(Subtract);
                        break;
                    //Multiplication
                    case 3:
                        arithmetic = new ArithmeticDelegate(Multiply);
                        break;
                    //Division
                    case 4:
                        arithmetic = new ArithmeticDelegate(Divide);
                        break;
                    //Remainder
                    case 5:
                        arithmetic = new ArithmeticDelegate(Modulus);
                        break;
                    default:
                        Console.WriteLine("Exiting program");
                        break;
                }
                Console.Clear();
                Console.WriteLine(arithmetic(x, y));
                Console.WriteLine("Press any key to continue");
                Console.ReadKey(true);
                Console.Clear();

            } while (operation != 6);

        }
    }
}
