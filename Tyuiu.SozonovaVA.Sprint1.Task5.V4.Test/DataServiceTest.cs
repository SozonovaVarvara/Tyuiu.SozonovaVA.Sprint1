using Tyuiu.SozonovaVA.Sprint1.Task5.V4.Lib;
namespace Tyuiu.SozonovaVA.Sprint1.Task5.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int k = 13257;
            int h = ds.SecondsToHours(k);
            int wait = 3;

            Assert.AreEqual(wait, h);
        }
    }
}
