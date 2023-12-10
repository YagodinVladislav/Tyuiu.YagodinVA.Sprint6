
namespace Tyuiu.YagodinVA.Sprint6.Task6.V15
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelTop_YVA = new System.Windows.Forms.Panel();
            this.panelLeft_YVA = new System.Windows.Forms.Panel();
            this.splitterMain_YVA = new System.Windows.Forms.Splitter();
            this.panelFill_YVA = new System.Windows.Forms.Panel();
            this.buttonAbout_YVA = new System.Windows.Forms.Button();
            this.buttonOpenFile_YVA = new System.Windows.Forms.Button();
            this.buttonDone_YVA = new System.Windows.Forms.Button();
            this.groupBoxTask_YVA = new System.Windows.Forms.GroupBox();
            this.textBoxTask_YVA = new System.Windows.Forms.TextBox();
            this.groupBoxInPutData_YVA = new System.Windows.Forms.GroupBox();
            this.textBoxInPutData_YVA = new System.Windows.Forms.TextBox();
            this.groupBoxOutPutData_YVA = new System.Windows.Forms.GroupBox();
            this.textBoxOutPutData_YVA = new System.Windows.Forms.TextBox();
            this.openFileDialog_YVA = new System.Windows.Forms.OpenFileDialog();
            this.toolTip_YVA = new System.Windows.Forms.ToolTip(this.components);
            this.panelTop_YVA.SuspendLayout();
            this.panelLeft_YVA.SuspendLayout();
            this.panelFill_YVA.SuspendLayout();
            this.groupBoxTask_YVA.SuspendLayout();
            this.groupBoxInPutData_YVA.SuspendLayout();
            this.groupBoxOutPutData_YVA.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop_YVA
            // 
            this.panelTop_YVA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelTop_YVA.Controls.Add(this.groupBoxTask_YVA);
            this.panelTop_YVA.Controls.Add(this.buttonDone_YVA);
            this.panelTop_YVA.Controls.Add(this.buttonOpenFile_YVA);
            this.panelTop_YVA.Controls.Add(this.buttonAbout_YVA);
            this.panelTop_YVA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_YVA.Location = new System.Drawing.Point(0, 0);
            this.panelTop_YVA.Name = "panelTop_YVA";
            this.panelTop_YVA.Size = new System.Drawing.Size(800, 164);
            this.panelTop_YVA.TabIndex = 0;
            // 
            // panelLeft_YVA
            // 
            this.panelLeft_YVA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panelLeft_YVA.Controls.Add(this.groupBoxInPutData_YVA);
            this.panelLeft_YVA.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_YVA.Location = new System.Drawing.Point(0, 164);
            this.panelLeft_YVA.Name = "panelLeft_YVA";
            this.panelLeft_YVA.Size = new System.Drawing.Size(367, 286);
            this.panelLeft_YVA.TabIndex = 1;
            // 
            // splitterMain_YVA
            // 
            this.splitterMain_YVA.Location = new System.Drawing.Point(367, 164);
            this.splitterMain_YVA.Name = "splitterMain_YVA";
            this.splitterMain_YVA.Size = new System.Drawing.Size(3, 286);
            this.splitterMain_YVA.TabIndex = 2;
            this.splitterMain_YVA.TabStop = false;
            // 
            // panelFill_YVA
            // 
            this.panelFill_YVA.Controls.Add(this.groupBoxOutPutData_YVA);
            this.panelFill_YVA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFill_YVA.Location = new System.Drawing.Point(370, 164);
            this.panelFill_YVA.Name = "panelFill_YVA";
            this.panelFill_YVA.Size = new System.Drawing.Size(430, 286);
            this.panelFill_YVA.TabIndex = 3;
            // 
            // buttonAbout_YVA
            // 
            this.buttonAbout_YVA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAbout_YVA.Image = ((System.Drawing.Image)(resources.GetObject("buttonAbout_YVA.Image")));
            this.buttonAbout_YVA.Location = new System.Drawing.Point(705, 12);
            this.buttonAbout_YVA.Name = "buttonAbout_YVA";
            this.buttonAbout_YVA.Size = new System.Drawing.Size(83, 63);
            this.buttonAbout_YVA.TabIndex = 0;
            this.toolTip_YVA.SetToolTip(this.buttonAbout_YVA, "Сведения об авторе");
            this.buttonAbout_YVA.UseVisualStyleBackColor = true;
            this.buttonAbout_YVA.Click += new System.EventHandler(this.buttonAbout_YVA_Click);
            // 
            // buttonOpenFile_YVA
            // 
            this.buttonOpenFile_YVA.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile_YVA.Image")));
            this.buttonOpenFile_YVA.Location = new System.Drawing.Point(4, 4);
            this.buttonOpenFile_YVA.Name = "buttonOpenFile_YVA";
            this.buttonOpenFile_YVA.Size = new System.Drawing.Size(75, 71);
            this.buttonOpenFile_YVA.TabIndex = 1;
            this.toolTip_YVA.SetToolTip(this.buttonOpenFile_YVA, "Подсказка");
            this.buttonOpenFile_YVA.UseVisualStyleBackColor = true;
            this.buttonOpenFile_YVA.Click += new System.EventHandler(this.buttonOpenFile_YVA_Click);
            // 
            // buttonDone_YVA
            // 
            this.buttonDone_YVA.Enabled = false;
            this.buttonDone_YVA.Image = ((System.Drawing.Image)(resources.GetObject("buttonDone_YVA.Image")));
            this.buttonDone_YVA.Location = new System.Drawing.Point(85, 4);
            this.buttonDone_YVA.Name = "buttonDone_YVA";
            this.buttonDone_YVA.Size = new System.Drawing.Size(75, 71);
            this.buttonDone_YVA.TabIndex = 1;
            this.buttonDone_YVA.UseVisualStyleBackColor = true;
            this.buttonDone_YVA.Click += new System.EventHandler(this.buttonDone_YVA_Click);
            // 
            // groupBoxTask_YVA
            // 
            this.groupBoxTask_YVA.Controls.Add(this.textBoxTask_YVA);
            this.groupBoxTask_YVA.Location = new System.Drawing.Point(4, 81);
            this.groupBoxTask_YVA.Name = "groupBoxTask_YVA";
            this.groupBoxTask_YVA.Size = new System.Drawing.Size(793, 77);
            this.groupBoxTask_YVA.TabIndex = 2;
            this.groupBoxTask_YVA.TabStop = false;
            this.groupBoxTask_YVA.Text = "Условие:";
            // 
            // textBoxTask_YVA
            // 
            this.textBoxTask_YVA.Location = new System.Drawing.Point(7, 20);
            this.textBoxTask_YVA.Multiline = true;
            this.textBoxTask_YVA.Name = "textBoxTask_YVA";
            this.textBoxTask_YVA.ReadOnly = true;
            this.textBoxTask_YVA.Size = new System.Drawing.Size(780, 51);
            this.textBoxTask_YVA.TabIndex = 0;
            this.textBoxTask_YVA.Text = resources.GetString("textBoxTask_YVA.Text");
            // 
            // groupBoxInPutData_YVA
            // 
            this.groupBoxInPutData_YVA.Controls.Add(this.textBoxInPutData_YVA);
            this.groupBoxInPutData_YVA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxInPutData_YVA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxInPutData_YVA.Name = "groupBoxInPutData_YVA";
            this.groupBoxInPutData_YVA.Size = new System.Drawing.Size(367, 286);
            this.groupBoxInPutData_YVA.TabIndex = 0;
            this.groupBoxInPutData_YVA.TabStop = false;
            this.groupBoxInPutData_YVA.Text = "Ввод данных:";
            // 
            // textBoxInPutData_YVA
            // 
            this.textBoxInPutData_YVA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxInPutData_YVA.Location = new System.Drawing.Point(3, 16);
            this.textBoxInPutData_YVA.Multiline = true;
            this.textBoxInPutData_YVA.Name = "textBoxInPutData_YVA";
            this.textBoxInPutData_YVA.ReadOnly = true;
            this.textBoxInPutData_YVA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxInPutData_YVA.Size = new System.Drawing.Size(361, 267);
            this.textBoxInPutData_YVA.TabIndex = 0;
            // 
            // groupBoxOutPutData_YVA
            // 
            this.groupBoxOutPutData_YVA.Controls.Add(this.textBoxOutPutData_YVA);
            this.groupBoxOutPutData_YVA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutPutData_YVA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOutPutData_YVA.Name = "groupBoxOutPutData_YVA";
            this.groupBoxOutPutData_YVA.Size = new System.Drawing.Size(430, 286);
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
            this.textBoxOutPutData_YVA.Size = new System.Drawing.Size(424, 267);
            this.textBoxOutPutData_YVA.TabIndex = 0;
            // 
            // openFileDialog_YVA
            // 
            this.openFileDialog_YVA.FileName = "openFileDialog1";
            // 
            // toolTip_YVA
            // 
            this.toolTip_YVA.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip_YVA.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelFill_YVA);
            this.Controls.Add(this.splitterMain_YVA);
            this.Controls.Add(this.panelLeft_YVA);
            this.Controls.Add(this.panelTop_YVA);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 6 | Вариант 15 | Ягодин В.А.";
            this.toolTip_YVA.SetToolTip(this, "Вывести последнее слово каждой строки\r\nв результирующею строку.");
            this.panelTop_YVA.ResumeLayout(false);
            this.panelLeft_YVA.ResumeLayout(false);
            this.panelFill_YVA.ResumeLayout(false);
            this.groupBoxTask_YVA.ResumeLayout(false);
            this.groupBoxTask_YVA.PerformLayout();
            this.groupBoxInPutData_YVA.ResumeLayout(false);
            this.groupBoxInPutData_YVA.PerformLayout();
            this.groupBoxOutPutData_YVA.ResumeLayout(false);
            this.groupBoxOutPutData_YVA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop_YVA;
        private System.Windows.Forms.Panel panelLeft_YVA;
        private System.Windows.Forms.Splitter splitterMain_YVA;
        private System.Windows.Forms.Panel panelFill_YVA;
        private System.Windows.Forms.Button buttonOpenFile_YVA;
        private System.Windows.Forms.Button buttonAbout_YVA;
        private System.Windows.Forms.Button buttonDone_YVA;
        private System.Windows.Forms.GroupBox groupBoxTask_YVA;
        private System.Windows.Forms.TextBox textBoxTask_YVA;
        private System.Windows.Forms.GroupBox groupBoxInPutData_YVA;
        private System.Windows.Forms.TextBox textBoxInPutData_YVA;
        private System.Windows.Forms.GroupBox groupBoxOutPutData_YVA;
        private System.Windows.Forms.TextBox textBoxOutPutData_YVA;
        private System.Windows.Forms.OpenFileDialog openFileDialog_YVA;
        private System.Windows.Forms.ToolTip toolTip_YVA;
    }
}

