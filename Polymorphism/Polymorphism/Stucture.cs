using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    public struct Structure
    {
        private double val;
        public double Value
        {
            get { return val; }
            set { val = value; }
        }
        public double Read()
        {
            return double.Parse(Console.ReadLine());
        }
    }
    public struct Square
    {
        Structure ln;
        Structure ht;

        public Structure Length
        {
            get { return ln; }
            set { ln = value; }
        }
        public Structure Breadth
        {
            get { return ht; }
            set { ht = value; }
        }
        public void newSquare()
        {
            Structure rct = new Structure();

            Console.WriteLine("\nInput the dimensions of the Square( equal length and breadth ) : ");
            ln = sqrLength();
            Console.Write("breadth : ");
            ht.Value = rct.Read();
        }
        public Structure sqrLength()
        {
            Structure rct = new Structure();

            Console.Write("length : ");
            rct.Value = rct.Read();
            return rct;
        }
    }
    public class strucExer10
    {
        static void Main()
        {
            Console.Write("\n\nMethod that returns a structure  :\n");           
            var Sqre = new Square();
            Sqre.newSquare();
            Console.WriteLine();
            Console.WriteLine("Perimeter and Area of the square :");
            Console.WriteLine("Length:    {0}", Sqre.Length.Value);
            Console.WriteLine("Breadth:    {0}", Sqre.Breadth.Value);
            Console.WriteLine("Perimeter: {0}", (Sqre.Length.Value + Sqre.Breadth.Value) * 2);
            Console.WriteLine("Area:      {0}\n", Sqre.Length.Value * Sqre.Breadth.Value);
        }
    }
}
