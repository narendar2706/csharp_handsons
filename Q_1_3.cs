using System;


namespace cs_handsons
{
    class Q3
    {
        static void Main()
        {
            int x, y;
            Boolean b;
            Console.WriteLine("Enter a Number");
            x = Convert.ToInt32(Console.In.ReadLine());
            y = Convert.ToInt32(Console.In.ReadLine());
            if (x < y)
            {
                b = true;
            }
            else
            {
                b = false;
            }
            Console.WriteLine("The result of whether x is less than y is "+b);
        }
    }
}
