//Expr8. Дана прямая L и точка A.
//Найти точку пересечения прямой L с перпендикулярной ей прямой P, проходящей через точку A.
//Прямая заданна в виде y = kx + b.

using System;
using System.Drawing;

namespace Practice
{
    class Program
    {
        static void Main()
        {
            string[] inputStream = Console.ReadLine().Split();
            
            Point2D pointA = new Point2D(Convert.ToDouble(inputStream[0]), Convert.ToDouble(inputStream[1]));
            Line lineL = new Line(Convert.ToDouble(inputStream[2]), Convert.ToDouble(inputStream[3]));

            Line lineP = CalculateEquationOfPerpendicularLine(pointA, lineL);
            Point2D pointB = FindInsertionPoint2D(lineL, lineP);
            
            Console.WriteLine(pointB.GetX() + " " + pointB.GetY());
        }

        public static Line CalculateEquationOfPerpendicularLine(Point2D pointA, Line lineL)
        {
            double K = -1 / lineL.GetK();
            double B = K * -pointA.GetX() + pointA.GetY();
            
            return new Line(K, B);
        }
        
        public static Point2D FindInsertionPoint2D(Line lineL, Line lineP)
        {
            double X = (lineP.GetB() - lineL.GetB()) / (lineL.GetK() - lineP.GetK());
            double Y = lineL.GetK() * X + lineL.GetB();

            return new Point2D(X, Y);
        }
    }

    class Point2D
    {
        private double _x;
        private double _y;

        public Point2D(double x, double y)
        {
            _x = x;
            _y = y;
        }

        
        public void SetX(double x)
        {
            _x = x;
        }

        public double GetX()
        {
            return _x;
        }
        
        public void SetY(double y)
        {
            _y = y;
        }

        public double GetY()
        {
            return _y;
        }
    }

    public class Line
    {
        private double _K;
        private double _B;

        public Line(double K, double B)
        {
            _K = K;
            _B = B;
        }
        
        
        public void SetK(double K)
        {
            _K = K;
        }

        public double GetK()
        {
            return _K;
        }
        
        public void SetB(double B)
        {
            _B = B;
        }

        public double GetB()
        {
            return _B;
        }
    }
}
