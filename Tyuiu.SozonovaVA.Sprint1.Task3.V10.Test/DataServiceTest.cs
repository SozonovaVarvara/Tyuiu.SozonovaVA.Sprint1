using Tyuiu.SozonovaVA.Sprint1.Task3.V10.Lib;
namespace Tyuiu.SozonovaVA.Sprint1.Task3.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double number = 23.6;
            Assert.AreEqual(23.6, number);
        }
    }
}
