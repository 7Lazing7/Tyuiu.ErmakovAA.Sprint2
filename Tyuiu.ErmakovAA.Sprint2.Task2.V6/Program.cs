using Tyuiu.ErmakovAA.Sprint2.Task2.V6.Lib;
namespace Tyuiu.ErmakovAA.Sprint2.Task2.V6
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
            Console.WriteLine("* Задание #2                                                                   *");
            Console.WriteLine("* Вариант #6                                                                   *");
            Console.WriteLine("* Выполгил: Ермаков А.А.                                                       *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                     *");
            Console.WriteLine("* Написать программу на, которая запрашивает целые значения с клавиатуры       *");
            Console.WriteLine("* и вычисляет находится ли точка с координатами X,Y в заштрихованной области.  *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
            Console.WriteLine("********************************************************************************");

            Console.WriteLine("Введите значение X: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение Y: ");
            int y = Convert.ToInt32(Console.ReadLine());

            bool res = ds.CheckDotInShadedArea(x, y);

            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                   *");
            Console.WriteLine("********************************************************************************");

            if (res) 
            { 
                Console.WriteLine("Точка заштрахованна ");
            }
            else 
            { 
                Console.WriteLine("Точка не заштрахованна  "); 
            }

            Console.ReadLine();
        }
    }
}
