using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JenkinsTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
          Assert.IsTrue(true,"Test Pass");
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.Fail("Test fail");
        }
    }
}
