using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.YagodinVA.Sprint6.Task1.V1.Lib
{
    public class DataService : ISprint6Task1V1
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] result = new double[Math.Abs(startValue) + Math.Abs(stopValue) + 1];
            for (int i = startValue, x = 0; i <= stopValue; i++, x++)
            {
                if ((i + 2.5) != 0)
                {
                    result[x] = Math.Round(Math.Cos(2 * i) + ((Math.Sin(i) / (i + 2.5)) + 2 * i), 2);
                }
                else
                {
                    result[x] = 0;
                }
            }
            return result;
        }
    }
}
