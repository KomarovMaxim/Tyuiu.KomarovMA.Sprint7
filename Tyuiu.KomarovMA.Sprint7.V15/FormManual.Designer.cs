
namespace Tyuiu.KomarovMA.Sprint7.V15
{
    partial class FormManual_KMA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManual_KMA));
            this.pictureBoxManual_KMA = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxManual_KMA)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxManual_KMA
            // 
            this.pictureBoxManual_KMA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxManual_KMA.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxManual_KMA.Image")));
            this.pictureBoxManual_KMA.Location = new System.Drawing.Point(119, 69);
            this.pictureBoxManual_KMA.Name = "pictureBoxManual_KMA";
            this.pictureBoxManual_KMA.Size = new System.Drawing.Size(560, 333);
            this.pictureBoxManual_KMA.TabIndex = 0;
            this.pictureBoxManual_KMA.TabStop = false;
            // 
            // FormManual_KMA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 482);
            this.Controls.Add(this.pictureBoxManual_KMA);
            this.Name = "FormManual_KMA";
            this.Text = "Руководство пользователя";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxManual_KMA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxManual_KMA;
    }
}