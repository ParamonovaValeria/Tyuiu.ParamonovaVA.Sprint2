using Tyuiu.ParamonovaVA.Sprint2.Task7.V2.Lib;

namespace Tyuiu.ParamonovaVA.Sprint2.Task7.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckDotInShadedArea()
        {
            DataService ds = new DataService();
            double x = 0.5;
            double y = -0.3;
            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;
            Assert.AreEqual(wait, res);
        }
    }
}