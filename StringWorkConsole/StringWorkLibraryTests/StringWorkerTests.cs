using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace StringWorkLibrary.Tests
{
    [TestClass()]
    public class StringWorkerTests
    {
        [TestMethod()]
        public void StringIncrementorTest()
        {
            string input = "ГЛАВ123РЫБА56";
            int increment = 60;

            string expected = "ГЛАВ183РЫБА16";

            Assert.AreEqual(expected, StringWorker.StringIncrementor(input, increment));
        }

        [TestMethod()]
        public void StringIncrementorTest2()
        {
            string input = "ГАЗ4ПРОМ5БАНК97";
            int increment = 15;

            string expected = "ГАЗ9ПРОМ0БАНК12";

            Assert.AreEqual(expected, StringWorker.StringIncrementor(input, increment));
        }

        [TestMethod()]
        public void StringIncrementorTest3()
        {
            string input = "ААА123БББ11";
            int increment = 95;

            string expected = "ААА218ББВ06";

            //Не забыть указать true последний параметром метода
            Assert.AreEqual(expected, StringWorker.StringIncrementor(input, increment, true));
        }
    }
}