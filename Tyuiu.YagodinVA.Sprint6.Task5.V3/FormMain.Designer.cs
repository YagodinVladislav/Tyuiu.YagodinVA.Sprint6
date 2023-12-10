
namespace Tyuiu.YagodinVA.Sprint6.Task5.V3
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelTop_YVA = new System.Windows.Forms.Panel();
            this.panelLeft_YVA = new System.Windows.Forms.Panel();
            this.splitterMain_YVA = new System.Windows.Forms.Splitter();
            this.panelFill_YVA = new System.Windows.Forms.Panel();
            this.groupBoxTask_YVA = new System.Windows.Forms.GroupBox();
            this.textBoxTask_YVA = new System.Windows.Forms.TextBox();
            this.buttonDone_YVA = new System.Windows.Forms.Button();
            this.buttonOpenFile_YVA = new System.Windows.Forms.Button();
            this.buttonHelp_YVA = new System.Windows.Forms.Button();
            this.groupBoxOutPutData_YVA = new System.Windows.Forms.GroupBox();
            this.dataGridViewOutPutData_YVA = new System.Windows.Forms.DataGridView();
            this.chartFunction_YVA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelTop_YVA.SuspendLayout();
            this.panelLeft_YVA.SuspendLayout();
            this.panelFill_YVA.SuspendLayout();
            this.groupBoxTask_YVA.SuspendLayout();
            this.groupBoxOutPutData_YVA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPutData_YVA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_YVA)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop_YVA
            // 
            this.panelTop_YVA.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.panelTop_YVA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelTop_YVA.Controls.Add(this.buttonHelp_YVA);
            this.panelTop_YVA.Controls.Add(this.buttonOpenFile_YVA);
            this.panelTop_YVA.Controls.Add(this.buttonDone_YVA);
            this.panelTop_YVA.Controls.Add(this.groupBoxTask_YVA);
            this.panelTop_YVA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_YVA.Location = new System.Drawing.Point(0, 0);
            this.panelTop_YVA.Name = "panelTop_YVA";
            this.panelTop_YVA.Size = new System.Drawing.Size(693, 100);
            this.panelTop_YVA.TabIndex = 0;
            // 
            // panelLeft_YVA
            // 
            this.panelLeft_YVA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panelLeft_YVA.Controls.Add(this.groupBoxOutPutData_YVA);
            this.panelLeft_YVA.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_YVA.Location = new System.Drawing.Point(0, 100);
            this.panelLeft_YVA.Name = "panelLeft_YVA";
            this.panelLeft_YVA.Size = new System.Drawing.Size(200, 382);
            this.panelLeft_YVA.TabIndex = 1;
            // 
            // splitterMain_YVA
            // 
            this.splitterMain_YVA.Location = new System.Drawing.Point(200, 100);
            this.splitterMain_YVA.Name = "splitterMain_YVA";
            this.splitterMain_YVA.Size = new System.Drawing.Size(3, 382);
            this.splitterMain_YVA.TabIndex = 2;
            this.splitterMain_YVA.TabStop = false;
            // 
            // panelFill_YVA
            // 
            this.panelFill_YVA.Controls.Add(this.chartFunction_YVA);
            this.panelFill_YVA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFill_YVA.Location = new System.Drawing.Point(203, 100);
            this.panelFill_YVA.Name = "panelFill_YVA";
            this.panelFill_YVA.Size = new System.Drawing.Size(490, 382);
            this.panelFill_YVA.TabIndex = 3;
            // 
            // groupBoxTask_YVA
            // 
            this.groupBoxTask_YVA.Controls.Add(this.textBoxTask_YVA);
            this.groupBoxTask_YVA.Location = new System.Drawing.Point(4, 4);
            this.groupBoxTask_YVA.Name = "groupBoxTask_YVA";
            this.groupBoxTask_YVA.Size = new System.Drawing.Size(410, 90);
            this.groupBoxTask_YVA.TabIndex = 0;
            this.groupBoxTask_YVA.TabStop = false;
            this.groupBoxTask_YVA.Text = "Условие:";
            // 
            // textBoxTask_YVA
            // 
            this.textBoxTask_YVA.Location = new System.Drawing.Point(7, 20);
            this.textBoxTask_YVA.Multiline = true;
            this.textBoxTask_YVA.Name = "textBoxTask_YVA";
            this.textBoxTask_YVA.ReadOnly = true;
            this.textBoxTask_YVA.Size = new System.Drawing.Size(397, 64);
            this.textBoxTask_YVA.TabIndex = 0;
            this.textBoxTask_YVA.Text = "Прочитать данные из InPutFileTask5V3.txt. Вывести в dataGridView\r\nвещественные зн" +
    "ачения и построить диаграмму по этим значениям.";
            // 
            // buttonDone_YVA
            // 
            this.buttonDone_YVA.BackColor = System.Drawing.Color.Green;
            this.buttonDone_YVA.Location = new System.Drawing.Point(421, 13);
            this.buttonDone_YVA.Name = "buttonDone_YVA";
            this.buttonDone_YVA.Size = new System.Drawing.Size(75, 75);
            this.buttonDone_YVA.TabIndex = 1;
            this.buttonDone_YVA.Text = "Выполнить";
            this.buttonDone_YVA.UseVisualStyleBackColor = false;
            this.buttonDone_YVA.Click += new System.EventHandler(this.buttonDone_YVA_Click);
            // 
            // buttonOpenFile_YVA
            // 
            this.buttonOpenFile_YVA.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonOpenFile_YVA.Location = new System.Drawing.Point(502, 13);
            this.buttonOpenFile_YVA.Name = "buttonOpenFile_YVA";
            this.buttonOpenFile_YVA.Size = new System.Drawing.Size(75, 75);
            this.buttonOpenFile_YVA.TabIndex = 1;
            this.buttonOpenFile_YVA.Text = "Открыть файл";
            this.buttonOpenFile_YVA.UseVisualStyleBackColor = false;
            this.buttonOpenFile_YVA.Click += new System.EventHandler(this.buttonOpenFile_YVA_Click);
            // 
            // buttonHelp_YVA
            // 
            this.buttonHelp_YVA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_YVA.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonHelp_YVA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_YVA.Location = new System.Drawing.Point(606, 12);
            this.buttonHelp_YVA.Name = "buttonHelp_YVA";
            this.buttonHelp_YVA.Size = new System.Drawing.Size(75, 75);
            this.buttonHelp_YVA.TabIndex = 1;
            this.buttonHelp_YVA.Text = "Справка";
            this.buttonHelp_YVA.UseVisualStyleBackColor = false;
            this.buttonHelp_YVA.Click += new System.EventHandler(this.buttonHelp_YVA_Click);
            // 
            // groupBoxOutPutData_YVA
            // 
            this.groupBoxOutPutData_YVA.Controls.Add(this.dataGridViewOutPutData_YVA);
            this.groupBoxOutPutData_YVA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutPutData_YVA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOutPutData_YVA.Name = "groupBoxOutPutData_YVA";
            this.groupBoxOutPutData_YVA.Size = new System.Drawing.Size(200, 382);
            this.groupBoxOutPutData_YVA.TabIndex = 0;
            this.groupBoxOutPutData_YVA.TabStop = false;
            this.groupBoxOutPutData_YVA.Text = "Вывод данных:";
            // 
            // dataGridViewOutPutData_YVA
            // 
            this.dataGridViewOutPutData_YVA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutPutData_YVA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOutPutData_YVA.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewOutPutData_YVA.Name = "dataGridViewOutPutData_YVA";
            this.dataGridViewOutPutData_YVA.ReadOnly = true;
            this.dataGridViewOutPutData_YVA.RowHeadersVisible = false;
            this.dataGridViewOutPutData_YVA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewOutPutData_YVA.Size = new System.Drawing.Size(194, 363);
            this.dataGridViewOutPutData_YVA.TabIndex = 0;
            // 
            // chartFunction_YVA
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFunction_YVA.ChartAreas.Add(chartArea1);
            this.chartFunction_YVA.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartFunction_YVA.Legends.Add(legend1);
            this.chartFunction_YVA.Location = new System.Drawing.Point(0, 0);
            this.chartFunction_YVA.Name = "chartFunction_YVA";
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFunction_YVA.Series.Add(series1);
            this.chartFunction_YVA.Size = new System.Drawing.Size(490, 382);
            this.chartFunction_YVA.TabIndex = 0;
            this.chartFunction_YVA.Text = "chart1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 482);
            this.Controls.Add(this.panelFill_YVA);
            this.Controls.Add(this.splitterMain_YVA);
            this.Controls.Add(this.panelLeft_YVA);
            this.Controls.Add(this.panelTop_YVA);
            this.MinimumSize = new System.Drawing.Size(709, 521);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 5 | Вариант 3 | Ягодин В.А.";
            this.panelTop_YVA.ResumeLayout(false);
            this.panelLeft_YVA.ResumeLayout(false);
            this.panelFill_YVA.ResumeLayout(false);
            this.groupBoxTask_YVA.ResumeLayout(false);
            this.groupBoxTask_YVA.PerformLayout();
            this.groupBoxOutPutData_YVA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPutData_YVA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_YVA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop_YVA;
        private System.Windows.Forms.Panel panelLeft_YVA;
        private System.Windows.Forms.Splitter splitterMain_YVA;
        private System.Windows.Forms.Panel panelFill_YVA;
        private System.Windows.Forms.GroupBox groupBoxTask_YVA;
        private System.Windows.Forms.TextBox textBoxTask_YVA;
        private System.Windows.Forms.Button buttonHelp_YVA;
        private System.Windows.Forms.Button buttonOpenFile_YVA;
        private System.Windows.Forms.Button buttonDone_YVA;
        private System.Windows.Forms.GroupBox groupBoxOutPutData_YVA;
        private System.Windows.Forms.DataGridView dataGridViewOutPutData_YVA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_YVA;
    }
}

