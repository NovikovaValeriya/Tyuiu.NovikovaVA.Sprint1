using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.NovikovaVA.Sprint1.Task4.V28.Lib
{
    public class DataService : ISprint1Task4V28
    {
        public double Calculate(double x, double y)
        {
            var res = (Math.Cos(60 * Math.PI / 2)) / (Math.Exp(2 * x+ y));
            return Math.Round(res,3);
        }
    }
}
