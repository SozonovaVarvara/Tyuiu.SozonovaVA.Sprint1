using Tyuiu.SozonovaVA.Sprint1.Task6.V3.Lib;
namespace Tyuiu.SozonovaVA.Sprint1.Task6.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidStrind()
        {
            string input = "Hello World Test";
            DataService ds = new DataService();

            string res = ds.LastLetterWord(input);
            string expected = "odt";
            Assert.AreEqual(expected, res);
        }
    }
}
