using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.NovikovaVA.Sprint1.Task2.V11.Lib
{
    public class DataService : ISprint1Task2V11
    {
        public int ConvertHoursMinutesToSeconds(int x, int y)
        {
            return (x*3600) + (y*60);
        
        }
    }
}
