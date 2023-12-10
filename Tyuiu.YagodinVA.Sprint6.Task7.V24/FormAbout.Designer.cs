
namespace Tyuiu.YagodinVA.Sprint6.Task7.V24
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.pictureBoxAvatar_YVA = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonOK_YVA = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_YVA)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAvatar_YVA
            // 
            this.pictureBoxAvatar_YVA.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAvatar_YVA.Image")));
            this.pictureBoxAvatar_YVA.Location = new System.Drawing.Point(13, 13);
            this.pictureBoxAvatar_YVA.Name = "pictureBoxAvatar_YVA";
            this.pictureBoxAvatar_YVA.Size = new System.Drawing.Size(127, 169);
            this.pictureBoxAvatar_YVA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAvatar_YVA.TabIndex = 1;
            this.pictureBoxAvatar_YVA.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(146, 13);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(276, 169);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // buttonOK_YVA
            // 
            this.buttonOK_YVA.Location = new System.Drawing.Point(369, 211);
            this.buttonOK_YVA.Name = "buttonOK_YVA";
            this.buttonOK_YVA.Size = new System.Drawing.Size(53, 38);
            this.buttonOK_YVA.TabIndex = 1;
            this.buttonOK_YVA.Text = "OK";
            this.buttonOK_YVA.UseVisualStyleBackColor = true;
            this.buttonOK_YVA.Click += new System.EventHandler(this.buttonOK_YVA_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 261);
            this.Controls.Add(this.buttonOK_YVA);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBoxAvatar_YVA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_YVA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAvatar_YVA;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonOK_YVA;
    }
}