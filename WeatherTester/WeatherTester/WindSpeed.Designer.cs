namespace WeatherTester
{
    partial class WindSpeed
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
            this.txtMPHResults = new System.Windows.Forms.TextBox();
            this.lblMPHResult = new System.Windows.Forms.Label();
            this.btnConvertKnots = new System.Windows.Forms.Button();
            this.txtMPH = new System.Windows.Forms.TextBox();
            this.txtKnots = new System.Windows.Forms.TextBox();
            this.lblMPH = new System.Windows.Forms.Label();
            this.lblKnots = new System.Windows.Forms.Label();
            this.txtKnotsResults = new System.Windows.Forms.TextBox();
            this.lblKnotsResults = new System.Windows.Forms.Label();
            this.btnConvertMPH = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMPHResults
            // 
            this.txtMPHResults.Location = new System.Drawing.Point(96, 160);
            this.txtMPHResults.Name = "txtMPHResults";
            this.txtMPHResults.ReadOnly = true;
            this.txtMPHResults.Size = new System.Drawing.Size(224, 20);
            this.txtMPHResults.TabIndex = 13;
            // 
            // lblMPHResult
            // 
            this.lblMPHResult.AutoSize = true;
            this.lblMPHResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMPHResult.Location = new System.Drawing.Point(96, 136);
            this.lblMPHResult.Name = "lblMPHResult";
            this.lblMPHResult.Size = new System.Drawing.Size(48, 20);
            this.lblMPHResult.TabIndex = 12;
            this.lblMPHResult.Text = "MPH:";
            // 
            // btnConvertKnots
            // 
            this.btnConvertKnots.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertKnots.Location = new System.Drawing.Point(152, 96);
            this.btnConvertKnots.Name = "btnConvertKnots";
            this.btnConvertKnots.Size = new System.Drawing.Size(104, 32);
            this.btnConvertKnots.TabIndex = 11;
            this.btnConvertKnots.Text = "Convert";
            this.btnConvertKnots.UseVisualStyleBackColor = true;
            this.btnConvertKnots.Click += new System.EventHandler(this.btnConvertKnots_Click);
            // 
            // txtMPH
            // 
            this.txtMPH.Location = new System.Drawing.Point(96, 248);
            this.txtMPH.Name = "txtMPH";
            this.txtMPH.Size = new System.Drawing.Size(224, 20);
            this.txtMPH.TabIndex = 10;
            // 
            // txtKnots
            // 
            this.txtKnots.Location = new System.Drawing.Point(96, 64);
            this.txtKnots.Name = "txtKnots";
            this.txtKnots.Size = new System.Drawing.Size(224, 20);
            this.txtKnots.TabIndex = 9;
            // 
            // lblMPH
            // 
            this.lblMPH.AutoSize = true;
            this.lblMPH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMPH.Location = new System.Drawing.Point(96, 224);
            this.lblMPH.Name = "lblMPH";
            this.lblMPH.Size = new System.Drawing.Size(170, 20);
            this.lblMPH.TabIndex = 8;
            this.lblMPH.Text = "Convert MPH to Knots:";
            // 
            // lblKnots
            // 
            this.lblKnots.AutoSize = true;
            this.lblKnots.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKnots.Location = new System.Drawing.Point(96, 40);
            this.lblKnots.Name = "lblKnots";
            this.lblKnots.Size = new System.Drawing.Size(170, 20);
            this.lblKnots.TabIndex = 7;
            this.lblKnots.Text = "Convert Knots to MPH:";
            // 
            // txtKnotsResults
            // 
            this.txtKnotsResults.Location = new System.Drawing.Point(96, 352);
            this.txtKnotsResults.Name = "txtKnotsResults";
            this.txtKnotsResults.ReadOnly = true;
            this.txtKnotsResults.Size = new System.Drawing.Size(224, 20);
            this.txtKnotsResults.TabIndex = 15;
            // 
            // lblKnotsResults
            // 
            this.lblKnotsResults.AutoSize = true;
            this.lblKnotsResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKnotsResults.Location = new System.Drawing.Point(96, 328);
            this.lblKnotsResults.Name = "lblKnotsResults";
            this.lblKnotsResults.Size = new System.Drawing.Size(54, 20);
            this.lblKnotsResults.TabIndex = 14;
            this.lblKnotsResults.Text = "Knots:";
            // 
            // btnConvertMPH
            // 
            this.btnConvertMPH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertMPH.Location = new System.Drawing.Point(152, 288);
            this.btnConvertMPH.Name = "btnConvertMPH";
            this.btnConvertMPH.Size = new System.Drawing.Size(104, 32);
            this.btnConvertMPH.TabIndex = 16;
            this.btnConvertMPH.Text = "Convert";
            this.btnConvertMPH.UseVisualStyleBackColor = true;
            this.btnConvertMPH.Click += new System.EventHandler(this.btnConvertMPH_Click);
            // 
            // WindSpeed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 401);
            this.Controls.Add(this.btnConvertMPH);
            this.Controls.Add(this.txtKnotsResults);
            this.Controls.Add(this.lblKnotsResults);
            this.Controls.Add(this.txtMPHResults);
            this.Controls.Add(this.lblMPHResult);
            this.Controls.Add(this.btnConvertKnots);
            this.Controls.Add(this.txtMPH);
            this.Controls.Add(this.txtKnots);
            this.Controls.Add(this.lblMPH);
            this.Controls.Add(this.lblKnots);
            this.Name = "WindSpeed";
            this.Text = "Wind Speed";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMPHResults;
        private System.Windows.Forms.Label lblMPHResult;
        private System.Windows.Forms.Button btnConvertKnots;
        private System.Windows.Forms.TextBox txtMPH;
        private System.Windows.Forms.TextBox txtKnots;
        private System.Windows.Forms.Label lblMPH;
        private System.Windows.Forms.Label lblKnots;
        private System.Windows.Forms.TextBox txtKnotsResults;
        private System.Windows.Forms.Label lblKnotsResults;
        private System.Windows.Forms.Button btnConvertMPH;
    }
}