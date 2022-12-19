//На ход в одну строку поступает исходная сумма, процентная ставка (в процентах) и срок вклада в месяцах.
//Нужно написать функцию, которая рассчитывает итоговую сумму денег, которуб получит пользователь по истечению срока вклада.
//НА вход поступает строка - одно из условий :(

public static double CalculateFinalSum(string userInput)
	{
		double amountOfMoney, interestRate, depositTermInMonths;
	
        amountOfMoney = double.Parse(userInput.Split()[0] , System.Globalization.CultureInfo.InvariantCulture);
        interestRate = double.Parse(userInput.Split()[1] , System.Globalization.CultureInfo.InvariantCulture);
        depositTermInMonths = double.Parse(userInput.Split()[2] , System.Globalization.CultureInfo.InvariantCulture);
            
        amountOfMoney *= Math.Pow(1 + interestRate / (12 * 100), depositTermInMonths);
            
        return amountOfMoney;
    }
