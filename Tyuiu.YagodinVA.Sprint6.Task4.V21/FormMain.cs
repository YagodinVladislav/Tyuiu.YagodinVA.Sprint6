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

using Tyuiu.YagodinVA.Sprint6.Task4.V21.Lib;
namespace Tyuiu.YagodinVA.Sprint6.Task4.V21
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonDone_YVA_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartIndex_YVA.Text);
                int stopStep = Convert.ToInt32(textBoxStopIndex_YVA.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartFunction_YVA.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_YVA.ChartAreas[0].AxisY.Title = "Ось Y";

                textBoxOutPutData_YVA.Text = "";

                chartFunction_YVA.Series[0].Points.Clear();
                for (int i = 0; i < len; i++, startStep++)
                {
                    this.chartFunction_YVA.Series[0].Points.AddXY(startStep, valueArray[i]);
                    textBoxOutPutData_YVA.AppendText(valueArray[i] + Environment.NewLine);
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonSave_YVA_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4V21.txt";
                File.WriteAllText(path, textBoxOutPutData_YVA.Text);
                DialogResult dialogResult = MessageBox.Show($"Файл {path} сохранен успешно!\nОткрыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error)  ;
            }
        }

        private void buttonHelp_YVA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы АСОиУб-23-2 Ягодин Владислав Александрович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
