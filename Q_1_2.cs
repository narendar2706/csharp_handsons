using System;

namespace cs_handsons
{
    class q2
    {
        static void Main()
        {
            double x;
            Console.WriteLine("Enter a Number");
            x = Convert.ToDouble(Console.ReadLine());

            double sq = FindSquare(x);
            Console.WriteLine("Square of "+x+" is "+sq);
            double cu = FindCube(x);            
            Console.WriteLine("Cube of "+x+" is "+cu);
        }
        static double FindSquare(double a)
        {
            double sq = a * a;
            return sq;

        }
        static double FindCube(double b)
        {
            double c = b * b * b;
            return c;
        }
    }
}
