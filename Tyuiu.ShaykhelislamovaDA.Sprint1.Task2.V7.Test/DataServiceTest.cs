using Tyuiu.ShaykhelislamovaDA.Sprint1.Task2.V7.Lib;
namespace Tyuiu.ShaykhelislamovaDA.Sprint1.Task2.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 2;
            var res = ds.CalculateSquareCircle(x);
            Assert.AreEqual(12.566, res);
        }
    }
}
