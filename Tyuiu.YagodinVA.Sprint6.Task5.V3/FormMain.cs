using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using Tyuiu.YagodinVA.Sprint6.Task5.V3.Lib;
namespace Tyuiu.YagodinVA.Sprint6.Task5.V3
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();
        string path = @"C:\Users\malsu\source\repos\Tyuiu.YagodinVA.Sprint6\Tyuiu.YagodinVA.Sprint6.Task5.V3\bin\Debug\InPutFileTask5V3.txt";
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonHelp_YVA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы АСОиУБ-23-2 Ягодин Владислав Александрович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonOpenFile_YVA_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonDone_YVA_Click(object sender, EventArgs e)
        {
            dataGridViewOutPutData_YVA.ColumnCount = 2;
            dataGridViewOutPutData_YVA.Columns[0].Width = 20;
            dataGridViewOutPutData_YVA.Columns[1].Width = 50;
            this.chartFunction_YVA.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartFunction_YVA.ChartAreas[0].AxisY.Title = "Ось Y";
            chartFunction_YVA.Series[0].Points.Clear();
            double[] numsMass = new double[ds.len];
            numsMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewOutPutData_YVA.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartFunction_YVA.Series[0].Points.AddXY(i, numsMass[i]);
            }
        }
    }
}
