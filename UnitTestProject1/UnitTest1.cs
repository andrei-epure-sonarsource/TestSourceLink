using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary3;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("S", new Class1().Method());
        }
    }
}
