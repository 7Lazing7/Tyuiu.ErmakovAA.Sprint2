using Tyuiu.ErmakovAA.Sprint2.Task0.V5.Lib;
namespace Tyuiu.ErmakovAA.Sprint2.Task0.V5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int x = 105;
            int y = 223;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);

            Console.Title = "Спринт #2 | Выполгил: Ермаков А.А. | ПКТб-24-1";
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Спринт #2                                                                    *");
            Console.WriteLine("* Тема: Создание итогового решения по спринту                                  *");
            Console.WriteLine("* Задание #0                                                                   *");
            Console.WriteLine("* Вариант #5                                                                   *");
            Console.WriteLine("* Выполгил: Ермаков А.А.                                                       *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                     *");
            Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=,              *");
            Console.WriteLine("* последовательность операций не должна нарушаться) и арифметических выражений,*");
            Console.WriteLine("* которая вернет логическую последовательность(массив):                        *");
            Console.WriteLine("* ((False, True, True, True, False, True), при x = 105, y = 223                *");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
            Console.WriteLine("********************************************************************************");

            Console.WriteLine("X = " + x);
            Console.WriteLine("Y = " + y);

            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                   *");
            Console.WriteLine("********************************************************************************");

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }

            Console.ReadLine();
        }
    }
}

/*
 * ТЕОРИЯ 
 * Операция сравнения (==, !=, <, >, <=, >=)
 * Операция == 
 * Сравниваем два операнда на равенство. 
 * Если они равны, то операция возвращает true, если не равны false:
 * int a = 11;
 * int b = 5;
 * bool c = a == b; // false 
 
 * 
 */