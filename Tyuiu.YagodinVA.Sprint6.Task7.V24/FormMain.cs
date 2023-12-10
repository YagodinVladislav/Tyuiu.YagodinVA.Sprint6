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

using Tyuiu.YagodinVA.Sprint6.Task7.V24.Lib;
namespace Tyuiu.YagodinVA.Sprint6.Task7.V24
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialog_YVA.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Всефайлы(*.*)|*.*";
            saveFileDialog_YVA.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Всефайлы(*.*)|*.*";
        }

        static int rows;
        static int columns;
        static string openFilePath;
        DataService ds = new DataService();
        public int[,] LoadFromFileData(string filePath)
        {
            string file = File.ReadAllText(filePath);
            file = file.Replace('\n', '\r');
            string[] lines = file.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] array = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] line_mas = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = Convert.ToInt32(line_mas[j]);
                }
            }
            return array;
        }

        private void buttonOpenFile_YVA_Click(object sender, EventArgs e)
        {
            openFileDialog_YVA.ShowDialog();
            openFilePath = openFileDialog_YVA.FileName;

            int[,] arrayValues = new int[rows, columns];
            arrayValues = LoadFromFileData(openFilePath);

            dataGridViewInPutData_YVA.RowCount = rows;
            dataGridViewInPutData_YVA.ColumnCount = columns;
            dataGridViewOutPutData_YVA.RowCount = rows;
            dataGridViewOutPutData_YVA.ColumnCount = columns;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewInPutData_YVA.Columns[i].Width = 50;
                dataGridViewOutPutData_YVA.Columns[i].Width = 50;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewInPutData_YVA.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            arrayValues = ds.GetMatrix(openFilePath);
            buttonDone_YVA.Enabled = true;
        }

        private void buttonOpenFile_YVA_MouseEnter(object sender, EventArgs e)
        {
            toolTip_YVA.ToolTipTitle = "Открыть";
        }

        private void buttonDone_YVA_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(openFilePath);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewOutPutData_YVA.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            buttonSave_YVA.Enabled = true;
        }

        private void buttonDone_YVA_MouseEnter(object sender, EventArgs e)
        {
            toolTip_YVA.ToolTipTitle = "Выполнить";
        }

        private void buttonSave_YVA_Click(object sender, EventArgs e)
        {
            saveFileDialog_YVA.FileName = "OutPutFileTask7V24.csv";
            saveFileDialog_YVA.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog_YVA.ShowDialog();

            string path = saveFileDialog_YVA.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool exists = fileInfo.Exists;
            if (exists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOutPutData_YVA.RowCount;
            int columns = dataGridViewOutPutData_YVA.ColumnCount;
            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str += dataGridViewInPutData_YVA.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str += dataGridViewInPutData_YVA.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonSave_YVA_MouseEnter(object sender, EventArgs e)
        {
            toolTip_YVA.ToolTipTitle = "Сохранить файл";
        }

        private void buttonAbout_YVA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonAbout_YVA_MouseEnter(object sender, EventArgs e)
        {
            toolTip_YVA.ToolTipTitle = "Справка";
        }
    }
}
