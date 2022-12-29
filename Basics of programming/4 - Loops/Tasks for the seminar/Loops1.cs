//Loops1.Дано целое неотрицательное число N.
//Найти число, составленное теми же десятичными цифрами, что и N, но в обратном порядке.
//Запрещено использовать массивы.


using System;
using System.Net.Http.Headers;

namespace Practice
{
    class Programm
    {
        public static void Main()
        {
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(ReverseNumber(number));
        }

        public static int ReverseNumber(int number)
        {
            int reversedNumber = 0;

            while (number != 0)
            {
                reversedNumber = reversedNumber * 10 + number % 10;
                number = number / 10;
            }

            return reversedNumber;
        }
    }
}
