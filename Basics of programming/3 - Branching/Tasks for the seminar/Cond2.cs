//Cond2. Пролезет ли брус со сторонами x, y, z в отверстие со сторонами a, b,
//если его разрешается поворачивать на 90 градусов?

using System;

namespace Practice
{
    class Program
    {
        static void Main()
        {
            string[] inputString = Console.ReadLine().Split();
            
            int x = Convert.ToInt32(inputString[0]);
            int y = Convert.ToInt32(inputString[1]);
            int z = Convert.ToInt32(inputString[2]);

            inputString = Console.ReadLine().Split();
            
            int a = Convert.ToInt32(inputString[0]);
            int b = Convert.ToInt32(inputString[1]);

            Console.WriteLine(isBalkFit(x,y,z,a,b));
        }

        static bool isBalkFit(int x, int y, int z, int a, int b)
        {
            if (x <= a && y <= b || x <= b && y <= a)
            {
                return true;
            }

            return false;
        }
    }
}
