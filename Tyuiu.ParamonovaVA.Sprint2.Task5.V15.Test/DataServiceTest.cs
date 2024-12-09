using Tyuiu.ParamonovaVA.Sprint2.Task5.V15.Lib;

namespace Tyuiu.ParamonovaVA.Sprint2.Task5.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string res = ds.FindDayName(7);
            Assert.AreEqual("Воскресенье", res);
        
    }
    }
}