
namespace Tyuiu.KomarovMA.Sprint7.V15
{
    partial class FormAboutPeople
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
            this.groupBoxStats_SIA = new System.Windows.Forms.GroupBox();
            this.textBoxAmountPeople_KMA = new System.Windows.Forms.TextBox();
            this.textBoxSummDohod_KMA = new System.Windows.Forms.TextBox();
            this.textBoxMinDohod_KMA = new System.Windows.Forms.TextBox();
            this.textBoxMaxDohod_KMA = new System.Windows.Forms.TextBox();
            this.labelPeople_KMA = new System.Windows.Forms.Label();
            this.labelSummDohod_KMA = new System.Windows.Forms.Label();
            this.labelMinDohod_KMA = new System.Windows.Forms.Label();
            this.labelMaxDohod_KMA = new System.Windows.Forms.Label();
            this.chartDohod_KMA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxStats_SIA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDohod_KMA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxStats_SIA
            // 
            this.groupBoxStats_SIA.Controls.Add(this.labelMaxDohod_KMA);
            this.groupBoxStats_SIA.Controls.Add(this.labelMinDohod_KMA);
            this.groupBoxStats_SIA.Controls.Add(this.labelSummDohod_KMA);
            this.groupBoxStats_SIA.Controls.Add(this.labelPeople_KMA);
            this.groupBoxStats_SIA.Controls.Add(this.textBoxMaxDohod_KMA);
            this.groupBoxStats_SIA.Controls.Add(this.textBoxMinDohod_KMA);
            this.groupBoxStats_SIA.Controls.Add(this.textBoxSummDohod_KMA);
            this.groupBoxStats_SIA.Controls.Add(this.textBoxAmountPeople_KMA);
            this.groupBoxStats_SIA.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBoxStats_SIA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxStats_SIA.Location = new System.Drawing.Point(639, 0);
            this.groupBoxStats_SIA.Name = "groupBoxStats_SIA";
            this.groupBoxStats_SIA.Size = new System.Drawing.Size(161, 450);
            this.groupBoxStats_SIA.TabIndex = 1;
            this.groupBoxStats_SIA.TabStop = false;
            this.groupBoxStats_SIA.Text = "Статистика";
            // 
            // textBoxAmountPeople_KMA
            // 
            this.textBoxAmountPeople_KMA.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxAmountPeople_KMA.Location = new System.Drawing.Point(16, 88);
            this.textBoxAmountPeople_KMA.Name = "textBoxAmountPeople_KMA";
            this.textBoxAmountPeople_KMA.ReadOnly = true;
            this.textBoxAmountPeople_KMA.Size = new System.Drawing.Size(125, 24);
            this.textBoxAmountPeople_KMA.TabIndex = 18;
            // 
            // textBoxSummDohod_KMA
            // 
            this.textBoxSummDohod_KMA.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxSummDohod_KMA.Location = new System.Drawing.Point(16, 162);
            this.textBoxSummDohod_KMA.Name = "textBoxSummDohod_KMA";
            this.textBoxSummDohod_KMA.ReadOnly = true;
            this.textBoxSummDohod_KMA.Size = new System.Drawing.Size(125, 24);
            this.textBoxSummDohod_KMA.TabIndex = 22;
            // 
            // textBoxMinDohod_KMA
            // 
            this.textBoxMinDohod_KMA.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxMinDohod_KMA.Location = new System.Drawing.Point(16, 237);
            this.textBoxMinDohod_KMA.Name = "textBoxMinDohod_KMA";
            this.textBoxMinDohod_KMA.ReadOnly = true;
            this.textBoxMinDohod_KMA.Size = new System.Drawing.Size(125, 24);
            this.textBoxMinDohod_KMA.TabIndex = 23;
            // 
            // textBoxMaxDohod_KMA
            // 
            this.textBoxMaxDohod_KMA.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxMaxDohod_KMA.Location = new System.Drawing.Point(16, 313);
            this.textBoxMaxDohod_KMA.Name = "textBoxMaxDohod_KMA";
            this.textBoxMaxDohod_KMA.ReadOnly = true;
            this.textBoxMaxDohod_KMA.Size = new System.Drawing.Size(125, 24);
            this.textBoxMaxDohod_KMA.TabIndex = 24;
            // 
            // labelPeople_KMA
            // 
            this.labelPeople_KMA.AutoSize = true;
            this.labelPeople_KMA.Location = new System.Drawing.Point(33, 67);
            this.labelPeople_KMA.Name = "labelPeople_KMA";
            this.labelPeople_KMA.Size = new System.Drawing.Size(91, 18);
            this.labelPeople_KMA.TabIndex = 25;
            this.labelPeople_KMA.Text = "Кол-во чел.";
            // 
            // labelSummDohod_KMA
            // 
            this.labelSummDohod_KMA.AutoSize = true;
            this.labelSummDohod_KMA.Location = new System.Drawing.Point(27, 141);
            this.labelSummDohod_KMA.Name = "labelSummDohod_KMA";
            this.labelSummDohod_KMA.Size = new System.Drawing.Size(102, 18);
            this.labelSummDohod_KMA.TabIndex = 26;
            this.labelSummDohod_KMA.Text = "Сумм. Оклад";
            // 
            // labelMinDohod_KMA
            // 
            this.labelMinDohod_KMA.AutoSize = true;
            this.labelMinDohod_KMA.Location = new System.Drawing.Point(33, 217);
            this.labelMinDohod_KMA.Name = "labelMinDohod_KMA";
            this.labelMinDohod_KMA.Size = new System.Drawing.Size(91, 18);
            this.labelMinDohod_KMA.TabIndex = 27;
            this.labelMinDohod_KMA.Text = "Мин. Оклад";
            // 
            // labelMaxDohod_KMA
            // 
            this.labelMaxDohod_KMA.AutoSize = true;
            this.labelMaxDohod_KMA.Location = new System.Drawing.Point(27, 292);
            this.labelMaxDohod_KMA.Name = "labelMaxDohod_KMA";
            this.labelMaxDohod_KMA.Size = new System.Drawing.Size(99, 18);
            this.labelMaxDohod_KMA.TabIndex = 28;
            this.labelMaxDohod_KMA.Text = "Макс. Оклад";
            // 
            // chartDohod_KMA
            // 
            chartArea2.Name = "ChartArea1";
            this.chartDohod_KMA.ChartAreas.Add(chartArea2);
            this.chartDohod_KMA.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.chartDohod_KMA.Legends.Add(legend2);
            this.chartDohod_KMA.Location = new System.Drawing.Point(0, 0);
            this.chartDohod_KMA.Name = "chartDohod_KMA";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartDohod_KMA.Series.Add(series2);
            this.chartDohod_KMA.Size = new System.Drawing.Size(639, 450);
            this.chartDohod_KMA.TabIndex = 2;
            this.chartDohod_KMA.Text = "chart1";
            this.chartDohod_KMA.Click += new System.EventHandler(this.chartDohod_KMA_Click);
            // 
            // FormAboutPeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chartDohod_KMA);
            this.Controls.Add(this.groupBoxStats_SIA);
            this.Name = "FormAboutPeople";
            this.Text = "Статистика";
            this.Load += new System.EventHandler(this.FormAboutPeople_Load);
            this.groupBoxStats_SIA.ResumeLayout(false);
            this.groupBoxStats_SIA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDohod_KMA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxStats_SIA;
        private System.Windows.Forms.TextBox textBoxAmountPeople_KMA;
        private System.Windows.Forms.TextBox textBoxSummDohod_KMA;
        private System.Windows.Forms.TextBox textBoxMinDohod_KMA;
        private System.Windows.Forms.TextBox textBoxMaxDohod_KMA;
        private System.Windows.Forms.Label labelPeople_KMA;
        private System.Windows.Forms.Label labelSummDohod_KMA;
        private System.Windows.Forms.Label labelMinDohod_KMA;
        private System.Windows.Forms.Label labelMaxDohod_KMA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDohod_KMA;
    }
}