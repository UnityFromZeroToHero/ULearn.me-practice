//Expr3. Задано время Н часов (ровно).
//Вычислить угол в градусах между часовой и минутной стрелками.
//Например, 5 часов -> 150 градусов, 20 часов -> 120 градусов. Не использовать циклы.

using System;

namespace Practice
{
    class Program
    {
        static void Main()
        {
            int hours = Convert.ToInt32(Console.ReadLine());
            
            const int maxClockHours = 12;
            const int maxCircleDegrees = 360;
            const int triangleBetweenTwoClockSectors = maxCircleDegrees / maxClockHours;

            if (hours > maxClockHours)
            {
                hours -= maxClockHours;
            }

            int triangleBetweenUserHourHandAndMinuteHand = 0;
            if (hours * triangleBetweenTwoClockSectors < 180)
            {
                triangleBetweenUserHourHandAndMinuteHand = hours * triangleBetweenTwoClockSectors;
            }
            else
            {
                triangleBetweenUserHourHandAndMinuteHand = maxCircleDegrees - hours * triangleBetweenTwoClockSectors;
            }
            
            Console.WriteLine(triangleBetweenUserHourHandAndMinuteHand);
        }
    }
}
