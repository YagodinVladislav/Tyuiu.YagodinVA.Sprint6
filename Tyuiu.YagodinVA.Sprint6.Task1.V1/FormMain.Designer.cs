
namespace Tyuiu.YagodinVA.Sprint6.Task1.V1
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
            this.groupBoxTask_YVA = new System.Windows.Forms.GroupBox();
            this.textBoxTask_YVA = new System.Windows.Forms.TextBox();
            this.groupBoxOutPutData_YVA = new System.Windows.Forms.GroupBox();
            this.textBoxResult_YVA = new System.Windows.Forms.TextBox();
            this.labelResult_YVA = new System.Windows.Forms.Label();
            this.groupBoxInPutData_YVA = new System.Windows.Forms.GroupBox();
            this.labelStopStep_YVA = new System.Windows.Forms.Label();
            this.labelStartStep_YVA = new System.Windows.Forms.Label();
            this.textBoxStopStep_YVA = new System.Windows.Forms.TextBox();
            this.textBoxStartStep_YVA = new System.Windows.Forms.TextBox();
            this.buttonHelp_YVA = new System.Windows.Forms.Button();
            this.buttonDone_YVA = new System.Windows.Forms.Button();
            this.groupBoxTask_YVA.SuspendLayout();
            this.groupBoxOutPutData_YVA.SuspendLayout();
            this.groupBoxInPutData_YVA.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask_YVA
            // 
            this.groupBoxTask_YVA.Controls.Add(this.textBoxTask_YVA);
            this.groupBoxTask_YVA.Location = new System.Drawing.Point(13, 13);
            this.groupBoxTask_YVA.Name = "groupBoxTask_YVA";
            this.groupBoxTask_YVA.Size = new System.Drawing.Size(598, 318);
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
            this.textBoxTask_YVA.Size = new System.Drawing.Size(585, 286);
            this.textBoxTask_YVA.TabIndex = 0;
            this.textBoxTask_YVA.Text = "Протабулировать функцию f(x) на заданном диапазоне.\r\nРезультат вывести в виде таб" +
    "лицы.";
            // 
            // groupBoxOutPutData_YVA
            // 
            this.groupBoxOutPutData_YVA.Controls.Add(this.textBoxResult_YVA);
            this.groupBoxOutPutData_YVA.Controls.Add(this.labelResult_YVA);
            this.groupBoxOutPutData_YVA.Location = new System.Drawing.Point(617, 13);
            this.groupBoxOutPutData_YVA.Name = "groupBoxOutPutData_YVA";
            this.groupBoxOutPutData_YVA.Size = new System.Drawing.Size(330, 425);
            this.groupBoxOutPutData_YVA.TabIndex = 1;
            this.groupBoxOutPutData_YVA.TabStop = false;
            this.groupBoxOutPutData_YVA.Text = "Вывод данных";
            // 
            // textBoxResult_YVA
            // 
            this.textBoxResult_YVA.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxResult_YVA.Location = new System.Drawing.Point(11, 50);
            this.textBoxResult_YVA.Multiline = true;
            this.textBoxResult_YVA.Name = "textBoxResult_YVA";
            this.textBoxResult_YVA.ReadOnly = true;
            this.textBoxResult_YVA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_YVA.Size = new System.Drawing.Size(313, 369);
            this.textBoxResult_YVA.TabIndex = 1;
            // 
            // labelResult_YVA
            // 
            this.labelResult_YVA.AutoSize = true;
            this.labelResult_YVA.Location = new System.Drawing.Point(7, 26);
            this.labelResult_YVA.Name = "labelResult_YVA";
            this.labelResult_YVA.Size = new System.Drawing.Size(93, 20);
            this.labelResult_YVA.TabIndex = 0;
            this.labelResult_YVA.Text = "Результат:";
            // 
            // groupBoxInPutData_YVA
            // 
            this.groupBoxInPutData_YVA.Controls.Add(this.labelStopStep_YVA);
            this.groupBoxInPutData_YVA.Controls.Add(this.labelStartStep_YVA);
            this.groupBoxInPutData_YVA.Controls.Add(this.textBoxStopStep_YVA);
            this.groupBoxInPutData_YVA.Controls.Add(this.textBoxStartStep_YVA);
            this.groupBoxInPutData_YVA.Location = new System.Drawing.Point(20, 338);
            this.groupBoxInPutData_YVA.Name = "groupBoxInPutData_YVA";
            this.groupBoxInPutData_YVA.Size = new System.Drawing.Size(337, 100);
            this.groupBoxInPutData_YVA.TabIndex = 2;
            this.groupBoxInPutData_YVA.TabStop = false;
            this.groupBoxInPutData_YVA.Text = "Ввод данных";
            // 
            // labelStopStep_YVA
            // 
            this.labelStopStep_YVA.AutoSize = true;
            this.labelStopStep_YVA.Location = new System.Drawing.Point(173, 26);
            this.labelStopStep_YVA.Name = "labelStopStep_YVA";
            this.labelStopStep_YVA.Size = new System.Drawing.Size(101, 20);
            this.labelStopStep_YVA.TabIndex = 1;
            this.labelStopStep_YVA.Text = "Конец шага:";
            // 
            // labelStartStep_YVA
            // 
            this.labelStartStep_YVA.AutoSize = true;
            this.labelStartStep_YVA.Location = new System.Drawing.Point(7, 26);
            this.labelStartStep_YVA.Name = "labelStartStep_YVA";
            this.labelStartStep_YVA.Size = new System.Drawing.Size(102, 20);
            this.labelStartStep_YVA.TabIndex = 1;
            this.labelStartStep_YVA.Text = "Старт шага:";
            // 
            // textBoxStopStep_YVA
            // 
            this.textBoxStopStep_YVA.Location = new System.Drawing.Point(177, 59);
            this.textBoxStopStep_YVA.Name = "textBoxStopStep_YVA";
            this.textBoxStopStep_YVA.Size = new System.Drawing.Size(146, 26);
            this.textBoxStopStep_YVA.TabIndex = 0;
            this.textBoxStopStep_YVA.Text = "5";
            this.textBoxStopStep_YVA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStartStep_YVA_KeyPress);
            // 
            // textBoxStartStep_YVA
            // 
            this.textBoxStartStep_YVA.Location = new System.Drawing.Point(6, 59);
            this.textBoxStartStep_YVA.Name = "textBoxStartStep_YVA";
            this.textBoxStartStep_YVA.Size = new System.Drawing.Size(146, 26);
            this.textBoxStartStep_YVA.TabIndex = 0;
            this.textBoxStartStep_YVA.Text = "-5";
            this.textBoxStartStep_YVA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStartStep_YVA_KeyPress);
            // 
            // buttonHelp_YVA
            // 
            this.buttonHelp_YVA.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonHelp_YVA.Location = new System.Drawing.Point(363, 338);
            this.buttonHelp_YVA.Name = "buttonHelp_YVA";
            this.buttonHelp_YVA.Size = new System.Drawing.Size(92, 100);
            this.buttonHelp_YVA.TabIndex = 3;
            this.buttonHelp_YVA.Text = "Справка";
            this.buttonHelp_YVA.UseVisualStyleBackColor = false;
            this.buttonHelp_YVA.Click += new System.EventHandler(this.buttonHelp_YVA_Click);
            // 
            // buttonDone_YVA
            // 
            this.buttonDone_YVA.BackColor = System.Drawing.Color.Green;
            this.buttonDone_YVA.Location = new System.Drawing.Point(461, 337);
            this.buttonDone_YVA.Name = "buttonDone_YVA";
            this.buttonDone_YVA.Size = new System.Drawing.Size(144, 100);
            this.buttonDone_YVA.TabIndex = 3;
            this.buttonDone_YVA.Text = "Выполнить";
            this.buttonDone_YVA.UseVisualStyleBackColor = false;
            this.buttonDone_YVA.Click += new System.EventHandler(this.buttonDone_YVA_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 450);
            this.Controls.Add(this.buttonDone_YVA);
            this.Controls.Add(this.buttonHelp_YVA);
            this.Controls.Add(this.groupBoxInPutData_YVA);
            this.Controls.Add(this.groupBoxOutPutData_YVA);
            this.Controls.Add(this.groupBoxTask_YVA);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 1 | Вариант 1 | Ягодин В.А.";
            this.groupBoxTask_YVA.ResumeLayout(false);
            this.groupBoxTask_YVA.PerformLayout();
            this.groupBoxOutPutData_YVA.ResumeLayout(false);
            this.groupBoxOutPutData_YVA.PerformLayout();
            this.groupBoxInPutData_YVA.ResumeLayout(false);
            this.groupBoxInPutData_YVA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_YVA;
        private System.Windows.Forms.TextBox textBoxTask_YVA;
        private System.Windows.Forms.GroupBox groupBoxOutPutData_YVA;
        private System.Windows.Forms.TextBox textBoxResult_YVA;
        private System.Windows.Forms.Label labelResult_YVA;
        private System.Windows.Forms.GroupBox groupBoxInPutData_YVA;
        private System.Windows.Forms.Label labelStopStep_YVA;
        private System.Windows.Forms.Label labelStartStep_YVA;
        private System.Windows.Forms.TextBox textBoxStopStep_YVA;
        private System.Windows.Forms.TextBox textBoxStartStep_YVA;
        private System.Windows.Forms.Button buttonHelp_YVA;
        private System.Windows.Forms.Button buttonDone_YVA;
    }
}

