//Expr5. Найти количество високосных лет на отрезке [a, b] не используя циклы.

using System;

namespace Practice
{
    class Program
    {
        static void Main()
        {
            int a, b = default;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());

            int numberOfLeapYears = 0;
            if (a % 4 == 0 || b % 4 == 0)
            {
                numberOfLeapYears = (b - a) / 4 + 1;
            }
            else
            {
                numberOfLeapYears = (b - a + 1) / 4;
            }
            Console.WriteLine(numberOfLeapYears);
        }
    }
}
