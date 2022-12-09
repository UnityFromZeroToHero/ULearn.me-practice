//Expr10. Найти сумму всех положительных чисел меньше 1000 кратных 3 или 5.

using System;

namespace Practice
{
    class Program
    {
        static void Main()
        {
            int sumOfNumbers = 0;
            int amountOfNumbers = 1000;

            for (int i = 0; i < amountOfNumbers; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sumOfNumbers += i;
                }
            }
            
            Console.WriteLine(sumOfNumbers);
        }
    }
}
