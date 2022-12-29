//Loops3. Если все числа натурального ряда записать подряд каждую цифру в своей позиции, то необходимо ответить на вопрос: какая цифра стоит в заданной позиции N.


using System;
using System.Net.Http.Headers;

namespace Practice
{
    class Programm
    {
        public static void Main()
        {
            int position = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(FindDigitAtPosition(position));
        }

        public static int FindDigitAtPosition(int position)
        {
            string numberString = null;

            for (int i = 0; i < position+1; i++)
            {
                numberString += i.ToString();
            }

            return Convert.ToInt32(numberString[position].ToString());
        }
    }
}
