using Tyuiu.NovikovaVA.Sprint1.Task7.V27.Lib;
namespace Tyuiu.NovikovaVA.Sprint1.Task7.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 0;
            double y = 0;
            double wait = 1.75;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait,res);

        }
    }
}