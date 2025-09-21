using Tyuiu.ShaykhelislamovaDA.Sprint1.Task0.V28.Lib;
namespace Tyuiu.ShaykhelislamovaDA.Sprint1.Task0.V28.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.Equal(22, res);
        }
    }
}