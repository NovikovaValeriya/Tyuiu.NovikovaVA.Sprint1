using Tyuiu.NovikovaVA.Sprint1.Task2.V11.Lib;
namespace Tyuiu.NovikovaVA.Sprint1.Task2.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 1;
            int y= 20;
            var res = ds.ConvertHoursMinutesToSeconds(x, y);
            Assert.AreEqual(4800, res);
        }
    }
}