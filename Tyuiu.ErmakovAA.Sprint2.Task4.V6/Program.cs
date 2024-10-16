using Tyuiu.ErmakovAA.Sprint2.Task4.V6.Lib;
namespace Tyuiu.ErmakovAA.Sprint2.Task4.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
           DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполгил: Ермаков А.А. | ПКТб-24-1";
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Спринт #2                                                                    *");
            Console.WriteLine("* Тема: Создание итогового решения по спринту                                  *");
            Console.WriteLine("* Задание #4                                                                   *");
            Console.WriteLine("* Вариант #6                                                                   *");
            Console.WriteLine("* Выполгил: Ермаков А.А.                                                       *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                     *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение с использованием    *");
            Console.WriteLine("* тернарного оператора, где пользоваьель вводит значение переменных x,y        *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
            Console.WriteLine("********************************************************************************");

            Console.WriteLine("Введите значение X: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение Y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            double res = ds.Calculate(x,y);

            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                   *");
            Console.WriteLine("********************************************************************************");

            Console.WriteLine("Значение функции - " + res);

            Console.ReadLine();
        }
    }
}
