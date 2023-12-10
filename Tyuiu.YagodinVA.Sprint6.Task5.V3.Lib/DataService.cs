using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.YagodinVA.Sprint6.Task5.V3.Lib
{
    public class DataService : ISprint6Task5V3
    {
        public int len = 0;
        double[] resArray = new double[5];
        int count = 0;
        public double[] LoadFromDataFile(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    len++;
                }
            }
            double[] numsArray = new double[len];
            int index = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    numsArray[index] = Convert.ToDouble(line);
                    index++;
                }
            }
            for (int i = 0; i < numsArray.Length; i++)
            {
                foreach (char elements in Convert.ToString(numsArray[i]))
                {
                    if (elements == ',')
                    {
                        resArray[count] = numsArray[i];
                        count++;
                    }
                }
            }
            return resArray;
        }
    }
}
