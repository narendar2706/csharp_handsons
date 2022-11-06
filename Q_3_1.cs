using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1		
{
    public class enquiry   
    {
       
        static Dictionary<string, DateTime> flightSchedule = new Dictionary<string, DateTime>(){
                                                        {"A380", Convert.ToDateTime("10:45:00")},
                                                        {"B777", Convert.ToDateTime("12:30:30")},
                                                        {"VT123", Convert.ToDateTime("18:20:00")}};

        public static void Main(string[] args)   
        {
            //Implement your code here
            string flightNumber;
            string timeLeft;

            Console.WriteLine("Enter the Flight Number :");
            flightNumber = Console.ReadLine();

            timeLeft = flightStatus(flightNumber);
            Console.WriteLine(timeLeft);
        }

        public static string flightStatus(string flightNo)  
        {
            
            if (flightSchedule.ContainsKey(flightNo))
            {
                DateTime departureTime = flightSchedule[flightNo];
                if (DateTime.UtcNow < departureTime)
                {
                    TimeSpan ts = departureTime.Subtract(DateTime.UtcNow);
                    return "Time to flight " + ts.ToString();
                }
                else
                    return "Flight Already Left";
            }
            else
                return "Invalid Flight Number";
        }
    }
}
