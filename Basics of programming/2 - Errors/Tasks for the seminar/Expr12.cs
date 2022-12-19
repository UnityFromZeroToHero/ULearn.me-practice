//Expr12. https://acm.timus.ru/problem.aspx?num=1084


using System;

namespace Practice
{
    class Programm
    {
        public static void Main()
        {
            string[] inputString = Console.ReadLine().Split(new Char[] {' '});

            int hightInMeters, timeInSeconds, allowedSpeedInMetersPerSecond, laidEarsSpeedInMetersPerSecond = 0;
            double laidEarsTimeInSecondsMin = 0.0;
            double laidEarsTimeInSecondsMax = 0.0;


            hightInMeters = int.Parse(inputString[0]);
            timeInSeconds = int.Parse(inputString[1]);
            allowedSpeedInMetersPerSecond = int.Parse(inputString[2]);
            laidEarsSpeedInMetersPerSecond = int.Parse(inputString[3]);

            int avarageSpeedInMinutesPerSecond = hightInMeters / timeInSeconds;

            if (avarageSpeedInMinutesPerSecond > laidEarsSpeedInMetersPerSecond)
            {
                laidEarsTimeInSecondsMax = timeInSeconds;

                laidEarsTimeInSecondsMin = calculateLaidEarsTimeInSecondsMin(hightInMeters, timeInSeconds, allowedSpeedInMetersPerSecond, laidEarsSpeedInMetersPerSecond);
            }
            else
            {
                laidEarsTimeInSecondsMin = 0.0;
                laidEarsTimeInSecondsMax = 0.0;
            }

            Console.WriteLine(laidEarsTimeInSecondsMin + " " + laidEarsTimeInSecondsMax);
        }

        public static double calculateLaidEarsTimeInSecondsMin(int h, int t, int v1, int v2)
        {
            double x = t;
            double y = 0;


            while (x * v2 + y * v1 < h)
            {
                double temp = (h - x * v2) / v1 - y;

                if (temp < 1 && temp % 10 != 0)
                {
                    temp = 1;
                }

                y += temp;
                x -= temp;
            }

            return y;
        }
    }
}
