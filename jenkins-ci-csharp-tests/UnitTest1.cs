using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using jenkins_ci_csharp;

namespace jenkins_ci_csharp_tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("Hello World!", Program.CreateMessage());
        }
    }
}
