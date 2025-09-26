using Tyuiu.ShaykhelislamovaDA.Sprint1.Task4.V25.Lib;
namespace Tyuiu.ShaykhelislamovaDA.Sprint1.Task4.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest 
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 90;
            var res = ds.Calculate(x);
            Assert.AreEqual(1.812, res);
        }
    }
}
