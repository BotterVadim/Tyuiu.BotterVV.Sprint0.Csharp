using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BotterVV.Sprint0.Csharp.Task2.V0.Lib;

namespace Tyuiu.BotterVV.Sprint0.Csharp.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Вадим";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, Вадим", res);
        }
    }
}
