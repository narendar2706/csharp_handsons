using System;
using System.Collections.Generic;
using System.Text;

namespace cs_handson
{
    class Q5
    {
        static void Main(string[] args)
        {
            int pizza, puff, pepsi, t_pizaa, t_puff, t_pepsi, grand_total;
            float gst, cess, gp;
            Console.WriteLine("Enter the no of Pizzas ordered:");
            pizza = Convert.ToInt32(Console.In.ReadLine());
            Console.WriteLine("Enter the no of Puffs ordered:");
            puff = Convert.ToInt32(Console.In.ReadLine());
            Console.WriteLine("Enter the no of Pepsi ordered:");
            pepsi = Convert.ToInt32(Console.In.ReadLine());
            t_pizaa = 200 * pizza;
            t_puff = 40 * puff;
            t_pepsi = 120 * pepsi;
            grand_total = t_pizaa + t_puff + t_pepsi;
            gst = (12 / 100.00F) * grand_total;
            cess = (5 / 100.00F) * grand_total;
            gp = gst + cess + grand_total;
            Console.WriteLine($"Cost of Pizzas : {t_pizaa}");
            Console.WriteLine($"Cost of Puffs : {t_puff}");
            Console.WriteLine($"Cost of Pepsi : {t_pepsi}");
            Console.WriteLine($"GST 12% : {gst}");
            Console.WriteLine($"Cess 5% : {cess}");
            Console.WriteLine($"Total Price : {grand_total}");
            Console.WriteLine($"Gross Price : {gp}");
        }
    }
}
