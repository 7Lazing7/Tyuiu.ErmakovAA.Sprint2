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
            int k = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите номер дня года (1 - 7): ");
            int d = Convert.ToInt32(Console.ReadLine());

            string res;
            if (k < 1 || k > 365)
            {
               Console.WriteLine("Некорректные входные данные.");
            }     
               else
            {
                res = " день года является: " + ds.FindDayName(k,d);
            }

            

            Console.WriteLine(d);

        }
    }
}