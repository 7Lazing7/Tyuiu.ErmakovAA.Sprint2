using System.ComponentModel.DataAnnotations;
using Tyuiu.ErmakovAA.Sprint2.Task5.V14.Lib;
namespace Tyuiu.ErmakovAA.Sprint2.Task5.V14.Test
{


    [TestFixture]
    public class DateCalculatorTests
    {
        [Test]
        public void TestCalculateDayOfWeek()
        {
            // Тесты на разные случаи
            Assert.AreEqual("понедельник", DateCalculator.CalculateDayOfWeek(1, 1));  // 1 января - понедельник
            Assert.AreEqual("вторник", DateCalculator.CalculateDayOfWeek(2, 1));      // 2 января - вторник
            Assert.AreEqual("воскресенье", DateCalculator.CalculateDayOfWeek(7, 1));  // 7 января - воскресенье
            Assert.AreEqual("среда", DateCalculator.CalculateDayOfWeek(4, 3));        // 4 января - среда, если 1 января - среда
        }

        [Test]
        public void TestOutOfRangeInputs()
        {
            // Проверка исключений для некорректных входных параметров
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => DateCalculator.CalculateDayOfWeek(366, 1)); // k вне пределов
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => DateCalculator.CalculateDayOfWeek(1, 8));    // d вне пределов
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => DateCalculator.CalculateDayOfWeek(0, 1));    // k вне пределов
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => DateCalculator.CalculateDayOfWeek(1, 0));    // d вне пределов
        }
    }
}


            /* DataService ds = new DataService();
           

            Assert.AreEqual("Понедельник", ds.FindDayName(1,1));
            Assert.AreEqual("Вторемк", ds.FindDayName(2,1));
            Assert.AreEqual("Среда", ds.FindDayName(4,3));
            Assert.AreEqual("Четверг ", ds.FindDayName(4,3));

          
            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindDayName(366,1);
            });
            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindDayName(1,8);
            });
            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindDayName(0, 1);
            });
            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindDayName(1, 0);
            });
        }
    }
}
*/