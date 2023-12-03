using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.YagodinVA.Sprint6.Task2.V4.Lib;
namespace Tyuiu.YagodinVA.Sprint6.Task2.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService dataService = new DataService();
            int startValue = -5;
            int stopValue = 5;
            double[] result = new double[stopValue - startValue + 1];
            result = dataService.GetMassFunction(startValue, stopValue);
            double[] wait = new double[stopValue - startValue + 1];
            wait[0] = -15.6;
            wait[1] = -12.35;
            wait[2] = -10.72;
            wait[3] = -8.88;
            wait[4] = -2.16;
            wait[5] = 3.25;
            wait[6] = 6.64;
            wait[7] = 10.3;
            wait[8] = 16.17;
            wait[9] = 28.1;
            wait[10] = 38.41;
            CollectionAssert.AreEqual(result, wait);
        }
    }
}