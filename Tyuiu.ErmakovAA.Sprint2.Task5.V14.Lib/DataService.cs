using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.ErmakovAA.Sprint2.Task5.V14.Lib
{
    public class DataService : ISprint2Task5V14
    {
        public string FindDayName(int k, int d)
        {
                
              //  string[] DayName = { "понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье" };
            string res;
            switch (d)
            {
                case 1:
                    res = "Понедельник";
                    break;
                case 2:
                    res = "Вторемк";
                    break;
                case 3:
                    res = "Среда";
                    break;
                case 4:
                    res = "Четверг";
                    break;
                case 5:
                    res = "Воскресенье";
                    break;
                case 6:
                    res = "Суббота";
                    break;
                case 7:
                    res = "Пятница"; 
                    break;

                default:
                    throw new ArgumentException($"День недели должен быть от 1 до 7.Значение {d}");
            }
            

           // if (k < 1 || k > 365 || d < 1 || d > 7)
           // {
           //     Console.WriteLine("Некорректные входные данные.");
           // }     
               
                int dayIndex = (d - 1 + (k - 1)) % 7;

                return res; 
            }
        }
}
 
