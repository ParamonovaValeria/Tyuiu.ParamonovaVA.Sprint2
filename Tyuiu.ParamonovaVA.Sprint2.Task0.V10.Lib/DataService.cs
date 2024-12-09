using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.ParamonovaVA.Sprint2.Task0.V10.Lib
{
    public class DataService : ISprint2Task0V10
    {
        public bool[] GetCompareOperations(int a, int b)
        {
            bool[] result = new bool[6];
            result[0] = a == b;
            result[1] = a != b;
            result[2] = a < b;
            result[3] = a > b;
            result[4] = a <= b;
            result[5] = a >= b;
            return result;
        }
    }
}
