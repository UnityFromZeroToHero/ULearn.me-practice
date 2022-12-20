//На вход функции подаётся одно число - количество рублей.
//Функция должна его обработать и вывести грамматически подходящее слово: рубль, рубля или рублей.

using System;

namespace Pluralize
{
	public static class PluralizeTask
	{
		public static string PluralizeRubles(int count)
		{
			int lastNumber = count % 10;

			if (count % 100 / 10 != 1)
			{
				if (lastNumber == 1)
				{
					return "рубль";
				}
				else if (lastNumber > 1 && lastNumber < 5)
				{
					return "рубля";
				}
			}

			return "рублей";
		}
	}
}
