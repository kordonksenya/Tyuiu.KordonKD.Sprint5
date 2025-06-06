using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KordonKD.Sprint5.Task1.V23.Lib;
using System.IO;

namespace Tyuiu.KordonKD.Sprint5.Task1.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = Path.GetTempFileName();
            FileInfo file = new FileInfo(path);
            bool fileExists = file.Exists;
            Assert.IsTrue(fileExists);
        }
    }
}
