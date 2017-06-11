namespace Perceptron
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.chrtHypSeparator = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnTrain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chrtHypSeparator)).BeginInit();
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
            chartArea4.Name = "ChartArea1";
            this.chrtHypSeparator.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chrtHypSeparator.Legends.Add(legend4);
            this.chrtHypSeparator.Location = new System.Drawing.Point(12, 12);
            this.chrtHypSeparator.Name = "chrtHypSeparator";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chrtHypSeparator.Series.Add(series4);
            this.chrtHypSeparator.Size = new System.Drawing.Size(600, 380);
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
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 442);
            this.Controls.Add(this.btnTrain);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.chrtHypSeparator);
            this.Name = "Test";
            this.Text = "Prueba";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Test_FormClosed);
            this.VisibleChanged += new System.EventHandler(this.Test_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.chrtHypSeparator)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtHypSeparator;
        private System.Windows.Forms.Button btnTrain;
    }
}