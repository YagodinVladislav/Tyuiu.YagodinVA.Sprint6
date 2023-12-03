
namespace Tyuiu.YagodinVA.Sprint6.Task2.V4
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
            this.groupBoxTask_YVA = new System.Windows.Forms.GroupBox();
            this.textBoxTask_YVA = new System.Windows.Forms.TextBox();
            this.groupBoxInPutData_YVA = new System.Windows.Forms.GroupBox();
            this.labelStartStep_YVA = new System.Windows.Forms.Label();
            this.labelStopStep_YVA = new System.Windows.Forms.Label();
            this.textBoxStartStep_YVA = new System.Windows.Forms.TextBox();
            this.textBoxStopStep_YVA = new System.Windows.Forms.TextBox();
            this.buttonHelp_YVA = new System.Windows.Forms.Button();
            this.buttonDone_YVA = new System.Windows.Forms.Button();
            this.groupBoxOutPutData_YVA = new System.Windows.Forms.GroupBox();
            this.dataGridViewFunction_YVA = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chartFunction_YVA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxTask_YVA.SuspendLayout();
            this.groupBoxInPutData_YVA.SuspendLayout();
            this.groupBoxOutPutData_YVA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_YVA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_YVA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_YVA
            // 
            this.groupBoxTask_YVA.Controls.Add(this.textBoxTask_YVA);
            this.groupBoxTask_YVA.Location = new System.Drawing.Point(13, 13);
            this.groupBoxTask_YVA.Name = "groupBoxTask_YVA";
            this.groupBoxTask_YVA.Size = new System.Drawing.Size(544, 317);
            this.groupBoxTask_YVA.TabIndex = 0;
            this.groupBoxTask_YVA.TabStop = false;
            this.groupBoxTask_YVA.Text = "Условие";
            // 
            // textBoxTask_YVA
            // 
            this.textBoxTask_YVA.Location = new System.Drawing.Point(7, 26);
            this.textBoxTask_YVA.Multiline = true;
            this.textBoxTask_YVA.Name = "textBoxTask_YVA";
            this.textBoxTask_YVA.ReadOnly = true;
            this.textBoxTask_YVA.Size = new System.Drawing.Size(531, 285);
            this.textBoxTask_YVA.TabIndex = 0;
            this.textBoxTask_YVA.Text = "Протабулировать функцию f(x) на заданном диапазоне.\r\nРезультат вывести в DataGrin" +
    "dView и построить график функции.";
            // 
            // groupBoxInPutData_YVA
            // 
            this.groupBoxInPutData_YVA.Controls.Add(this.textBoxStopStep_YVA);
            this.groupBoxInPutData_YVA.Controls.Add(this.textBoxStartStep_YVA);
            this.groupBoxInPutData_YVA.Controls.Add(this.labelStopStep_YVA);
            this.groupBoxInPutData_YVA.Controls.Add(this.labelStartStep_YVA);
            this.groupBoxInPutData_YVA.Location = new System.Drawing.Point(20, 336);
            this.groupBoxInPutData_YVA.Name = "groupBoxInPutData_YVA";
            this.groupBoxInPutData_YVA.Size = new System.Drawing.Size(294, 102);
            this.groupBoxInPutData_YVA.TabIndex = 1;
            this.groupBoxInPutData_YVA.TabStop = false;
            this.groupBoxInPutData_YVA.Text = "Ввод данных";
            // 
            // labelStartStep_YVA
            // 
            this.labelStartStep_YVA.AutoSize = true;
            this.labelStartStep_YVA.Location = new System.Drawing.Point(7, 26);
            this.labelStartStep_YVA.Name = "labelStartStep_YVA";
            this.labelStartStep_YVA.Size = new System.Drawing.Size(102, 20);
            this.labelStartStep_YVA.TabIndex = 0;
            this.labelStartStep_YVA.Text = "Старт шага:";
            // 
            // labelStopStep_YVA
            // 
            this.labelStopStep_YVA.AutoSize = true;
            this.labelStopStep_YVA.Location = new System.Drawing.Point(140, 26);
            this.labelStopStep_YVA.Name = "labelStopStep_YVA";
            this.labelStopStep_YVA.Size = new System.Drawing.Size(101, 20);
            this.labelStopStep_YVA.TabIndex = 0;
            this.labelStopStep_YVA.Text = "Конец шага:";
            // 
            // textBoxStartStep_YVA
            // 
            this.textBoxStartStep_YVA.Location = new System.Drawing.Point(11, 60);
            this.textBoxStartStep_YVA.Name = "textBoxStartStep_YVA";
            this.textBoxStartStep_YVA.Size = new System.Drawing.Size(127, 26);
            this.textBoxStartStep_YVA.TabIndex = 1;
            this.textBoxStartStep_YVA.Text = "-5";
            this.textBoxStartStep_YVA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStartStep_YVA_KeyPress);
            // 
            // textBoxStopStep_YVA
            // 
            this.textBoxStopStep_YVA.Location = new System.Drawing.Point(144, 60);
            this.textBoxStopStep_YVA.Name = "textBoxStopStep_YVA";
            this.textBoxStopStep_YVA.Size = new System.Drawing.Size(127, 26);
            this.textBoxStopStep_YVA.TabIndex = 1;
            this.textBoxStopStep_YVA.Text = "5";
            this.textBoxStopStep_YVA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStartStep_YVA_KeyPress);
            // 
            // buttonHelp_YVA
            // 
            this.buttonHelp_YVA.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonHelp_YVA.Location = new System.Drawing.Point(321, 346);
            this.buttonHelp_YVA.Name = "buttonHelp_YVA";
            this.buttonHelp_YVA.Size = new System.Drawing.Size(95, 92);
            this.buttonHelp_YVA.TabIndex = 2;
            this.buttonHelp_YVA.Text = "Справка";
            this.buttonHelp_YVA.UseVisualStyleBackColor = false;
            this.buttonHelp_YVA.Click += new System.EventHandler(this.buttonHelp_YVA_Click);
            // 
            // buttonDone_YVA
            // 
            this.buttonDone_YVA.BackColor = System.Drawing.Color.Green;
            this.buttonDone_YVA.Location = new System.Drawing.Point(422, 346);
            this.buttonDone_YVA.Name = "buttonDone_YVA";
            this.buttonDone_YVA.Size = new System.Drawing.Size(129, 92);
            this.buttonDone_YVA.TabIndex = 2;
            this.buttonDone_YVA.Text = "Выполнить";
            this.buttonDone_YVA.UseVisualStyleBackColor = false;
            this.buttonDone_YVA.Click += new System.EventHandler(this.buttonDone_YVA_Click);
            this.buttonDone_YVA.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonDone_YVA_MouseDown);
            this.buttonDone_YVA.MouseEnter += new System.EventHandler(this.buttonDone_YVA_MouseEnter);
            this.buttonDone_YVA.MouseLeave += new System.EventHandler(this.buttonDone_YVA_MouseLeave);
            // 
            // groupBoxOutPutData_YVA
            // 
            this.groupBoxOutPutData_YVA.Controls.Add(this.chartFunction_YVA);
            this.groupBoxOutPutData_YVA.Controls.Add(this.dataGridViewFunction_YVA);
            this.groupBoxOutPutData_YVA.Location = new System.Drawing.Point(564, 13);
            this.groupBoxOutPutData_YVA.Name = "groupBoxOutPutData_YVA";
            this.groupBoxOutPutData_YVA.Size = new System.Drawing.Size(546, 425);
            this.groupBoxOutPutData_YVA.TabIndex = 3;
            this.groupBoxOutPutData_YVA.TabStop = false;
            this.groupBoxOutPutData_YVA.Text = "Вывод данных";
            // 
            // dataGridViewFunction_YVA
            // 
            this.dataGridViewFunction_YVA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFunction_YVA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Y});
            this.dataGridViewFunction_YVA.Location = new System.Drawing.Point(7, 26);
            this.dataGridViewFunction_YVA.Name = "dataGridViewFunction_YVA";
            this.dataGridViewFunction_YVA.ReadOnly = true;
            this.dataGridViewFunction_YVA.RowHeadersVisible = false;
            this.dataGridViewFunction_YVA.RowHeadersWidth = 62;
            this.dataGridViewFunction_YVA.RowTemplate.Height = 28;
            this.dataGridViewFunction_YVA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewFunction_YVA.Size = new System.Drawing.Size(208, 393);
            this.dataGridViewFunction_YVA.TabIndex = 0;
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.MinimumWidth = 8;
            this.X.Name = "X";
            this.X.ReadOnly = true;
            this.X.Width = 50;
            // 
            // Y
            // 
            this.Y.HeaderText = "F(X)";
            this.Y.MinimumWidth = 8;
            this.Y.Name = "Y";
            this.Y.ReadOnly = true;
            this.Y.Width = 50;
            // 
            // chartFunction_YVA
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFunction_YVA.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartFunction_YVA.Legends.Add(legend1);
            this.chartFunction_YVA.Location = new System.Drawing.Point(221, 26);
            this.chartFunction_YVA.Name = "chartFunction_YVA";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFunction_YVA.Series.Add(series1);
            this.chartFunction_YVA.Size = new System.Drawing.Size(318, 393);
            this.chartFunction_YVA.TabIndex = 1;
            this.chartFunction_YVA.Text = "chart1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 450);
            this.Controls.Add(this.groupBoxOutPutData_YVA);
            this.Controls.Add(this.buttonDone_YVA);
            this.Controls.Add(this.buttonHelp_YVA);
            this.Controls.Add(this.groupBoxInPutData_YVA);
            this.Controls.Add(this.groupBoxTask_YVA);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 2 | Вариант 4 | Ягодин В.А.";
            this.groupBoxTask_YVA.ResumeLayout(false);
            this.groupBoxTask_YVA.PerformLayout();
            this.groupBoxInPutData_YVA.ResumeLayout(false);
            this.groupBoxInPutData_YVA.PerformLayout();
            this.groupBoxOutPutData_YVA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_YVA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_YVA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_YVA;
        private System.Windows.Forms.TextBox textBoxTask_YVA;
        private System.Windows.Forms.GroupBox groupBoxInPutData_YVA;
        private System.Windows.Forms.TextBox textBoxStopStep_YVA;
        private System.Windows.Forms.TextBox textBoxStartStep_YVA;
        private System.Windows.Forms.Label labelStopStep_YVA;
        private System.Windows.Forms.Label labelStartStep_YVA;
        private System.Windows.Forms.Button buttonHelp_YVA;
        private System.Windows.Forms.Button buttonDone_YVA;
        private System.Windows.Forms.GroupBox groupBoxOutPutData_YVA;
        private System.Windows.Forms.DataGridView dataGridViewFunction_YVA;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_YVA;
    }
}

