namespace Perceptron
{
    partial class Training
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
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.chrtHypSeparator = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlRadioButtons = new System.Windows.Forms.Panel();
            this.rbDrawLine = new System.Windows.Forms.RadioButton();
            this.rbPlacePoints = new System.Windows.Forms.RadioButton();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chrtHypSeparator)).BeginInit();
            this.pnlRadioButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.Location = new System.Drawing.Point(13, 398);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(100, 32);
            this.btnMainMenu.TabIndex = 1;
            this.btnMainMenu.Text = "Menú Principal";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // chrtHypSeparator
            // 
            chartArea1.Name = "ChartArea1";
            this.chrtHypSeparator.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chrtHypSeparator.Legends.Add(legend1);
            this.chrtHypSeparator.Location = new System.Drawing.Point(12, 12);
            this.chrtHypSeparator.Name = "chrtHypSeparator";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chrtHypSeparator.Series.Add(series1);
            this.chrtHypSeparator.Size = new System.Drawing.Size(600, 380);
            this.chrtHypSeparator.TabIndex = 0;
            this.chrtHypSeparator.MouseDown += new System.Windows.Forms.MouseEventHandler(this.chrtHypSeparator_MouseDown);
            this.chrtHypSeparator.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chrtHypSeparator_MouseMove);
            this.chrtHypSeparator.MouseUp += new System.Windows.Forms.MouseEventHandler(this.chrtHypSeparator_MouseUp);
            // 
            // pnlRadioButtons
            // 
            this.pnlRadioButtons.Controls.Add(this.rbDrawLine);
            this.pnlRadioButtons.Controls.Add(this.rbPlacePoints);
            this.pnlRadioButtons.Location = new System.Drawing.Point(213, 399);
            this.pnlRadioButtons.Name = "pnlRadioButtons";
            this.pnlRadioButtons.Size = new System.Drawing.Size(199, 31);
            this.pnlRadioButtons.TabIndex = 2;
            // 
            // rbDrawLine
            // 
            this.rbDrawLine.AutoSize = true;
            this.rbDrawLine.Checked = true;
            this.rbDrawLine.Location = new System.Drawing.Point(114, 8);
            this.rbDrawLine.Name = "rbDrawLine";
            this.rbDrawLine.Size = new System.Drawing.Size(82, 17);
            this.rbDrawLine.TabIndex = 5;
            this.rbDrawLine.TabStop = true;
            this.rbDrawLine.Text = "Mover línea";
            this.rbDrawLine.UseVisualStyleBackColor = true;
            // 
            // rbPlacePoints
            // 
            this.rbPlacePoints.AutoSize = true;
            this.rbPlacePoints.Location = new System.Drawing.Point(3, 8);
            this.rbPlacePoints.Name = "rbPlacePoints";
            this.rbPlacePoints.Size = new System.Drawing.Size(96, 17);
            this.rbPlacePoints.TabIndex = 4;
            this.rbPlacePoints.Text = "Colocar puntos";
            this.rbPlacePoints.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(512, 399);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 32);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Limpiar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Training
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 442);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.pnlRadioButtons);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.chrtHypSeparator);
            this.Name = "Training";
            this.Text = "Entrenamiento";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Training_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.chrtHypSeparator)).EndInit();
            this.pnlRadioButtons.ResumeLayout(false);
            this.pnlRadioButtons.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtHypSeparator;
        private System.Windows.Forms.Panel pnlRadioButtons;
        private System.Windows.Forms.RadioButton rbDrawLine;
        private System.Windows.Forms.RadioButton rbPlacePoints;
        private System.Windows.Forms.Button btnClear;
    }
}