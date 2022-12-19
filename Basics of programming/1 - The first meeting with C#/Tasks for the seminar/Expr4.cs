//Expr4. Найти количество чисел меньших N, которые имеют простые делители X или Y.

using System;

namespace Practice
{
    class Program
    {
        static void Main()
        {
            int N, X, Y = default;
            N = Convert.ToInt32(Console.ReadLine());
            X = Convert.ToInt32(Console.ReadLine());
            Y = Convert.ToInt32(Console.ReadLine());

            int counter = 0;
            for (int i = N; i > 0; i--)
            {
                if (i % X == 0 || i % Y == 0)
                {
                    counter++;
                }
            }
            
            Console.WriteLine(counter);
        }
    }
}
