using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.ErmakovAA.Sprint2.Task6.V9.Lib
{
    public class DataService : ISprint2Task6V9
    {

        public string FindDateOfNextDay(int m, int n)
        {
            string result = "";
            string month = "";
            string day = "";
            switch (n)
            {
                case 1:
                    {
                        month = "01";
                        break;
                    }
                case 2:
                    {
                        month = "02";
                        break;
                    }
                case 3:
                    {
                        month = "03";
                        break;
                    }
                case 4:
                    {
                        month = "04";
                        break;
                    }
                case 5:
                    {
                        month = "05";
                        break;
                    }
                case 6:
                    {
                        month = "06";
                        break;
                    }
                case 7:
                    {
                        month = "07";
                        break;
                    }
                case 8:
                    {
                        month = "08";
                        break;
                    }
                case 9:
                    {
                        month = "09";
                        break;
                    }
                case 10:
                    {
                        month = "10";
                        break;
                    }
                case 11:
                    {
                        month = "11";
                        break;
                    }
                case 12:
                    {
                        month = "12";
                        break;
                    }
                default:
                    {
                        throw new ArgumentException($"Месяц должен быть от 1 до 12. Значение {n}");
                    }

            }
            switch (m)
            {
                case 1:
                    {
                        day = "02";
                        break;
                    }
                case 2:
                    {
                        day = "03";
                        break;
                    }
                case 3:
                    {
                        day = "04";
                        break;
                    }
                case 4:
                    {
                        day = "05";
                        break;
                    }
                case 5:
                    {
                        day = "06";
                        break;
                    }
                case 6:
                    {
                        day = "07";
                        break;
                    }
                case 7:
                    {
                        day = "08";
                        break;
                    }
                case 8:
                    {
                        day = "09";
                        break;
                    }
                case 9:
                    {
                        day = "10";
                        break;
                    }
                case 10:
                case 11:
                case 12:
                case 13:
                case 14:
                case 15:
                case 16:
                case 17:
                case 18:
                case 19:
                case 20:
                case 21:
                case 22:
                case 23:
                case 24:
                case 25:
                case 26:
                case 27:
                case 28:
                case 29:
                case 30:
                case 31:
                    {
                        day = Convert.ToString(m + 1);
                        break;
                    }
                default:
                    {
                        throw new ArgumentException($"День должен быть от 1 до 31. Значение {m}");
                    }

            }
            result += day + "." + month;
            return result;
        }
    }
}