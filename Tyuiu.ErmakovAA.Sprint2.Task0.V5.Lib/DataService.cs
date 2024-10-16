/* Task
* Написать программу из операций сравнений (==, !=, <, >, <=, >=, 
* последовательность операций не должна нарушаться) и арифметических выражений,
* которая вернет логическую последовательность(массив): 
* ((False, True, True, True, False, True), при x = 105, y = 223
*/
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.ErmakovAA.Sprint2.Task0.V5.Lib
{
    public class DataService : ISprint2Task0V5
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];

            res[0] = x == y;
            res[1] = x != y;
            res[2] = x < y;
            res[3] = x + 200 > y;
            res[4] = x + 300 <= y;
            res[5] = x + 118 >= y;


            return res;




        }
    }
}