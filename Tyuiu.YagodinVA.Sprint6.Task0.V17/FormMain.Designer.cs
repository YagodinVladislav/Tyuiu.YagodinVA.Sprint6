
namespace Tyuiu.YagodinVA.Sprint6.Task0.V17
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
            this.pictureBoxFormula_YVA = new System.Windows.Forms.PictureBox();
            this.textBoxTask_YVA = new System.Windows.Forms.TextBox();
            this.groupBoxInPutData_YVA = new System.Windows.Forms.GroupBox();
            this.labelVarX_YVA = new System.Windows.Forms.Label();
            this.textBoxVarX_YVA = new System.Windows.Forms.TextBox();
            this.groupBoxOutPutData_YVA = new System.Windows.Forms.GroupBox();
            this.labelResult_YVA = new System.Windows.Forms.Label();
            this.textBoxResult_YVA = new System.Windows.Forms.TextBox();
            this.buttonHelp_YVA = new System.Windows.Forms.Button();
            this.buttonDone_YVA = new System.Windows.Forms.Button();
            this.groupBoxTask_YVA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_YVA)).BeginInit();
            this.groupBoxInPutData_YVA.SuspendLayout();
            this.groupBoxOutPutData_YVA.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask_YVA
            // 
            this.groupBoxTask_YVA.Controls.Add(this.pictureBoxFormula_YVA);
            this.groupBoxTask_YVA.Controls.Add(this.textBoxTask_YVA);
            this.groupBoxTask_YVA.Location = new System.Drawing.Point(12, 10);
            this.groupBoxTask_YVA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxTask_YVA.Name = "groupBoxTask_YVA";
            this.groupBoxTask_YVA.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxTask_YVA.Size = new System.Drawing.Size(689, 220);
            this.groupBoxTask_YVA.TabIndex = 0;
            this.groupBoxTask_YVA.TabStop = false;
            this.groupBoxTask_YVA.Text = "Условие";
            // 
            // pictureBoxFormula_YVA
            // 
            this.pictureBoxFormula_YVA.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFormula_YVA.Image")));
            this.pictureBoxFormula_YVA.Location = new System.Drawing.Point(580, 29);
            this.pictureBoxFormula_YVA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxFormula_YVA.Name = "pictureBoxFormula_YVA";
            this.pictureBoxFormula_YVA.Size = new System.Drawing.Size(91, 62);
            this.pictureBoxFormula_YVA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFormula_YVA.TabIndex = 1;
            this.pictureBoxFormula_YVA.TabStop = false;
            // 
            // textBoxTask_YVA
            // 
            this.textBoxTask_YVA.Location = new System.Drawing.Point(6, 21);
            this.textBoxTask_YVA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxTask_YVA.Multiline = true;
            this.textBoxTask_YVA.Name = "textBoxTask_YVA";
            this.textBoxTask_YVA.ReadOnly = true;
            this.textBoxTask_YVA.Size = new System.Drawing.Size(678, 195);
            this.textBoxTask_YVA.TabIndex = 0;
            this.textBoxTask_YVA.Text = "Вычислить выражение по формуле.";
            // 
            // groupBoxInPutData_YVA
            // 
            this.groupBoxInPutData_YVA.Controls.Add(this.labelVarX_YVA);
            this.groupBoxInPutData_YVA.Controls.Add(this.textBoxVarX_YVA);
            this.groupBoxInPutData_YVA.Location = new System.Drawing.Point(12, 231);
            this.groupBoxInPutData_YVA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxInPutData_YVA.Name = "groupBoxInPutData_YVA";
            this.groupBoxInPutData_YVA.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxInPutData_YVA.Size = new System.Drawing.Size(441, 80);
            this.groupBoxInPutData_YVA.TabIndex = 1;
            this.groupBoxInPutData_YVA.TabStop = false;
            this.groupBoxInPutData_YVA.Text = "Ввод данных";
            // 
            // labelVarX_YVA
            // 
            this.labelVarX_YVA.AutoSize = true;
            this.labelVarX_YVA.Location = new System.Drawing.Point(14, 29);
            this.labelVarX_YVA.Name = "labelVarX_YVA";
            this.labelVarX_YVA.Size = new System.Drawing.Size(108, 17);
            this.labelVarX_YVA.TabIndex = 1;
            this.labelVarX_YVA.Text = "Переменная X:";
            // 
            // textBoxVarX_YVA
            // 
            this.textBoxVarX_YVA.Location = new System.Drawing.Point(18, 47);
            this.textBoxVarX_YVA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxVarX_YVA.Name = "textBoxVarX_YVA";
            this.textBoxVarX_YVA.Size = new System.Drawing.Size(119, 22);
            this.textBoxVarX_YVA.TabIndex = 0;
            this.textBoxVarX_YVA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVarX_YVA_KeyPress);
            // 
            // groupBoxOutPutData_YVA
            // 
            this.groupBoxOutPutData_YVA.Controls.Add(this.labelResult_YVA);
            this.groupBoxOutPutData_YVA.Controls.Add(this.textBoxResult_YVA);
            this.groupBoxOutPutData_YVA.Location = new System.Drawing.Point(458, 231);
            this.groupBoxOutPutData_YVA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxOutPutData_YVA.Name = "groupBoxOutPutData_YVA";
            this.groupBoxOutPutData_YVA.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxOutPutData_YVA.Size = new System.Drawing.Size(243, 80);
            this.groupBoxOutPutData_YVA.TabIndex = 2;
            this.groupBoxOutPutData_YVA.TabStop = false;
            this.groupBoxOutPutData_YVA.Text = "Вывод данных";
            // 
            // labelResult_YVA
            // 
            this.labelResult_YVA.AutoSize = true;
            this.labelResult_YVA.Location = new System.Drawing.Point(16, 29);
            this.labelResult_YVA.Name = "labelResult_YVA";
            this.labelResult_YVA.Size = new System.Drawing.Size(80, 17);
            this.labelResult_YVA.TabIndex = 1;
            this.labelResult_YVA.Text = "Результат:";
            // 
            // textBoxResult_YVA
            // 
            this.textBoxResult_YVA.Location = new System.Drawing.Point(20, 47);
            this.textBoxResult_YVA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxResult_YVA.Name = "textBoxResult_YVA";
            this.textBoxResult_YVA.ReadOnly = true;
            this.textBoxResult_YVA.Size = new System.Drawing.Size(119, 22);
            this.textBoxResult_YVA.TabIndex = 0;
            // 
            // buttonHelp_YVA
            // 
            this.buttonHelp_YVA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_YVA.Location = new System.Drawing.Point(458, 316);
            this.buttonHelp_YVA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonHelp_YVA.Name = "buttonHelp_YVA";
            this.buttonHelp_YVA.Size = new System.Drawing.Size(55, 34);
            this.buttonHelp_YVA.TabIndex = 3;
            this.buttonHelp_YVA.Text = "?";
            this.buttonHelp_YVA.UseVisualStyleBackColor = true;
            this.buttonHelp_YVA.Click += new System.EventHandler(this.buttonHelp_YVA_Click);
            // 
            // buttonDone_YVA
            // 
            this.buttonDone_YVA.Location = new System.Drawing.Point(518, 316);
            this.buttonDone_YVA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDone_YVA.Name = "buttonDone_YVA";
            this.buttonDone_YVA.Size = new System.Drawing.Size(177, 34);
            this.buttonDone_YVA.TabIndex = 4;
            this.buttonDone_YVA.Text = "Выполнить";
            this.buttonDone_YVA.UseVisualStyleBackColor = true;
            this.buttonDone_YVA.Click += new System.EventHandler(this.buttonDone_YVA_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.buttonDone_YVA);
            this.Controls.Add(this.buttonHelp_YVA);
            this.Controls.Add(this.groupBoxOutPutData_YVA);
            this.Controls.Add(this.groupBoxInPutData_YVA);
            this.Controls.Add(this.groupBoxTask_YVA);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 0 | Вариант 17 | Ягодин В.А.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxTask_YVA.ResumeLayout(false);
            this.groupBoxTask_YVA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_YVA)).EndInit();
            this.groupBoxInPutData_YVA.ResumeLayout(false);
            this.groupBoxInPutData_YVA.PerformLayout();
            this.groupBoxOutPutData_YVA.ResumeLayout(false);
            this.groupBoxOutPutData_YVA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_YVA;
        private System.Windows.Forms.PictureBox pictureBoxFormula_YVA;
        private System.Windows.Forms.TextBox textBoxTask_YVA;
        private System.Windows.Forms.GroupBox groupBoxInPutData_YVA;
        private System.Windows.Forms.GroupBox groupBoxOutPutData_YVA;
        private System.Windows.Forms.Button buttonHelp_YVA;
        private System.Windows.Forms.Button buttonDone_YVA;
        private System.Windows.Forms.Label labelVarX_YVA;
        private System.Windows.Forms.TextBox textBoxVarX_YVA;
        private System.Windows.Forms.Label labelResult_YVA;
        private System.Windows.Forms.TextBox textBoxResult_YVA;
    }
}

