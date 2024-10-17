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
                    case 1: return "1";
                    case 3: return "3";
                    case 5: return "5";
                    case 7: return "7";
                    case 8: return "8 ";
                    case 10: return "10 ";
                    case 12:
                        return "12 ";
                        daysInMonth = 31; break;

                    case 4: return "4";
                    case 6: return "6";
                    case 9: return "9 ";
                    case 11:
                        return "11 ";
                        daysInMonth = 30; break;

                    case 2:
                        return "Февраль";
                        daysInMonth = 28; break;

                    default:
                        throw new ArgumentException($"День месяца должен быть от 1 до 12.Значение {m}");
                }

                if (m < 1 || n > 12 || m < 1 || n > DateTime.DaysInMonth(2024, m))
                {
                    throw new ArgumentOutOfRangeException("Неверные значения месяца или дня");
                }
                if (n < daysInMonth)
                {
                    return ($"{m}/{n + 1}");
                }
                else if (n == 12)
                {

                    return ($"1/1");
                }
                else
                {
                    return ($"{m + 1}/1");
                }
                if (m < 1 || n > 12 || m < 1 || n > DateTime.DaysInMonth(2024, m))
                {
                    throw new ArgumentOutOfRangeException("Неверные значения месяца или дня");
                }

                DateTime date = new DateTime(2024, m, n);
                DateTime nextDay = date.AddDays(1);

                
                return nextDay.ToString("MM.dd");
            }
        }
    }
}
                /*

                switch (m)
                {
                    case 1: return "1";
                    case 3: return "3";
                    case 5: return "5";
                    case 7: return "7";
                    case 8: return "8 ";
                    case 10: return "10 ";
                    case 12:return "12 ";
                        daysInMonth = 31; break;

                    case 4: return "4";
                    case 6: return "6";
                    case 9: return "9 ";
                    case 11:return "11 ";
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
