using Tyuiu.SozonovaVA.Sprint1.Task2.V1.Lib;
namespace Tyuiu.SozonovaVA.Sprint1.Task2.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 3;
            var res = ds.ConvertKmToM(x);
            Assert.AreEqual(1.875, res);
        }
    }
}
