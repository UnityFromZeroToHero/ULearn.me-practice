//Реализуйте метод для расчета угла отскока шарика от стены. 
//Считайте, что угол падения равен углу отражения, то есть можно пренебречь всеми физическими эффектами, связанными с кручением шаров, трением шара об стенку и т.п.

using System;

namespace Billiards
{
    public static class BilliardsTask
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="directionRadians">Угол направления движения шара</param>
        /// <param name="wallInclinationRadians">Угол</param>
        /// <returns></returns>
        public static double BounceWall(double directionRadians, double wallInclinationRadians)
        {
            //TODO
            return 2*wallInclinationRadians - directionRadians;
        }
    }
}
