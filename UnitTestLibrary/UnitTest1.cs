using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using DemoUnitTestApp;

namespace UnitTestLibrary
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(0, 0);
        }

        [TestMethod]
        public void BasicTest()
        {
            Rooter rooter = new Rooter();
            double expected = 0.0;
            double actual = rooter.SquareRoot(expected * expected);
            double tolerance = .001;
            Assert.AreEqual(expected, actual, tolerance);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(0, 1);
        }

    }
}
