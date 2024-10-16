using Tyuiu.ErmakovAA.Sprint2.Task5.V14.Lib;
namespace Tyuiu.ErmakovAA.Sprint2.Task5.V14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("Введите номер дня от 1 до 365: ");
            int Day = Convert.ToInt32(Console.ReadLine());

            string res;
            if ((Day < 1) || (Day > 365))
            {
                res = "Введено неверное значение!";
            }
            else
            {
                res = "Это день недели:" + ds.FindDayName(Day);
            }
            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}
