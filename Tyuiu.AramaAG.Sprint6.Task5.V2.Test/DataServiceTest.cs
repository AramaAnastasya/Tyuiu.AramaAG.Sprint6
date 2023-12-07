using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AramaAG.Sprint6.Task5.V2.Lib;

namespace Tyuiu.AramaAG.Sprint6.Task5.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            string path = @"C:\DataSprint6\InPutFileTask5V2.txt";
            DataService ds = new DataService();
            double[] res = ds.LoadFromDataFile(path);
            double[] wait = { -1,-2,-3,-5,-6,-7,-8,-9,-10 };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
