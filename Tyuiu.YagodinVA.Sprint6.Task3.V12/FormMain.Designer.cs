
namespace Tyuiu.YagodinVA.Sprint6.Task3.V12
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupBoxTask_YVA = new System.Windows.Forms.GroupBox();
            this.textBoxTask_YVA = new System.Windows.Forms.TextBox();
            this.groupBoxOutPutData_YVA = new System.Windows.Forms.GroupBox();
            this.dataGridViewInPutData_YVA = new System.Windows.Forms.DataGridView();
            this.dataGridViewOutPutData_YVA = new System.Windows.Forms.DataGridView();
            this.buttonHelp_YVA = new System.Windows.Forms.Button();
            this.buttonDone_YVA = new System.Windows.Forms.Button();
            this.groupBoxTask_YVA.SuspendLayout();
            this.groupBoxOutPutData_YVA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInPutData_YVA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPutData_YVA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_YVA
            // 
            this.groupBoxTask_YVA.Controls.Add(this.dataGridViewInPutData_YVA);
            this.groupBoxTask_YVA.Controls.Add(this.textBoxTask_YVA);
            this.groupBoxTask_YVA.Location = new System.Drawing.Point(13, 13);
            this.groupBoxTask_YVA.Name = "groupBoxTask_YVA";
            this.groupBoxTask_YVA.Size = new System.Drawing.Size(599, 425);
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
            this.textBoxTask_YVA.Size = new System.Drawing.Size(234, 393);
            this.textBoxTask_YVA.TabIndex = 0;
            this.textBoxTask_YVA.Text = resources.GetString("textBoxTask_YVA.Text");
            // 
            // groupBoxOutPutData_YVA
            // 
            this.groupBoxOutPutData_YVA.Controls.Add(this.dataGridViewOutPutData_YVA);
            this.groupBoxOutPutData_YVA.Location = new System.Drawing.Point(618, 13);
            this.groupBoxOutPutData_YVA.Name = "groupBoxOutPutData_YVA";
            this.groupBoxOutPutData_YVA.Size = new System.Drawing.Size(397, 323);
            this.groupBoxOutPutData_YVA.TabIndex = 1;
            this.groupBoxOutPutData_YVA.TabStop = false;
            this.groupBoxOutPutData_YVA.Text = "Вывод данных";
            // 
            // dataGridViewInPutData_YVA
            // 
            this.dataGridViewInPutData_YVA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInPutData_YVA.Location = new System.Drawing.Point(248, 26);
            this.dataGridViewInPutData_YVA.Name = "dataGridViewInPutData_YVA";
            this.dataGridViewInPutData_YVA.ReadOnly = true;
            this.dataGridViewInPutData_YVA.RowHeadersVisible = false;
            this.dataGridViewInPutData_YVA.RowHeadersWidth = 62;
            this.dataGridViewInPutData_YVA.RowTemplate.Height = 28;
            this.dataGridViewInPutData_YVA.Size = new System.Drawing.Size(345, 393);
            this.dataGridViewInPutData_YVA.TabIndex = 1;
            // 
            // dataGridViewOutPutData_YVA
            // 
            this.dataGridViewOutPutData_YVA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutPutData_YVA.Location = new System.Drawing.Point(6, 26);
            this.dataGridViewOutPutData_YVA.Name = "dataGridViewOutPutData_YVA";
            this.dataGridViewOutPutData_YVA.ReadOnly = true;
            this.dataGridViewOutPutData_YVA.RowHeadersVisible = false;
            this.dataGridViewOutPutData_YVA.RowHeadersWidth = 62;
            this.dataGridViewOutPutData_YVA.RowTemplate.Height = 28;
            this.dataGridViewOutPutData_YVA.Size = new System.Drawing.Size(381, 284);
            this.dataGridViewOutPutData_YVA.TabIndex = 1;
            // 
            // buttonHelp_YVA
            // 
            this.buttonHelp_YVA.Location = new System.Drawing.Point(737, 385);
            this.buttonHelp_YVA.Name = "buttonHelp_YVA";
            this.buttonHelp_YVA.Size = new System.Drawing.Size(50, 47);
            this.buttonHelp_YVA.TabIndex = 2;
            this.buttonHelp_YVA.Text = "?";
            this.buttonHelp_YVA.UseVisualStyleBackColor = true;
            this.buttonHelp_YVA.Click += new System.EventHandler(this.buttonHelp_YVA_Click);
            // 
            // buttonDone_YVA
            // 
            this.buttonDone_YVA.Location = new System.Drawing.Point(793, 385);
            this.buttonDone_YVA.Name = "buttonDone_YVA";
            this.buttonDone_YVA.Size = new System.Drawing.Size(212, 47);
            this.buttonDone_YVA.TabIndex = 2;
            this.buttonDone_YVA.Text = "Выполнить";
            this.buttonDone_YVA.UseVisualStyleBackColor = true;
            this.buttonDone_YVA.Click += new System.EventHandler(this.buttonDone_YVA_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 450);
            this.Controls.Add(this.buttonDone_YVA);
            this.Controls.Add(this.buttonHelp_YVA);
            this.Controls.Add(this.groupBoxOutPutData_YVA);
            this.Controls.Add(this.groupBoxTask_YVA);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 3 | Вариант 12 | Ягодин В.А. ";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxTask_YVA.ResumeLayout(false);
            this.groupBoxTask_YVA.PerformLayout();
            this.groupBoxOutPutData_YVA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInPutData_YVA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPutData_YVA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_YVA;
        private System.Windows.Forms.TextBox textBoxTask_YVA;
        private System.Windows.Forms.DataGridView dataGridViewInPutData_YVA;
        private System.Windows.Forms.GroupBox groupBoxOutPutData_YVA;
        private System.Windows.Forms.DataGridView dataGridViewOutPutData_YVA;
        private System.Windows.Forms.Button buttonHelp_YVA;
        private System.Windows.Forms.Button buttonDone_YVA;
    }
}

