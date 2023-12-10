using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

using Tyuiu.YagodinVA.Sprint6.Task5.V3.Lib;
namespace Tyuiu.YagodinVA.Sprint6.Task5.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            string path = @"C:\Users\malsu\source\repos\Tyuiu.YagodinVA.Sprint6\Tyuiu.YagodinVA.Sprint6.Task5.V3\bin\Debug\InPutFileTask5V3.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
