using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

using Tyuiu.YagodinVA.Sprint6.Task6.V15.Lib;
namespace Tyuiu.YagodinVA.Sprint6.Task6.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCollectTextFromFile()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\malsu\InPutFileTask6V15.txt";
            string wait = "HlidZPHKeLLU OoyPFhjSRwp GUilXww iukCfO UaZNpcgYjw  ";
            string res = ds.CollectTextFromFile(path);
            Assert.AreEqual(wait, res);
        }
    }
}
