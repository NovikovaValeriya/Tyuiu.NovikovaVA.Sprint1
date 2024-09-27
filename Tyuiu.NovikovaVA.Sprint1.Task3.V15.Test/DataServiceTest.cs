using Tyuiu.NovikovaVA.Sprint1.Task3.V15.Lib;
namespace Tyuiu.NovikovaVA.Sprint1.Task3.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double v1 = 5;
            double v2 = 7;
            double S = 10;
            double T = 3;
            double wait = 46;
            var res = ds.DistanceOverTime(v1, v2, S, T);
            Assert.AreEqual(wait, res);
        }
    }
}