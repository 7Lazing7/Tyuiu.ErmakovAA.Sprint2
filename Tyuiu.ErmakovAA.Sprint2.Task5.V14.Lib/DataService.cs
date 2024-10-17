using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.ErmakovAA.Sprint2.Task5.V14.Lib
{
    public class DateCalculator
    {
        public static string CalculateDayOfWeek(int k, int d)
        {
            // Массив дней недели
            string[] daysOfWeek = { "понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье" };

            // Проверяем входные параметры
            if (k < 1 || k > 365 || d < 1 || d > 7)
                throw new ArgumentOutOfRangeException("Некорректные входные данные.");

            // Вычисляем индекс дня недели для k-го дня
            int dayIndex = (d - 1 + (k - 1)) % 7;

            return daysOfWeek[dayIndex];
        }
    }
}


            /* {
                
              //  string[] DayName = { "понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье" };
            string res;

           if (k < 1 || k > 365 || d < 1 || d > 7)
            {
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
                        res = "Пятница";
                        break;
                    case 6:
                        res = "Суббота";
                        break;
                    case 7:
                        res = "Воскресенье";
                        break;

                    default:
                        throw new ArgumentException($"День недели должен быть от 1 до 7.Значение {d}");
                }
            }     
               
                int dayIndex = (d - 1 + (k - 1)) % 7;

                return ; 
            }
        }
}
 */