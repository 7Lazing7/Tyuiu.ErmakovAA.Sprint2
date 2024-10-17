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


            {
                [Test]
                public void TestNextDayJanuary()
                {
                    var result = ds.FindDateOfNextDay(1, 15);
                    Assert.AreEqual((1, 16), result);
                }

                [Test]
                public void TestNextDayFebruary()
                {
                    var result = ds.FindDateOfNextDay(2, 27);
                    Assert.AreEqual((2, 28), result);
                }

                [Test]
                public void TestNextDayEndOfMonthApril()
                {
                    var result = ds.FindDateOfNextDay(4, 30);
                    Assert.AreEqual((5, 1), result);
                }

                [Test]
                public void TestNextDayEndOfMonth()
                {
                    var result = ds.FindDateOfNextDay(12, 30);
                    Assert.AreEqual((12, 31), result);
                }

                [Test]
                public void TestMonthOverflow()
                {
                    var result = ds.FindDateOfNextDay(12, 31);
                    Assert.ThrowsException<ArgumentOutOfRangeException>(() => ds.FindDateOfNextDay(12, 31));
                }

                [Test]
                public void TestInvalidDay()
                {
                    Assert.ThrowsException<ArgumentOutOfRangeException>(() => ds.FindDateOfNextDay(4, 31));
                }

                [Test]
                public void TestInvalidMonth()
                {
                    Assert.ThrowsException<ArgumentOutOfRangeException>(() => ds.FindDateOfNextDay(13, 10));
                }
            }
        }
    }
}
