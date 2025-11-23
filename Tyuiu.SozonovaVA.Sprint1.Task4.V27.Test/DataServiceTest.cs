using Tyuiu.SozonovaVA.Sprint1.Task4.V27.Lib;
namespace Tyuiu.SozonovaVA.Sprint1.Task4.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckCalc()
        {
            var result = new DataService();
            Assert.AreEqual(-2.414, result.Calculate(1, 2));
        }
    }
}
