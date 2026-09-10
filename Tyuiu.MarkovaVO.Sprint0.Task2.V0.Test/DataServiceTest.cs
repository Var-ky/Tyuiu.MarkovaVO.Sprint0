using Tyuiu.MarkovaVO.Sprint0.Task2.V0.lib;

namespace Tyuiu.MarkovaVO.Sprint0.Task2.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ChekGetMessageValid()
        {
            var name = "Варвара";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет..., Варвара", res);
        }
    }
}
