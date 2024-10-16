using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.ErmakovAA.Sprint2.Task7.V1.Lib
{
    public class DataService : ISprint2Task7V1
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool condition1 = (Math.Pow(x, 2) + Math.Pow(y, 2)) <= 1;
            bool condition2 = condition1 & (y >= -x) & (y >= x);
            if (condition1 && condition2)
            {
                return true;
            }
            return false;
        }
    }
}