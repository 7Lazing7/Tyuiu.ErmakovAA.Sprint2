using Tyuiu.ErmakovAA.Sprint2.Task1.V25.Lib;
namespace Tyuiu.ErmakovAA.Sprint2.Task1.V25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int a = 247;
            int b = 155;
            int c = 325;
            int d = 857;
            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);

            Console.Title = "Спринт #2 | Выполгил: Ермаков А.А. | ПКТб-24-1";
            Console.WriteLine("*******************************************************************************************");
            Console.WriteLine("* Спринт #2                                                                               *");
            Console.WriteLine("* Тема: Создание итогового решения по спринту                                             *");
            Console.WriteLine("* Задание #1                                                                              *");
            Console.WriteLine("* Вариант #25                                                                              *");
            Console.WriteLine("* Выполгил: Ермаков А.А.                                                                  *");
            Console.WriteLine("*******************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                *");
            Console.WriteLine("* Написать программу из операций сравнений                                                *");
            Console.WriteLine("* (==, !=, <, >, <=, >=, последовательность можно чередовать,                             *");
            Console.WriteLine("* но использовать один раз в выражении) и логических операций                             *");
            Console.WriteLine("* (|, &, ||, &&, !, ^, последовательность операций не должна нарушаться),                 *");
            Console.WriteLine("* а также арифметических выражений, которая вернет логическую последовательность(массив): *");
            Console.WriteLine("* (True, False, True, False, True, False), при a = 247, b = 155, c = 325, d = 857         *");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                        *");
            Console.WriteLine("*******************************************************************************************");

            Console.WriteLine("A = " + a);
            Console.WriteLine("B = " + b);
            Console.WriteLine("C = " + c);
            Console.WriteLine("D = " + d);


            Console.WriteLine("*******************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                              *");
            Console.WriteLine("*******************************************************************************************");

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }

            Console.ReadLine();
        }
    }
}
