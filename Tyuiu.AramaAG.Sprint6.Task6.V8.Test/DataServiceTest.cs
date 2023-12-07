using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AramaAG.Sprint6.Task6.V8.Lib;

namespace Tyuiu.AramaAG.Sprint6.Task6.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedCollectTextFromFile()
        {
            string path = @"C:\DataSprint6\InPutFileTask6V8.txt";
            DataService ds = new DataService();
            string res = ds.CollectTextFromFile(path);
            string wait = "NnhEZ vpZoG RwZn RizdogMOZpCb GqzgGQOdWpd ztMvvn XVZeHq";
            Assert.AreEqual(wait, res);
        }
    }
}
