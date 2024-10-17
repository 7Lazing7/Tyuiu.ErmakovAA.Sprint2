using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.ErmakovAA.Sprint2.Task6.V9.Lib
{
    public class DataService : ISprint2Task6V9
    {
        public string FindDateOfNextDay(int m, int n)
        {
            {

                int daysInMonth;

                switch (m)
                {
                    case 1: return "Январь";
                    case 3: return "Март";
                    case 5: return "Май";
                    case 7: return "Июль";
                    case 8: return "Август ";
                    case 10: return "Октябрь ";
                    case 12:
                        return "Декабрь ";
                        daysInMonth = 31; break;

                    case 4: return "Апрель";
                    case 6: return "Июнь";
                    case 9: return "Сентябрь ";
                    case 11:
                        return "Ноябрь ";
                        daysInMonth = 30; break;

                    case 2:
                        return "Февраль";
                        daysInMonth = 28; break;

                    default:
                        throw new ArgumentException($"День месяца должен быть от 1 до 12.Значение {m}");
                }

                if (n < 1 || n > daysInMonth)
                {
                    throw new ArgumentOutOfRangeException("Некорректный номер дня.");
                }
                if (n < daysInMonth)
                {
                    return  ($"{m}/{n + 1}");
                }
                else if (n == 12)
                {

                    return ($"1/1");
                }
                else
                {
                    return ($"{m + 1}/1");
                }
            }
        }
    }
}