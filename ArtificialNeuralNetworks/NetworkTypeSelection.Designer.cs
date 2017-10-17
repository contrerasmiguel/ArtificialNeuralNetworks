namespace ArtificialNeuralNetworks
{
    partial class NetworkTypeSelection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NetworkTypeSelection));
            this.btnAdaline = new System.Windows.Forms.Button();
            this.btnPerceptron = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdaline
            // 
            this.btnAdaline.Location = new System.Drawing.Point(71, 134);
            this.btnAdaline.Name = "btnAdaline";
            this.btnAdaline.Size = new System.Drawing.Size(142, 46);
            this.btnAdaline.TabIndex = 3;
            this.btnAdaline.Text = "Adaline";
            this.btnAdaline.UseVisualStyleBackColor = true;
            this.btnAdaline.Click += new System.EventHandler(this.btnAdaline_Click);
            // 
            // btnPerceptron
            // 
            this.btnPerceptron.AutoSize = true;
            this.btnPerceptron.Location = new System.Drawing.Point(71, 82);
            this.btnPerceptron.Name = "btnPerceptron";
            this.btnPerceptron.Size = new System.Drawing.Size(142, 46);
            this.btnPerceptron.TabIndex = 2;
            this.btnPerceptron.Text = "Perceptron";
            this.btnPerceptron.UseVisualStyleBackColor = true;
            this.btnPerceptron.Click += new System.EventHandler(this.btnPerceptron_Click);
            // 
            // NetworkTypeSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnAdaline);
            this.Controls.Add(this.btnPerceptron);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NetworkTypeSelection";
            this.Text = "Selección de Tipo de Red";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdaline;
        private System.Windows.Forms.Button btnPerceptron;
    }
}