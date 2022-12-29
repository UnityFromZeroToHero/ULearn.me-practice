//Loops2.Дано N(1 ≤ N ≤ 27).
//Найти количество трехзначных натуральных чисел, сумма цифр которых равна N.
//Операции деления (/, %) не использовать.


using System;
using System.Net.Http.Headers;

namespace Practice
{
    class Programm
    {
        public static void Main()
        {
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(FindTheAmountOfThreeDigitNaturalNumbers(number));
        }

        public static int FindTheAmountOfThreeDigitNaturalNumbers(int number)
        {
            int count = 0;

            for (int i = 100; i < 1000; i++)
            {
                if (SunOfDigits(i) == number)
                {
                    count++;
                }
            }

            return count;
        }

        public static int SunOfDigits(int number)
        {
            int sum = 0;

            while (number != 0)
            {
                sum += number % 10;
                number /= 10;
            }

            return sum;
        }
    }
}
