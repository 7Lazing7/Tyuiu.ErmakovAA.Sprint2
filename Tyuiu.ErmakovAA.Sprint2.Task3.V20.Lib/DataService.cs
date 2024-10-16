/*
 * Написать программу, которая вычисляет требуемое значение функции Y 
 * с использованием вложенных оператор if-else, 
 * где пользователь вводит значение переменной X с клавиатуры. 
 * Округлить полученное значение до трех знаков после запятой;
 */
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.ErmakovAA.Sprint2.Task3.V20.Lib
{
    public class DataService : ISprint2Task3V20
    {
        public double Calculate(double x)
        {
            double y = 0;

            if (x > 1)
            {
                y = x * Math.Pow(((x + 1) / (x - 1)), x);
            }
            else if (x == 0)
            {
                y = (Math.Pow(x, 2) - Math.Cos(Math.Pow(x, 2) + 10)) / (Math.Pow(x, 2) - Math.Sin(Math.Pow(x, 2) + 12));
            }
            else if ((x > -24) && (x < 2))
            {
                y = Math.Pow(1 + (1 / Math.Pow(x, 2)), 2);
            }
            else if (x < -24)
            {
                y = x + 10 * x - (1 / x);
            }

            return Math.Round(y, 3);
        }
    }
}


