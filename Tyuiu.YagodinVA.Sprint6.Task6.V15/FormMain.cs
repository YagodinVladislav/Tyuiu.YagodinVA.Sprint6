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

using Tyuiu.YagodinVA.Sprint6.Task6.V15.Lib;
namespace Tyuiu.YagodinVA.Sprint6.Task6.V15
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();
        string openFilePath;
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonOpenFile_YVA_Click(object sender, EventArgs e)
        {
            openFileDialog_YVA.ShowDialog();
            openFilePath = openFileDialog_YVA.FileName;
            textBoxInPutData_YVA.Text = File.ReadAllText(openFilePath);
            groupBoxOutPutData_YVA.Text = groupBoxOutPutData_YVA.Text + " " + openFileDialog_YVA.FileName;
            buttonDone_YVA.Enabled = true;
        }

        private void buttonAbout_YVA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonDone_YVA_Click(object sender, EventArgs e)
        {
            textBoxOutPutData_YVA.Text = ds.CollectTextFromFile(openFilePath);
        }
    }
}
