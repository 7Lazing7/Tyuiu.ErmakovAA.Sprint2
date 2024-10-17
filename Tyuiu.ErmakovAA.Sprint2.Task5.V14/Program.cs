using System;
using Tyuiu.ErmakovAA.Sprint2.Task5.V14.Lib;
namespace Tyuiu.ErmakovAA.Sprint2.Task5.V14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите номер дня года (1 - 365): ");
                int k = int.Parse(Console.ReadLine());

                Console.Write("Введите номер дня недели для 1 января (1 = понедельник, 7 = воскресенье): ");
                int d = int.Parse(Console.ReadLine());

                string dayOfWeek = DateCalculator.CalculateDayOfWeek(k, d);

                Console.WriteLine($"{k}-й день года является: {dayOfWeek}.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: Введите корректное числовое значение.");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }
    }
}


/* {
DataService ds = new DataService();

Console.Write("Введите номер дня года (1 - 365): ");
int numDay = Convert.ToInt32(Console.ReadLine());

string res;
if (numDay < 1 || numDay > 365)
{
   Console.WriteLine("Некорректные входные данные.");
}     
   else
{
    res = " день года является: " + ds.FindDayName(numDay,0);
}



Console.WriteLine(numDay);

}
}
}
*/