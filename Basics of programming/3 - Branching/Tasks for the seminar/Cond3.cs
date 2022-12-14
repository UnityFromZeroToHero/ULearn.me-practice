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
            
            Console.WriteLine(isPreviousOrNextTicketLucky(ticketNumber));
        }

        static bool isPreviousOrNextTicketLucky(string ticketNumber)
        {
            int firstHalfOfTicketNumber = Convert.ToInt32(ticketNumber.Substring(0, ticketNumber.Length/2));
            int secondPartOfPreviousTicketNumber = Convert.ToInt32(ticketNumber.Substring(ticketNumber.Length/2)) - 1;
            int secondPartOfNextTicketNumber = Convert.ToInt32(ticketNumber.Substring(ticketNumber.Length/2)) + 1;

            int firstHalfSum = calculateSumOfDigits(firstHalfOfTicketNumber, ticketNumber.Length);
            int secondHalfPreviousSum = calculateSumOfDigits(secondPartOfPreviousTicketNumber, ticketNumber.Length);
            int secondHalfNextSum = calculateSumOfDigits(secondPartOfNextTicketNumber, ticketNumber.Length);

            if (firstHalfSum == secondHalfPreviousSum ||
                firstHalfSum == secondHalfNextSum)
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
