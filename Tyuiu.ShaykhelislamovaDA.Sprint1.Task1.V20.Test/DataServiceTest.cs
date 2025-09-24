using Tyuiu.ShaykhelislamovaDA.Sprint1.Task1.V20.Lib;
namespace Tyuiu.ShaykhelislamovaDA.Sprint1.Task1.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1.0;
            double y = 2.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(11.0, res);
        }
    }
}