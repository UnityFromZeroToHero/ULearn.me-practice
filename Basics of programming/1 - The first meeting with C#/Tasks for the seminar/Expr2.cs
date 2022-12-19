//Expr2. Задается натуральное трехзначное число (гарантируется, что трехзначное).
//Развернуть его, т.е. получить трехзначное число, записанное теми же цифрами в обратном порядке.
using System;

namespace Practice
{
    class Program
    {
        static void Main()
        {
            string? tripleDigitNumber = Console.ReadLine();

            if (tripleDigitNumber != null)
            {
                var reversedDigitNumber = ReverseString(tripleDigitNumber);
                Console.WriteLine(reversedDigitNumber);
            }
        }

        public static string ReverseString(string userString)
        {
            return new string(userString.Reverse().ToArray());
        }
    }
}
