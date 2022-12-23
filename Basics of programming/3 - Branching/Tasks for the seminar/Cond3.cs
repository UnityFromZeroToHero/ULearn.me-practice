//Дан номер трамвайного билета, в котором суммы первых трёх цифр и последних трёх цифр отличаются на 1 (но не сказано, в какую сторону).
//Правда ли, что предыдущий или следующий билет счастливый?
//https://acm.timus.ru/problem.aspx?num=1493

using System;

namespace Practice
{
    class Program
    {
        static void Main()
        {
            string ticketNumber = Console.ReadLine();

            if (isPreviousOrNextTicketLucky(ticketNumber))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }

        static bool isPreviousOrNextTicketLucky(string ticketNumber)
        {
            int firstHalfOfTicketNumber = Convert.ToInt32(ticketNumber.Substring(0, ticketNumber.Length/2));
            int secondHalfOfTicketNumber = Convert.ToInt32(ticketNumber.Substring(ticketNumber.Length/2));

            int firstHalfSum = calculateSumOfDigits(firstHalfOfTicketNumber, ticketNumber.Length);
            int secondHalfSum = calculateSumOfDigits(secondHalfOfTicketNumber, ticketNumber.Length);

            if (firstHalfSum == secondHalfSum - 1 ||
                firstHalfSum == secondHalfSum + 1)
            {
                return true;
            }

            return false;
        }

        static int calculateSumOfDigits(int number, int length)
        {
            int sum = 0;
            
            for (int i = 0; i < length; i++)
            {
                sum += number % (int)Math.Pow(10, i + 1) / (int)Math.Pow(10, i);
            }

            return sum;
        }
    }
}
