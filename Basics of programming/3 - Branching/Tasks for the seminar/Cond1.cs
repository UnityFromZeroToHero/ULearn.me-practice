//Cond1. Дана начальная и конечная клетки на шахматной доске.
//Корректный ли это ход на пустой доске для: слона, коня, ладьи, ферзя, короля?

using System;

namespace Practice
{
    class Program
    {
        static void Main()
        {
            string startPosition = Console.ReadLine();
            string finishPosition = Console.ReadLine();

            if (startPosition == finishPosition)
            {
                Console.WriteLine("Start position coincides with the finish one!");
                return;
            }
            
            Console.WriteLine(isThisTheLegalMoveForBishop(startPosition, finishPosition));
            Console.WriteLine(isThisTheLegalMoveForKnight(startPosition, finishPosition));
            Console.WriteLine(isThisTheLegalMoveForRook(startPosition, finishPosition));
            Console.WriteLine(isThisTheLegalMoveForQueen(startPosition, finishPosition));
            Console.WriteLine(isThisTheLegalMoveForKing(startPosition, finishPosition));
        }

        static bool isThisTheLegalMoveForBishop(string start, string finish)
        {
            int dx = Math.Abs(finish[0] - start[0]); //Смещение фигуры по горизонтали
            int dy = Math.Abs(finish[1] - start[1]); //Смещение фигуры по вертикали
            
            if (dx == dy)
            {
                return true;
            }

            return false;
        }
        
        static bool isThisTheLegalMoveForKnight(string start, string finish)
        {
            int dx = Math.Abs(finish[0] - start[0]); //Смещение фигуры по горизонтали
            int dy = Math.Abs(finish[1] - start[1]); //Смещение фигуры по вертикали
            
            if (dx == 1 && dy == 2 || dx == 2 && dy == 1)
            {
                return true;
            }

            return false;
        }
        
        static bool isThisTheLegalMoveForRook(string start, string finish)
        {
            if (start[0] == finish[0] || start[1] == finish[1])
            {
                return true;
            }

            return false;
        }
        
        
        static bool isThisTheLegalMoveForQueen(string start, string finish)
        {
            var dx = Math.Abs(finish[0] - start[0]); //смещение фигуры по горизонтали
            var dy = Math.Abs(finish[1] - start[1]); //смещение фигуры по вертикали

            if (dx == dy || dx == 0 || dy == 0)
            {
                return true;
            }

            return false;
        }
        
        static bool isThisTheLegalMoveForKing(string start, string finish)
        {
            var dx = Math.Abs(finish[0] - start[0]); //смещение фигуры по горизонтали
            var dy = Math.Abs(finish[1] - start[1]); //смещение фигуры по вертикали

            if (dx == 1 && dy == 0 || dx == 0 && dy == 1)
            {
                return true;
            }

            return false;
        }
    }
}
