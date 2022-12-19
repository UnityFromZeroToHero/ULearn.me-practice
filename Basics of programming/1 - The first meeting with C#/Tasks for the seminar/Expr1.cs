//Expr1. Как поменять местами значения двух переменных?
//Можно ли это сделать без ещё одной временной переменной?
//Стоит ли так делать?

using System;

namespace Practice
{
    class Program
    {
        static void Main()
        {
            int firstVariable = 2;
            int secondVariable = 5;

            //Exchange of values of two variables by using the 3rd one.
            int thirdVariable = firstVariable;
            firstVariable = secondVariable;
            secondVariable = thirdVariable;
            
            //Exchange of values of two variables without using the 3rd one.
            (firstVariable, secondVariable) = (secondVariable, firstVariable);
        }
    }
}
