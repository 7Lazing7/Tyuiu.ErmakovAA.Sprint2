using System;
using Tyuiu.ErmakovAA.Sprint2.Task5.V14.Lib;
namespace Tyuiu.ErmakovAA.Sprint2.Task5.V14
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
