/*
 *Написать программу из операций сравнений
 *(==, !=, <, >, <=, >=, последовательность можно чередовать, 
 *но использовать один раз в выражении) и логических операций 
 *(|, &, ||, &&, !, ^, последовательность операций не должна нарушаться), 
 *а также арифметических выражений, которая вернет логическую последовательность(массив): 
 *(True, False, True, False, True, False), при a = 247, b = 155, c = 325, d = 857
 */


using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.ErmakovAA.Sprint2.Task1.V25.Lib
{
    public class DataService : ISprint2Task1V25
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            res[0] = (a == b) | (c < d);
            res[1] = (a != b) & (c >= d);
            res[2] = (a <= b) || (c < d);
            res[3] = (a == b) && (c <= d);
            res[4] = !(!res[0]);
            res[5] = (a == b) ^ (c > d);


            return res;
        }
    }
}
