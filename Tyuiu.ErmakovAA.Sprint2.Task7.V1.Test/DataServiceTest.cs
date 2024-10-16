using Tyuiu.ErmakovAA.Sprint2.Task7.V1.Lib;
namespace Tyuiu.ErmakovAA.Sprint2.Task7.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckDotInArea()
        {
            DataService ds = new DataService();
            double x = 0.2;
            double y = 0.6;
            bool res = ds.CheckDotInShadedArea(x, y);
            Assert.AreEqual(res, true);
        }
    }
}