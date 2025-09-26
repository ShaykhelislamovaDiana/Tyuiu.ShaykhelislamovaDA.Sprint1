using Tyuiu.ShaykhelislamovaDA.Sprint1.Task6.V2.Lib;
namespace Tyuiu.ShaykhelislamovaDA.Sprint1.Task6.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            string strTest = "Hellooo!";
            DataService ds = new DataService();
            bool res = ds.CheckHello(strTest);
            bool wait = true;
            Assert.AreEqual(wait, res);
        }
    }
}
