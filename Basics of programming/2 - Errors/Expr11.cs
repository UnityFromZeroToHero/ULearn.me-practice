//Expr11. Дано время в часах и минутах. Найти угол от часовой к минутной стрелке на обычных часах.

using System;

namespace Practice
{
    class Program
    {
        static void Main()
        {
            int hours = Convert.ToInt32(Console.ReadLine());
            int minutes = Convert.ToInt32(Console.ReadLine());
            
            const int angleBetweenTwoMinutes = 360 / (12 * 5);
            const int numberOfMinutesInHour = 60;

            double angleBetweenHourAndMinuteHands = 0;

            double hoursInMinutesOnClock = 0;
            if (hours >= 12)
            {
                hoursInMinutesOnClock = (hours - 12) * 5 + minutes / 12;
            }
            else
            {
                hoursInMinutesOnClock = hours * 5 + minutes / 12;
            }

            angleBetweenHourAndMinuteHands = Math.Abs(hoursInMinutesOnClock - minutes) * angleBetweenTwoMinutes;

            if (angleBetweenHourAndMinuteHands > 180)
            {
                angleBetweenHourAndMinuteHands = 360 - angleBetweenHourAndMinuteHands;
            }
            
            Console.WriteLine(angleBetweenHourAndMinuteHands);

        }
    }
}
