﻿using Tyuiu.ShaykhelislamovaDA.Sprint1.Task5.V1.Lib;
namespace Tyuiu.ShaykhelislamovaDA.Sprint1.Task5.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x1 = 1, y1 = 1, x2 = 2, y2 = 2;
            double res = ds.DistanceBetweenDots(x1, y1, x2, y2);

            int result = Convert.ToInt32(res);
            int wait = 1;
            Assert.AreEqual(wait, result);
        }
    }
}
