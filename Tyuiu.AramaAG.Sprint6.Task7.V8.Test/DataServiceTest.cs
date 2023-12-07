using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.AramaAG.Sprint6.Task7.V8.Lib;

namespace Tyuiu.AramaAG.Sprint6.Task7.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            string path = @"C:\Users\Lenovo\source\repos\Tyuiu.AramaAG.Sprint6\Tyuiu.AramaAG.Sprint6.Task7.V8\bin\Debug\OutPutFileTask7.csv";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
