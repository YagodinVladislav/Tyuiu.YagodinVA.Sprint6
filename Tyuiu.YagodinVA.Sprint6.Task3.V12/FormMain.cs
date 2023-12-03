using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using Tyuiu.YagodinVA.Sprint6.Task3.V12.Lib;
namespace Tyuiu.YagodinVA.Sprint6.Task3.V12
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        int[,] array = new int[5, 5] { { -9, 8, 9, 16, -18 },
                                       { -13, -11, -20, -15, 9 },
                                       { 18, 13, -12, -15, -11 },
                                       { 10, -2, 19, -4, -10 },
                                       { 6, -20, -4, 13, -14 } };

        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;

            dataGridViewInPutData_YVA.ColumnCount = columns;
            dataGridViewInPutData_YVA.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewInPutData_YVA.Columns[i].Width = 45;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewInPutData_YVA.Rows[i].Cells[j].Value = Convert.ToString(array[i, j]);
                }
            }
        }

        private void buttonHelp_YVA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы АСОиУб-23-2 Ягодин Владислав Александрович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonDone_YVA_Click(object sender, EventArgs e)
        {
            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;
            int[,] res_array = ds.Calculate(array);
            dataGridViewOutPutData_YVA.ColumnCount = columns;
            dataGridViewOutPutData_YVA.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewOutPutData_YVA.Columns[i].Width = 50;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewOutPutData_YVA.Rows[i].Cells[j].Value = Convert.ToString(res_array[i, j]);
                }
            }
        }
    }
}
