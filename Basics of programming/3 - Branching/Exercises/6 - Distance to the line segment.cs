//Даны координаты точки и координаты концов отрезка.
//Нужно найти расстояние от этой точки до отрезка.

using System;

namespace DistanceTask
{
	public static class DistanceTask
	{
		public static double GetDistanceToSegment(double ax, double ay, double bx, double by, double x, double y)
		{
			double eps = 1e-8;

			double lengthAB = Math.Sqrt((bx - ax)*(bx - ax) + (by - ay)*(by - ay));
			double lengthAC = Math.Sqrt((x - ax)*(x - ax) + (y - ay)*(y - ay));
			double lengthBC = Math.Sqrt((x - bx)*(x - bx) + (y - by)*(y - by));

			if (lengthAB != 0)
			{
				if (lengthAC*lengthAC + lengthAB*lengthAB >= lengthBC*lengthBC &&
					lengthAB*lengthAB + lengthBC*lengthBC >= lengthAC*lengthAC)
				{
					return Math.Abs((by - ay) * x - (bx - ax) * y + bx * ay - by * ax) /
						Math.Sqrt((by - ay)*(by - ay) + (bx - ax)*(bx - ax));
				}
				else if (Math.Abs(lengthAC + lengthBC - lengthAB) < eps)
				{
					return 0.0;
				}
			}	
			return Math.Min(lengthAC, lengthBC);
		}
    }
}
