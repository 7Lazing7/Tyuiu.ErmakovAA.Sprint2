using Tyuiu.ErmakovAA.Sprint2.Task4.V6.Lib;
namespace Tyuiu.ErmakovAA.Sprint2.Task4.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 3;
            double y = 1;
            double res = ds.Calculate(x, y);
            double wait = 0.192;
            Assert.AreEqual(wait, res);

        }
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 12;
            double res = ds.Calculate(x, y);
            double wait = 151;
            Assert.AreEqual(wait, res);

        }
    }
}