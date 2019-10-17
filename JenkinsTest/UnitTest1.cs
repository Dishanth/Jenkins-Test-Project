using System;
using BuildJenkins;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JenkinsTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
          Assert.AreEqual("First CICD", Program.CreateMessage(),"Failed to match string");
        }
    }
}
