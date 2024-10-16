using Tyuiu.ErmakovAA.Sprint2.Task3.V20.Lib;
namespace Tyuiu.ErmakovAA.Sprint2.Task3.V20
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
            Console.WriteLine("* Задание #3                                                                   *");
            Console.WriteLine("* Вариант #20                                                                  *");
            Console.WriteLine("* Выполгил: Ермаков А.А.                                                       *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                     *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение функции Y           *");
            Console.WriteLine("* с использованием вложенных оператор if-else,                                 *");
            Console.WriteLine("* где пользователь вводит значение переменной X с клавиатуры.                  *");
            Console.WriteLine("* Округлить полученное значение до трех знаков после запятой;                  *");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
            Console.WriteLine("********************************************************************************");

            Console.WriteLine("Введите значение X: ");
            double x = Convert.ToDouble(Console.ReadLine());
            double res = ds.Calculate(x);

            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                   *");
            Console.WriteLine("********************************************************************************");

            Console.WriteLine("Значение функции - " + res);

            Console.ReadLine();
        }
    }
}
