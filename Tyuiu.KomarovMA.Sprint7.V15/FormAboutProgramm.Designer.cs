
namespace Tyuiu.KomarovMA.Sprint7.V15
{
    partial class FormAboutProgramm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAboutProgramm));
            this.buttonOK_KMA = new System.Windows.Forms.Button();
            this.pictureBoxFace_KMA = new System.Windows.Forms.PictureBox();
            this.textBoxHelp_KMA = new System.Windows.Forms.TextBox();
            this.bindingSource_KMA = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFace_KMA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_KMA)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOK_KMA
            // 
            this.buttonOK_KMA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK_KMA.Location = new System.Drawing.Point(444, 251);
            this.buttonOK_KMA.Name = "buttonOK_KMA";
            this.buttonOK_KMA.Size = new System.Drawing.Size(75, 23);
            this.buttonOK_KMA.TabIndex = 7;
            this.buttonOK_KMA.Text = "Ок";
            this.buttonOK_KMA.UseVisualStyleBackColor = true;
            this.buttonOK_KMA.Click += new System.EventHandler(this.buttonOK_KMA_Click);
            // 
            // pictureBoxFace_KMA
            // 
            this.pictureBoxFace_KMA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxFace_KMA.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFace_KMA.Image")));
            this.pictureBoxFace_KMA.Location = new System.Drawing.Point(8, 12);
            this.pictureBoxFace_KMA.Name = "pictureBoxFace_KMA";
            this.pictureBoxFace_KMA.Size = new System.Drawing.Size(189, 214);
            this.pictureBoxFace_KMA.TabIndex = 6;
            this.pictureBoxFace_KMA.TabStop = false;
            // 
            // textBoxHelp_KMA
            // 
            this.textBoxHelp_KMA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxHelp_KMA.Location = new System.Drawing.Point(219, 12);
            this.textBoxHelp_KMA.Multiline = true;
            this.textBoxHelp_KMA.Name = "textBoxHelp_KMA";
            this.textBoxHelp_KMA.ReadOnly = true;
            this.textBoxHelp_KMA.Size = new System.Drawing.Size(294, 140);
            this.textBoxHelp_KMA.TabIndex = 5;
            this.textBoxHelp_KMA.Text = "Разработчик: Комаров М.А.\r\nГруппа СМАРТб-23-1\r\nПрограмма разработана в рамках изу" +
    "чения языка C#\r\nТюменский индустриальный университет (с) 2023\r\nВысшая школа цифр" +
    "овых технологий (с) 2023";
            // 
            // FormAboutProgramm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 280);
            this.Controls.Add(this.buttonOK_KMA);
            this.Controls.Add(this.pictureBoxFace_KMA);
            this.Controls.Add(this.textBoxHelp_KMA);
            this.Name = "FormAboutProgramm";
            this.Text = "О Разработчике";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFace_KMA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_KMA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOK_KMA;
        private System.Windows.Forms.PictureBox pictureBoxFace_KMA;
        private System.Windows.Forms.TextBox textBoxHelp_KMA;
        private System.Windows.Forms.BindingSource bindingSource_KMA;
    }
}