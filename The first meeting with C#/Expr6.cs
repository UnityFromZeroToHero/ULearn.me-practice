//Expr6. Посчитать расстояние от точки до прямой, заданной двумя разными точками.

using System;
using System.Data;
using System.Net.NetworkInformation;

namespace Practice
{
    class Program
    {
        static void Main()
        {
            Point2D point = new Point2D(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
            Line line = new Line(new Point2D(Convert.ToInt32(Console.ReadLine()),Convert.ToInt32(Console.ReadLine())),
                new Point2D(Convert.ToInt32(Console.ReadLine()),Convert.ToInt32(Console.ReadLine())));

            int distanceBetweenLineAndPoint = DistanceBetweenLineAndPoint(point, line);
            
            Console.WriteLine(distanceBetweenLineAndPoint);
        }

        public static int DistanceBetweenLineAndPoint(Point2D point, Line line)
        {
            int x0 = point.GetX();
            int y0 = point.GetY();

            int x1 = line.GetPoint1().GetX();
            int y1 = line.GetPoint1().GetY();
            int x2 = line.GetPoint2().GetX();
            int y2 = line.GetPoint2().GetY();

            return Math.Abs((y2 - y1) * x0 - (x2 - x1) * y0 + x2 * y1 - y2 * x1) / (int)Math.Sqrt((int)Math.Pow(y2 - y1, 2) + (int)Math.Pow(x2 - x1, 2));
        }
    }

    class Point2D
    {
        private int _x;
        private int _y;

        public Point2D(int x, int y)
        {
            _x = x;
            _y = y;
        }

        
        public void SetX(int x)
        {
            _x = x;
        }

        public int GetX()
        {
            return _x;
        }
        
        public void SetY(int y)
        {
            _y = y;
        }

        public int GetY()
        {
            return _y;
        }
    }

    class Line
    {
        private Point2D _point1;
        private Point2D _point2;
        
        public Line(Point2D point1, Point2D point2)
        {
            _point1 = point1;
            _point2 = point2;
        }
        

        public void SetPoint1(Point2D point1)
        {
            _point1 = point1;
        }

        public Point2D GetPoint1()
        {
            return _point1;
        }
        
        public void SetPoint2(Point2D point2)
        {
            _point2 = point2;
        }

        public Point2D GetPoint2()
        {
            return _point2;
        }
    }
}
