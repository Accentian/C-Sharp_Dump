namespace WeatherTester
{
    partial class WindChill
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
            this.txtMPH = new System.Windows.Forms.TextBox();
            this.lblMPH = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.txtFahr = new System.Windows.Forms.TextBox();
            this.lblResults = new System.Windows.Forms.Label();
            this.lblFahr = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMPH
            // 
            this.txtMPH.Location = new System.Drawing.Point(96, 144);
            this.txtMPH.Name = "txtMPH";
            this.txtMPH.Size = new System.Drawing.Size(224, 20);
            this.txtMPH.TabIndex = 27;
            // 
            // lblMPH
            // 
            this.lblMPH.AutoSize = true;
            this.lblMPH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMPH.Location = new System.Drawing.Point(96, 120);
            this.lblMPH.Name = "lblMPH";
            this.lblMPH.Size = new System.Drawing.Size(91, 20);
            this.lblMPH.TabIndex = 26;
            this.lblMPH.Text = "Enter MPH:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(168, 216);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(104, 32);
            this.btnCalculate.TabIndex = 25;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(96, 304);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(224, 20);
            this.txtResult.TabIndex = 24;
            // 
            // txtFahr
            // 
            this.txtFahr.Location = new System.Drawing.Point(96, 80);
            this.txtFahr.Name = "txtFahr";
            this.txtFahr.Size = new System.Drawing.Size(224, 20);
            this.txtFahr.TabIndex = 23;
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResults.Location = new System.Drawing.Point(96, 280);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(82, 20);
            this.lblResults.TabIndex = 22;
            this.lblResults.Text = "Wind Chill:";
            // 
            // lblFahr
            // 
            this.lblFahr.AutoSize = true;
            this.lblFahr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFahr.Location = new System.Drawing.Point(96, 56);
            this.lblFahr.Name = "lblFahr";
            this.lblFahr.Size = new System.Drawing.Size(133, 20);
            this.lblFahr.TabIndex = 21;
            this.lblFahr.Text = "Enter Fahrenheit:";
            // 
            // WindChill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 401);
            this.Controls.Add(this.txtMPH);
            this.Controls.Add(this.lblMPH);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtFahr);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.lblFahr);
            this.Name = "WindChill";
            this.Text = "Wind Chill";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMPH;
        private System.Windows.Forms.Label lblMPH;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.TextBox txtFahr;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.Label lblFahr;
    }
}