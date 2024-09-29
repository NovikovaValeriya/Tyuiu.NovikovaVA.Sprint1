using Tyuiu.NovikovaVA.Sprint1.Task5.V1.Lib;
namespace Tyuiu.NovikovaVA.Sprint1.Task5.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            double x1 = 0;
            double y1 = 0;
            double x2 = 1;
            double y2 = 0;
            DataService ds = new DataService();
            int result = ds.DistanceBetweenDots(x1, y1, x2, y2);
            int wait = 1;
            Assert.AreEqual(result, wait);

        }
    }
}