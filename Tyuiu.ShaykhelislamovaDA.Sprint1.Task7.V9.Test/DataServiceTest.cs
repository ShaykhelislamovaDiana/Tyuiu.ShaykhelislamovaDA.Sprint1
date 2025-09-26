using Tyuiu.ShaykhelislamovaDA.Sprint1.Task7.V9.Lib;
namespace Tyuiu.ShaykhelislamovaDA.Sprint1.Task7.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 1;
            double res = ds.Calculate(x, y);
            double wait = 2.073;
            Assert.AreEqual(wait, res);
        }
    }
}
