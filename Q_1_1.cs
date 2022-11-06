using System;

namespace cs_handsons
{
    class q1
    {
        static void Main(string[] args)
        {
            string name, country;
            int age;
            Console.Write("Enter Your Name:");
            name = Console.ReadLine();
            Console.Write("Enter Your Age:");
            age = Convert.ToInt32(Console.In.ReadLine());
            Console.Write("Enter Your Country:");
            country = Console.ReadLine();

            Console.WriteLine("Welcome "+name+". Your age is "+age+" and you are from "+country);


        }
    }
}
