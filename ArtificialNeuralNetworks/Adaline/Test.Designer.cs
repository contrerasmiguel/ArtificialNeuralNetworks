namespace Adaline
{
    partial class Test
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Test));
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.chrtHypSeparator = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnTrain = new System.Windows.Forms.Button();
            this.lblIterations = new System.Windows.Forms.Label();
            this.lblVelocidad = new System.Windows.Forms.Label();
            this.tbarVelocidad = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.chrtHypSeparator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarVelocidad)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.Location = new System.Drawing.Point(13, 398);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(100, 32);
            this.btnMainMenu.TabIndex = 5;
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
            this.chrtHypSeparator.Size = new System.Drawing.Size(600, 358);
            this.chrtHypSeparator.TabIndex = 4;
            this.chrtHypSeparator.MouseUp += new System.Windows.Forms.MouseEventHandler(this.chrtHypSeparator_MouseUp);
            // 
            // btnTrain
            // 
            this.btnTrain.Location = new System.Drawing.Point(512, 398);
            this.btnTrain.Name = "btnTrain";
            this.btnTrain.Size = new System.Drawing.Size(100, 32);
            this.btnTrain.TabIndex = 6;
            this.btnTrain.Text = "Entrenar";
            this.btnTrain.UseVisualStyleBackColor = true;
            this.btnTrain.Click += new System.EventHandler(this.btnTrain_Click);
            // 
            // lblIterations
            // 
            this.lblIterations.AutoSize = true;
            this.lblIterations.Location = new System.Drawing.Point(435, 408);
            this.lblIterations.Name = "lblIterations";
            this.lblIterations.Size = new System.Drawing.Size(71, 13);
            this.lblIterations.TabIndex = 11;
            this.lblIterations.Text = "Iteraciones: 0";
            // 
            // lblVelocidad
            // 
            this.lblVelocidad.AutoSize = true;
            this.lblVelocidad.Location = new System.Drawing.Point(285, 424);
            this.lblVelocidad.Name = "lblVelocidad";
            this.lblVelocidad.Size = new System.Drawing.Size(54, 13);
            this.lblVelocidad.TabIndex = 13;
            this.lblVelocidad.Text = "Velocidad";
            // 
            // tbarVelocidad
            // 
            this.tbarVelocidad.LargeChange = 200;
            this.tbarVelocidad.Location = new System.Drawing.Point(260, 376);
            this.tbarVelocidad.Maximum = 1000;
            this.tbarVelocidad.Minimum = 1;
            this.tbarVelocidad.Name = "tbarVelocidad";
            this.tbarVelocidad.Size = new System.Drawing.Size(104, 45);
            this.tbarVelocidad.SmallChange = 50;
            this.tbarVelocidad.TabIndex = 12;
            this.tbarVelocidad.Value = 1000;
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 442);
            this.Controls.Add(this.lblVelocidad);
            this.Controls.Add(this.tbarVelocidad);
            this.Controls.Add(this.lblIterations);
            this.Controls.Add(this.btnTrain);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.chrtHypSeparator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Test";
            this.Text = "Prueba";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Test_FormClosed);
            this.VisibleChanged += new System.EventHandler(this.Test_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.chrtHypSeparator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarVelocidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtHypSeparator;
        private System.Windows.Forms.Button btnTrain;
        private System.Windows.Forms.Label lblIterations;
        private System.Windows.Forms.Label lblVelocidad;
        private System.Windows.Forms.TrackBar tbarVelocidad;
    }
}