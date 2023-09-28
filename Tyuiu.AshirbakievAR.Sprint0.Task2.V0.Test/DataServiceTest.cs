using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AshirbakievAR.Sprint0.Task2.V0.Lib;

namespace Tyuiu.AshirbakievAR.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ChekGetMessageValid()
        {
            var name = "Алмаз";
            var res = DataService.GetMessage(name);
            Assert.AreEqual("Привет, Алмаз", res);
        }
    }
}
