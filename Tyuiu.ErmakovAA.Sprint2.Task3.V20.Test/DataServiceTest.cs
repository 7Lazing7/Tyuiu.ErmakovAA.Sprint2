using Tyuiu.ErmakovAA.Sprint2.Task3.V20.Lib;
namespace Tyuiu.ErmakovAA.Sprint2.Task3.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Validcondition1()
        {
        DataService ds = new DataService();
            double x = 2; 
            double res = ds.Calculate(x);
            double wait = 18;
            Assert.AreEqual(wait, res);
        }
        public void Validcondition2()
        {
            DataService ds = new DataService();
            double x = 0;
            double res = ds.Calculate(x);
            double wait = 0.75;
            Assert.AreEqual(wait, res);
        }
        public void Validcondition3()
        {
            DataService ds = new DataService();
            double x = 1;
            double res = ds.Calculate(x);
            double wait = 4;
            Assert.AreEqual(wait, res);
        }
        public void Validcondition4()
        {
            DataService ds = new DataService();
            double x = -25;
            double res = ds.Calculate(x);
            double wait = -274.96;
            Assert.AreEqual(wait, res);
        }
    }
}