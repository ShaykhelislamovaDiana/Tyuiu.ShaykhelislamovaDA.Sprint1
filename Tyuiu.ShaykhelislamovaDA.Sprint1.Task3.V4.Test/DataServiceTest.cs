using Tyuiu.ShaykhelislamovaDA.Sprint1.Task3.V4.Lib;
namespace Tyuiu.ShaykhelislamovaDA.Sprint1.Task3.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 2;
            double y = 2.75;
            double z = 0.5;
            var res = ds.PurchaseAmount(y, z, x);
            Assert.AreEqual(6.5, res);
        }
    }
}
