namespace WeatherTester
{
    partial class DewPoint
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
            this.txtResults = new System.Windows.Forms.TextBox();
            this.lblResults = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtRH = new System.Windows.Forms.TextBox();
            this.txtFahr = new System.Windows.Forms.TextBox();
            this.lblRelativeHumid = new System.Windows.Forms.Label();
            this.lblFahr = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtResults
            // 
            this.txtResults.Location = new System.Drawing.Point(84, 326);
            this.txtResults.Name = "txtResults";
            this.txtResults.ReadOnly = true;
            this.txtResults.Size = new System.Drawing.Size(248, 20);
            this.txtResults.TabIndex = 20;
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResults.Location = new System.Drawing.Point(84, 302);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(85, 20);
            this.lblResults.TabIndex = 19;
            this.lblResults.Text = "Dew Point:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(156, 214);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(96, 32);
            this.btnCalculate.TabIndex = 18;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtRH
            // 
            this.txtRH.Location = new System.Drawing.Point(68, 166);
            this.txtRH.Name = "txtRH";
            this.txtRH.Size = new System.Drawing.Size(288, 20);
            this.txtRH.TabIndex = 17;
            // 
            // txtFahr
            // 
            this.txtFahr.Location = new System.Drawing.Point(68, 78);
            this.txtFahr.Name = "txtFahr";
            this.txtFahr.Size = new System.Drawing.Size(288, 20);
            this.txtFahr.TabIndex = 16;
            // 
            // lblRelativeHumid
            // 
            this.lblRelativeHumid.AutoSize = true;
            this.lblRelativeHumid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRelativeHumid.Location = new System.Drawing.Point(68, 142);
            this.lblRelativeHumid.Name = "lblRelativeHumid";
            this.lblRelativeHumid.Size = new System.Drawing.Size(178, 20);
            this.lblRelativeHumid.TabIndex = 15;
            this.lblRelativeHumid.Text = "Enter Relative Humidity:";
            // 
            // lblFahr
            // 
            this.lblFahr.AutoSize = true;
            this.lblFahr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFahr.Location = new System.Drawing.Point(68, 54);
            this.lblFahr.Name = "lblFahr";
            this.lblFahr.Size = new System.Drawing.Size(133, 20);
            this.lblFahr.TabIndex = 14;
            this.lblFahr.Text = "Enter Fahrenheit:";
            // 
            // DewPoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 401);
            this.Controls.Add(this.txtResults);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtRH);
            this.Controls.Add(this.txtFahr);
            this.Controls.Add(this.lblRelativeHumid);
            this.Controls.Add(this.lblFahr);
            this.Name = "DewPoint";
            this.Text = "Dew Point";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResults;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtRH;
        private System.Windows.Forms.TextBox txtFahr;
        private System.Windows.Forms.Label lblRelativeHumid;
        private System.Windows.Forms.Label lblFahr;
    }
}