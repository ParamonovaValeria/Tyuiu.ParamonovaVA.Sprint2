using Tyuiu.ParamonovaVA.Sprint2.Task0.V10.Lib;

namespace Tyuiu.ParamonovaVA.Sprint2.Task0.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            bool[] foo = [false, true, false, true, false, true];
            bool[] bar = dataService.GetCompareOperations(1305, 475);
            for (int i = 0; i < foo.Length; i++)
            {
                if (!(foo[i] == bar[i]))
                {
                    Assert.Fail();
                }
            }
            Assert.AreEqual<bool>(true, true);
        }
    }
}