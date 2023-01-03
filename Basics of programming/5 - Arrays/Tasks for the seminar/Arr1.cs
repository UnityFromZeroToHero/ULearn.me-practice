//Arr1. Дан массив чисел. Нужно его сдвинуть циклически на K позиций влево, не используя других массивов.


//Arr1. Дан массив чисел. Нужно его сдвинуть циклически на K позиций влево, не используя других массивов.


using System;
using System.Linq;
using System.Net.Http.Headers;
using System.Xml.Serialization;

namespace Practice
{
    class Programm
    {
        public static void Main()
        {
            Console.Write("Enter the size of the array: ");
            int sizeOfArray = Convert.ToInt32(Console.ReadLine());

            int[] arrayOfNumbers = new int[sizeOfArray];

            for (int i = 0; i < sizeOfArray; i++)
            {
                Console.Write("Enter the " + i + " element: ");
                arrayOfNumbers[i] = Convert.ToInt32((Console.ReadLine()));
            }

            Console.WriteLine("Enter K");
            int k = Convert.ToInt32(Console.ReadLine());

            MoveArrayToTheLeft(arrayOfNumbers, k);

            Array.ForEach(arrayOfNumbers, x => Console.Write(x + " "));
        }

        public static void MoveArrayToTheLeft(int[] array, int k)
        {
            int temp1 = array[array.Length - 1];
            int temp2 = 0;

            for (int j = 0; j < k; j++)
            {
                for (int i = array.Length - 1; i > 0; i--)
                {
                    temp2 = array[i - 1];
                    array[i - 1] = temp1;
                    temp1 = temp2;
                }

                array[array.Length - 1] = temp1;
            }
        }
    }
}
