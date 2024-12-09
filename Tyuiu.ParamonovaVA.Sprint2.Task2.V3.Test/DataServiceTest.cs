using Tyuiu.ParamonovaVA.Sprint2.Task2.V3.Lib;

namespace Tyuiu.ParamonovaVA.Sprint2.Task2.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 9;
            int y = 3;
            bool res = ds.CheckDotInShadedArea(x, y);
            Assert.AreEqual(true, res);
        }
    }
    
}