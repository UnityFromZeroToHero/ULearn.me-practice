//Нужно узнать пересекаются ли два прямоугольника? Если да, то вычислить площать их пересечения.
//Кроме того, нужно определить, находится ли один из них внутри другого. Если да. то вывести порядковый номер внутреннего (начиная с 0).


using System;
using System.Runtime.InteropServices;

namespace Rectangles
{
	public static class RectanglesTask
	{
		// Пересекаются ли два прямоугольника (пересечение только по границе также считается пересечением)
		public static bool AreIntersected(Rectangle r1, Rectangle r2)
		{
			// так можно обратиться к координатам левого верхнего угла первого прямоугольника: r1.Left, r1.Top

			if (Math.Max(r1.Left, r2.Left) <= Math.Min(r1.Right, r2.Right) && Math.Min(r1.Bottom, r2.Bottom) >= Math.Max(r1.Top, r2.Top))
			{
				return true;
			}

			return false;
		}

		// Площадь пересечения прямоугольников
		public static int IntersectionSquare(Rectangle r1, Rectangle r2)
		{
			if (AreIntersected(r1, r2))
			{
				int xInsertion = Math.Abs(Math.Max(r1.Left, r2.Left) - Math.Min(r1.Right, r2.Right));
				int yInsertion = Math.Abs(Math.Max(r1.Top, r2.Top) - Math.Min(r1.Bottom, r2.Bottom));

				return xInsertion * yInsertion;

            }

			return 0;
		}

		// Если один из прямоугольников целиком находится внутри другого — вернуть номер (с нуля) внутреннего.
		// Иначе вернуть -1
		// Если прямоугольники совпадают, можно вернуть номер любого из них.
		public static int IndexOfInnerRectangle(Rectangle r1, Rectangle r2)
		{
			if (r1.Left >= r2.Left && r1.Right <= r2.Right && r1.Top >= r2.Top && r1.Bottom <= r2.Bottom)
			{
				return 0;
			}
            else if (r1.Left <= r2.Left && r1.Right >= r2.Right && r1.Top <= r2.Top && r1.Bottom >= r2.Bottom)
			{
				return 1;
			}

			return -1;
		}
	}
}
