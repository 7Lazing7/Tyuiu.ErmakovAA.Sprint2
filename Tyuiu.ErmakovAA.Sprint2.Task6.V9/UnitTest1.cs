using Tyuiu.ErmakovAA.Sprint2.Task6.V9.Lib;
namespace Tyuiu.ErmakovAA.Sprint2.Task6.V9
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            {
                DataService ds = new DataService();

                Console.Write("Введите номер месяца (1-12): ");
                int m = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введите номер дня: ");
                int n = Convert.ToInt32(Console.ReadLine());

                string nexData = ds.FindDateOfNextDay(m, n);
                

                if (n >= 1 || n <= 12) 
                {
                    Console.WriteLine($"Следующий день: {n} число, {m} месяц.");
                }
                else
                {
                    Console.WriteLine("Ошибка: Введите некорректное числовое значение.");
                }

                 

            }
        }
    }
}

 