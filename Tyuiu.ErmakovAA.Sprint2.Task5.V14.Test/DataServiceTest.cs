using Tyuiu.ErmakovAA.Sprint2.Task5.V14.Lib;
namespace Tyuiu.ErmakovAA.Sprint2.Task5.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDayName()
        {
            DataService ds = new DataService();

            Assert.AreEqual("Понедельник", ds.FindDayName(1));
            Assert.AreEqual("Вторемк", ds.FindDayName(2));
            Assert.AreEqual("Среда", ds.FindDayName(3));
            Assert.AreEqual("Четверг ", ds.FindDayName(4));
            Assert.AreEqual("Пятница ", ds.FindDayName(5));
            Assert.AreEqual("Суббота ", ds.FindDayName(6));
            Assert.AreEqual("Воскресенье", ds.FindDayName(7));

            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindDayName(-1);
            });
            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindDayName(8);
            });
        }
    }
}
