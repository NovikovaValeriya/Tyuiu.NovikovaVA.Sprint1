using Tyuiu.NovikovaVA.Sprint1.Task6.V16.Lib;
namespace Tyuiu.NovikovaVA.Sprint1.Task6.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string strTest = "Привет! Что делаешь?";
            DataService ds = new DataService();
            bool res = ds.CheckSpecSymbols( strTest );
            Assert.IsTrue( res );
            
        }
        public void NotValidString()
        {
            string strTest = "Привет Что делаешь";
            DataService ds = new DataService();
            bool res = ds.CheckSpecSymbols(strTest);
            Assert.IsFalse(res);

        }
        public void NotValidString2()
        {
            string strTest = "Привет! Что делаешь";
            DataService ds = new DataService();
            bool res = ds.CheckSpecSymbols(strTest);
            Assert.IsFalse(res);

        }
        public void NotValidString3()
        {
            string strTest = "Привет Что делаешь?";
            DataService ds = new DataService();
            bool res = ds.CheckSpecSymbols(strTest);
            Assert.IsFalse(res);

        }

    }
}