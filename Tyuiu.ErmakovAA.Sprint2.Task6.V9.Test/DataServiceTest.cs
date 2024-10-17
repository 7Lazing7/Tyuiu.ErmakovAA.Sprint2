using Tyuiu.ErmakovAA.Sprint2.Task6.V9.Lib;
namespace Tyuiu.ErmakovAA.Sprint2.Task6.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfNextDay()
        {
            DataService ds = new DataService();

            var testCases = new[]
                {
        new { Month = 1, Day = 15, Expected = "01.16" }, // Январь
        new { Month = 2, Day = 28, Expected = "03.01" }, // Февраль
        new { Month = 3, Day = 31, Expected = "04.01" }, // Март
        new { Month = 4, Day = 30, Expected = "05.01" }, // Апрель
        new { Month = 5, Day = 1, Expected = "05.02" },  // Май
        new { Month = 6, Day = 30, Expected = "07.01" }, // Июнь
        new { Month = 7, Day = 15, Expected = "07.16" }, // Июль
        new { Month = 8, Day = 31, Expected = "09.01" }, // Август
        new { Month = 9, Day = 30, Expected = "10.01" }, // Сентябрь
        new { Month = 10, Day = 31, Expected = "11.01" }, // Октябрь
        new { Month = 11, Day = 30, Expected = "12.01" }, // Ноябрь
        new { Month = 12, Day = 31, Expected = "01.01" }, // Декабрь
    };

            // Act & Assert
            foreach (var testCase in testCases)
            {
                var result = ds.FindDateOfNextDay(testCase.Month, testCase.Day);
                Assert.AreEqual(testCase.Expected, result, $"Failed for Month: {testCase.Month}, Day: {testCase.Day}");
            }
        }
    }
}