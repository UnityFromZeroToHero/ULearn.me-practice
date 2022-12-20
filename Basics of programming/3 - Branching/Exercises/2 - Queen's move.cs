//В функцию подаются две строки - начальная клетка и конечная клетка. Формат - 'a1', 'b3' и тд.
//Функция определяет возможен такой ход ферзём или нет.

public static bool IsCorrectMove(string from, string to)
{
    var dx = Math.Abs(to[0] - from[0]); //смещение фигуры по горизонтали
    var dy = Math.Abs(to[1] - from[1]); //смещение фигуры по вертикали
    return (dx == 0 && dy == 0) ? false : (dx == dy) ? true : (dx == 0 || dy == 0 ? true : false);
}
