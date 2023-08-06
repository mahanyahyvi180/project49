using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ConsoleApp49
{
    class TimeExtensionsTest
    {
        static void Main(string[] args)
        {
            var myTime = new Time2();
             myTime.SetTime(11, 34, 15);

            Console.Write("Use the DisplayTime extension method:");
             myTime().DisplayTime();

            Console.Write("Add 5 hours with the AddHours extension method:");

            var timeAdded = new Time2().AddHours(5);
            timeAdded.DisplayTime();

            Console.Write("Add 15 hour with the AddHours extension method:");
             myTime().AddHours(15);

            Console.Write("Use fully qualified extension-method name:");
            TimeExtensions.DisplayTime(new Time2());
        
        }
    }

    static class TimeExtensions
    {
        public static void DisplayTime(this Time2 aTime)
        {
            Console.WriteLine(aTime.ToString());
        }

        public static Time2 AddHour(this Time2 aTime, int hours)
        {
            var newTime = new Time2()
            {

                Minute = aTime.Minute,
                Second = aTime.Second
            };

            newTime.Hour = (aTime.Hour + hours) % 24;

            return newTime;
        }
    }
}
