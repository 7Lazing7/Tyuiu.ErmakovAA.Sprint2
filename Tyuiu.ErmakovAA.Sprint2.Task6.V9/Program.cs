using Tyuiu.ErmakovAA.Sprint2.Task6.V9.Lib;
namespace Tyuiu.ErmakovAA.Sprint2.Task6.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите номер дня: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите порядковый номер месяца: ");
            int y = Convert.ToInt32(Console.ReadLine());

            string res;
            if ((y < 1) || (y > 12))
            {
                res = "Введено неверное значение!";
            }
            else
            {
                res = "Дата следующего дня: " + ds.FindDateOfNextDay(x + 1, y - 1);
            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}