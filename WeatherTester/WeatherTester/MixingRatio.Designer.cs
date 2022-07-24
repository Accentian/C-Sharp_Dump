namespace WeatherTester
{
    partial class MixingRatio
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
            this.lblPressure = new System.Windows.Forms.Label();
            this.lblVaporPressure = new System.Windows.Forms.Label();
            this.txtPressure = new System.Windows.Forms.TextBox();
            this.txtVaporPressure = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblResults = new System.Windows.Forms.Label();
            this.txtResults = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblPressure
            // 
            this.lblPressure.AutoSize = true;
            this.lblPressure.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPressure.Location = new System.Drawing.Point(72, 48);
            this.lblPressure.Name = "lblPressure";
            this.lblPressure.Size = new System.Drawing.Size(119, 20);
            this.lblPressure.TabIndex = 0;
            this.lblPressure.Text = "Enter Pressure:";
            // 
            // lblVaporPressure
            // 
            this.lblVaporPressure.AutoSize = true;
            this.lblVaporPressure.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVaporPressure.Location = new System.Drawing.Point(72, 136);
            this.lblVaporPressure.Name = "lblVaporPressure";
            this.lblVaporPressure.Size = new System.Drawing.Size(166, 20);
            this.lblVaporPressure.TabIndex = 1;
            this.lblVaporPressure.Text = "Enter Vapor Pressure:";
            // 
            // txtPressure
            // 
            this.txtPressure.Location = new System.Drawing.Point(72, 72);
            this.txtPressure.Name = "txtPressure";
            this.txtPressure.Size = new System.Drawing.Size(288, 20);
            this.txtPressure.TabIndex = 2;
            // 
            // txtVaporPressure
            // 
            this.txtVaporPressure.Location = new System.Drawing.Point(72, 160);
            this.txtVaporPressure.Name = "txtVaporPressure";
            this.txtVaporPressure.Size = new System.Drawing.Size(288, 20);
            this.txtVaporPressure.TabIndex = 3;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(160, 208);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(96, 32);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResults.Location = new System.Drawing.Point(136, 296);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(157, 20);
            this.lblResults.TabIndex = 5;
            this.lblResults.Text = "Mixing Ratio Results:";
            // 
            // txtResults
            // 
            this.txtResults.Location = new System.Drawing.Point(88, 320);
            this.txtResults.Name = "txtResults";
            this.txtResults.ReadOnly = true;
            this.txtResults.Size = new System.Drawing.Size(248, 20);
            this.txtResults.TabIndex = 6;
            // 
            // MixingRatio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 401);
            this.Controls.Add(this.txtResults);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtVaporPressure);
            this.Controls.Add(this.txtPressure);
            this.Controls.Add(this.lblVaporPressure);
            this.Controls.Add(this.lblPressure);
            this.Name = "MixingRatio";
            this.Text = "Mixing Ratio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPressure;
        private System.Windows.Forms.Label lblVaporPressure;
        private System.Windows.Forms.TextBox txtPressure;
        private System.Windows.Forms.TextBox txtVaporPressure;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.TextBox txtResults;
    }
}