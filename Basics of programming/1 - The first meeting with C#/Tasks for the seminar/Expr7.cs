//Expr7. Найти вектор, параллельный прямой. Перпендикулярный прямой. Прямая задана коэффициентами уравнения прямой.

using System;
using System.Data;
using System.Net.NetworkInformation;
using System.Reflection.Metadata.Ecma335;

namespace Practice
{
    class Program
    {
        static void Main()
        {
            Line line = new Line(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
            Vector directingVector = FindDirectingVector(line);
            Vector normalVector = FindNormalVector(line);
                
            directingVector.PrintVector();
            normalVector.PrintVector();
        }

        public static Vector FindDirectingVector(Line line)
        {
            return new Vector(new Point2D(-line.GetB(), line.GetA()));
        }

        public static Vector FindNormalVector(Line line)
        {
            return new Vector(new Point2D(line.GetA(), line.GetB()));
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
        private int _A;
        private int _B;
        private int _C;
        
        public Line(int A, int B, int C)
        {
            _A = A;
            _B = B;
            _C = C;
        }
        
        public void SetA(int A)
        {
            _A = A;
        }

        public int GetA()
        {
            return _A;
        }
        
        public void SetB(int B)
        {
            _B = B;
        }

        public int GetB()
        {
            return _B;
        }
        
        public void SetC(int C)
        {
            _C = C;
        }

        public int GetC()
        {
            return _C;
        }
    }

    class Vector
    {
        private Point2D _vector;

        public Vector(Point2D vector)
        {
            _vector = vector;
        }

        public void PrintVector()
        {
            Console.WriteLine("(" + _vector.GetX() + ", " + _vector.GetY() + ")");
        }
        
        public void SetVector(Point2D vector)
        {
            _vector.SetX(vector.GetX());
            _vector.SetY(vector.GetY());
        }
        
        public Point2D SetVector()
        {
            return _vector;
        }
    }
}
