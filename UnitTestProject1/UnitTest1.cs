using AnalaizerClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {

        public TestContext TestContext { get; set; }

        [TestMethod]

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "TestData.xml", "Row", DataAccessMethod.Sequential)]
        public void CheckFormat()
        {
            string expression_new = Convert.ToString(TestContext.DataRow["expression"]);
            string expected = Convert.ToString(TestContext.DataRow["expected"]);
            AnalaizerClass.expression = expression_new;
            string actual = AnalaizerClass.Format();
            Assert.AreEqual(expected, actual);
        }
    }
}
