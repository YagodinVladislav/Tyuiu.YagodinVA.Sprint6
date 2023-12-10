
namespace Tyuiu.YagodinVA.Sprint6.Task4.V21
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBoxTask_YVA = new System.Windows.Forms.GroupBox();
            this.textBoxTask_YVA = new System.Windows.Forms.TextBox();
            this.groupBoxInPutData_YVA = new System.Windows.Forms.GroupBox();
            this.textBoxStartIndex_YVA = new System.Windows.Forms.TextBox();
            this.textBoxStopIndex_YVA = new System.Windows.Forms.TextBox();
            this.labelStartIndex_YVA = new System.Windows.Forms.Label();
            this.labelStopIndex_YVA = new System.Windows.Forms.Label();
            this.buttonDone_YVA = new System.Windows.Forms.Button();
            this.buttonSave_YVA = new System.Windows.Forms.Button();
            this.buttonHelp_YVA = new System.Windows.Forms.Button();
            this.groupBoxOutPutData_YVA = new System.Windows.Forms.GroupBox();
            this.textBoxOutPutData_YVA = new System.Windows.Forms.TextBox();
            this.chartFunction_YVA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBoxTask_YVA.SuspendLayout();
            this.groupBoxInPutData_YVA.SuspendLayout();
            this.groupBoxOutPutData_YVA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_YVA)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.buttonHelp_YVA);
            this.panel1.Controls.Add(this.buttonSave_YVA);
            this.panel1.Controls.Add(this.buttonDone_YVA);
            this.panel1.Controls.Add(this.groupBoxInPutData_YVA);
            this.panel1.Controls.Add(this.groupBoxTask_YVA);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(918, 100);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.groupBoxOutPutData_YVA);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 302);
            this.panel2.TabIndex = 2;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(200, 100);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 302);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Controls.Add(this.chartFunction_YVA);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(203, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(715, 302);
            this.panel3.TabIndex = 4;
            // 
            // groupBoxTask_YVA
            // 
            this.groupBoxTask_YVA.Controls.Add(this.textBoxTask_YVA);
            this.groupBoxTask_YVA.Location = new System.Drawing.Point(4, 4);
            this.groupBoxTask_YVA.Name = "groupBoxTask_YVA";
            this.groupBoxTask_YVA.Size = new System.Drawing.Size(397, 90);
            this.groupBoxTask_YVA.TabIndex = 0;
            this.groupBoxTask_YVA.TabStop = false;
            this.groupBoxTask_YVA.Text = "Условие:";
            // 
            // textBoxTask_YVA
            // 
            this.textBoxTask_YVA.Location = new System.Drawing.Point(9, 20);
            this.textBoxTask_YVA.Multiline = true;
            this.textBoxTask_YVA.Name = "textBoxTask_YVA";
            this.textBoxTask_YVA.ReadOnly = true;
            this.textBoxTask_YVA.Size = new System.Drawing.Size(382, 64);
            this.textBoxTask_YVA.TabIndex = 0;
            this.textBoxTask_YVA.Text = "Написать программу которая выводит таблицу значений функции f(x).\r\nРезультат выве" +
    "сти в textBox. Построить график функции.\r\nСохранить в файл OutPutFileTask4V21.tx" +
    "t по нажатию кнопки.";
            // 
            // groupBoxInPutData_YVA
            // 
            this.groupBoxInPutData_YVA.Controls.Add(this.labelStopIndex_YVA);
            this.groupBoxInPutData_YVA.Controls.Add(this.labelStartIndex_YVA);
            this.groupBoxInPutData_YVA.Controls.Add(this.textBoxStopIndex_YVA);
            this.groupBoxInPutData_YVA.Controls.Add(this.textBoxStartIndex_YVA);
            this.groupBoxInPutData_YVA.Location = new System.Drawing.Point(408, 4);
            this.groupBoxInPutData_YVA.Name = "groupBoxInPutData_YVA";
            this.groupBoxInPutData_YVA.Size = new System.Drawing.Size(211, 90);
            this.groupBoxInPutData_YVA.TabIndex = 1;
            this.groupBoxInPutData_YVA.TabStop = false;
            this.groupBoxInPutData_YVA.Text = "Ввод данных:";
            // 
            // textBoxStartIndex_YVA
            // 
            this.textBoxStartIndex_YVA.Location = new System.Drawing.Point(7, 63);
            this.textBoxStartIndex_YVA.Name = "textBoxStartIndex_YVA";
            this.textBoxStartIndex_YVA.Size = new System.Drawing.Size(80, 20);
            this.textBoxStartIndex_YVA.TabIndex = 0;
            this.textBoxStartIndex_YVA.Text = "-5";
            // 
            // textBoxStopIndex_YVA
            // 
            this.textBoxStopIndex_YVA.Location = new System.Drawing.Point(125, 63);
            this.textBoxStopIndex_YVA.Name = "textBoxStopIndex_YVA";
            this.textBoxStopIndex_YVA.Size = new System.Drawing.Size(80, 20);
            this.textBoxStopIndex_YVA.TabIndex = 0;
            this.textBoxStopIndex_YVA.Text = "5";
            // 
            // labelStartIndex_YVA
            // 
            this.labelStartIndex_YVA.AutoSize = true;
            this.labelStartIndex_YVA.Location = new System.Drawing.Point(4, 44);
            this.labelStartIndex_YVA.Name = "labelStartIndex_YVA";
            this.labelStartIndex_YVA.Size = new System.Drawing.Size(67, 13);
            this.labelStartIndex_YVA.TabIndex = 1;
            this.labelStartIndex_YVA.Text = "Старт шага:";
            // 
            // labelStopIndex_YVA
            // 
            this.labelStopIndex_YVA.AutoSize = true;
            this.labelStopIndex_YVA.Location = new System.Drawing.Point(122, 44);
            this.labelStopIndex_YVA.Name = "labelStopIndex_YVA";
            this.labelStopIndex_YVA.Size = new System.Drawing.Size(69, 13);
            this.labelStopIndex_YVA.TabIndex = 1;
            this.labelStopIndex_YVA.Text = "Конец шага:";
            // 
            // buttonDone_YVA
            // 
            this.buttonDone_YVA.BackColor = System.Drawing.Color.Green;
            this.buttonDone_YVA.Location = new System.Drawing.Point(626, 13);
            this.buttonDone_YVA.Name = "buttonDone_YVA";
            this.buttonDone_YVA.Size = new System.Drawing.Size(75, 74);
            this.buttonDone_YVA.TabIndex = 2;
            this.buttonDone_YVA.Text = "Выполнить";
            this.buttonDone_YVA.UseVisualStyleBackColor = false;
            this.buttonDone_YVA.Click += new System.EventHandler(this.buttonDone_YVA_Click);
            // 
            // buttonSave_YVA
            // 
            this.buttonSave_YVA.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonSave_YVA.Location = new System.Drawing.Point(707, 13);
            this.buttonSave_YVA.Name = "buttonSave_YVA";
            this.buttonSave_YVA.Size = new System.Drawing.Size(75, 74);
            this.buttonSave_YVA.TabIndex = 2;
            this.buttonSave_YVA.Text = "Сохранить";
            this.buttonSave_YVA.UseVisualStyleBackColor = false;
            this.buttonSave_YVA.Click += new System.EventHandler(this.buttonSave_YVA_Click);
            // 
            // buttonHelp_YVA
            // 
            this.buttonHelp_YVA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_YVA.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonHelp_YVA.Location = new System.Drawing.Point(831, 13);
            this.buttonHelp_YVA.Name = "buttonHelp_YVA";
            this.buttonHelp_YVA.Size = new System.Drawing.Size(75, 74);
            this.buttonHelp_YVA.TabIndex = 2;
            this.buttonHelp_YVA.Text = "Справка";
            this.buttonHelp_YVA.UseVisualStyleBackColor = false;
            this.buttonHelp_YVA.Click += new System.EventHandler(this.buttonHelp_YVA_Click);
            // 
            // groupBoxOutPutData_YVA
            // 
            this.groupBoxOutPutData_YVA.Controls.Add(this.textBoxOutPutData_YVA);
            this.groupBoxOutPutData_YVA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutPutData_YVA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOutPutData_YVA.Name = "groupBoxOutPutData_YVA";
            this.groupBoxOutPutData_YVA.Size = new System.Drawing.Size(200, 302);
            this.groupBoxOutPutData_YVA.TabIndex = 0;
            this.groupBoxOutPutData_YVA.TabStop = false;
            this.groupBoxOutPutData_YVA.Text = "Вывод данных:";
            // 
            // textBoxOutPutData_YVA
            // 
            this.textBoxOutPutData_YVA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxOutPutData_YVA.Location = new System.Drawing.Point(3, 16);
            this.textBoxOutPutData_YVA.Multiline = true;
            this.textBoxOutPutData_YVA.Name = "textBoxOutPutData_YVA";
            this.textBoxOutPutData_YVA.ReadOnly = true;
            this.textBoxOutPutData_YVA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOutPutData_YVA.Size = new System.Drawing.Size(194, 283);
            this.textBoxOutPutData_YVA.TabIndex = 0;
            // 
            // chartFunction_YVA
            // 
            chartArea2.Name = "ChartArea1";
            this.chartFunction_YVA.ChartAreas.Add(chartArea2);
            this.chartFunction_YVA.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chartFunction_YVA.Legends.Add(legend2);
            this.chartFunction_YVA.Location = new System.Drawing.Point(0, 0);
            this.chartFunction_YVA.Name = "chartFunction_YVA";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartFunction_YVA.Series.Add(series2);
            this.chartFunction_YVA.Size = new System.Drawing.Size(715, 302);
            this.chartFunction_YVA.TabIndex = 0;
            this.chartFunction_YVA.Text = "chart1";
            title2.Name = "TitleF(X)";
            title2.Text = "График функции f(x)";
            this.chartFunction_YVA.Titles.Add(title2);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 402);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(934, 441);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 4 | Вариант 21 | Ягодин В.А.";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBoxTask_YVA.ResumeLayout(false);
            this.groupBoxTask_YVA.PerformLayout();
            this.groupBoxInPutData_YVA.ResumeLayout(false);
            this.groupBoxInPutData_YVA.PerformLayout();
            this.groupBoxOutPutData_YVA.ResumeLayout(false);
            this.groupBoxOutPutData_YVA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_YVA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonDone_YVA;
        private System.Windows.Forms.GroupBox groupBoxInPutData_YVA;
        private System.Windows.Forms.Label labelStopIndex_YVA;
        private System.Windows.Forms.Label labelStartIndex_YVA;
        private System.Windows.Forms.TextBox textBoxStopIndex_YVA;
        private System.Windows.Forms.TextBox textBoxStartIndex_YVA;
        private System.Windows.Forms.GroupBox groupBoxTask_YVA;
        private System.Windows.Forms.TextBox textBoxTask_YVA;
        private System.Windows.Forms.Button buttonHelp_YVA;
        private System.Windows.Forms.Button buttonSave_YVA;
        private System.Windows.Forms.GroupBox groupBoxOutPutData_YVA;
        private System.Windows.Forms.TextBox textBoxOutPutData_YVA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_YVA;
    }
}

