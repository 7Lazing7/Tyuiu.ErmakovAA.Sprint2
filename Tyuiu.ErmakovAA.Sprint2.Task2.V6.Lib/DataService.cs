/*
 * Написать программу на, которая запрашивает целые значения с клавиатуры
 * и вычисляет находится ли точка с координатами X,Y в заштрихованной области.
 */

using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.ErmakovAA.Sprint2.Task2.V6.Lib
{
    public class DataService : ISprint2Task2V6
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;

            if ((x >= 3) && (x <= 5) && (y >= 3) && (y <= 7)) 
            {
                res = true;
            }
            else if ((x >= 6) && (x <= 10) && (y >= 5) && (y <= 7))
            {
                res = true; 
            }
            else if ((x >= 6) && (x <= 9) && (y >= 8) && (y <= 11))
            {
                res = true;
            }
            else if ((x == 9) && (y >= 3) && (y <= 12))
            {
                res = true;
            }
            else if ((x >= 3) && (x <= 12) && (x >= 7) && (x <= 10) && (y >= 11) && (y <= 12))
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }
    }
}
