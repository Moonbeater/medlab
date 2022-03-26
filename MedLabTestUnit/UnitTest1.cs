using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MedLab;
using MedLabAnalizatorDLL;

namespace MedLabTestUnit
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1_Wrong_Analizator()
        {
            string idService = "619";

            string analizator = "test";

            string expected = "Не верно выбран анализатор";

            DBConnection.Connect();

            string actual = Analizator.ResultAnalizator(idService, analizator);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod2_Biorad_Analizator()
        {
            string idService = "176";

            string analizator = "Biorad";

            string expected1 = "Плохое качество биоматериала";

            DBConnection.Connect();

            string actual = Analizator.ResultAnalizator(idService, analizator);

            Assert.AreEqual(expected1, actual);
        }
    }
}
