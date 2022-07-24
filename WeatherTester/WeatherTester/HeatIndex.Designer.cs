namespace WeatherTester
{
    partial class HeatIndex
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
            this.txtPercent = new System.Windows.Forms.TextBox();
            this.txtCelcius = new System.Windows.Forms.TextBox();
            this.lblRelativeHumid = new System.Windows.Forms.Label();
            this.lblCelcius = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtResults
            // 
            this.txtResults.Location = new System.Drawing.Point(80, 320);
            this.txtResults.Name = "txtResults";
            this.txtResults.ReadOnly = true;
            this.txtResults.Size = new System.Drawing.Size(248, 20);
            this.txtResults.TabIndex = 13;
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResults.Location = new System.Drawing.Point(80, 296);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(91, 20);
            this.lblResults.TabIndex = 12;
            this.lblResults.Text = "Heat Index:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(152, 208);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(96, 32);
            this.btnCalculate.TabIndex = 11;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtPercent
            // 
            this.txtPercent.Location = new System.Drawing.Point(64, 160);
            this.txtPercent.Name = "txtPercent";
            this.txtPercent.Size = new System.Drawing.Size(288, 20);
            this.txtPercent.TabIndex = 10;
            // 
            // txtCelcius
            // 
            this.txtCelcius.Location = new System.Drawing.Point(64, 72);
            this.txtCelcius.Name = "txtCelcius";
            this.txtCelcius.Size = new System.Drawing.Size(288, 20);
            this.txtCelcius.TabIndex = 9;
            // 
            // lblRelativeHumid
            // 
            this.lblRelativeHumid.AutoSize = true;
            this.lblRelativeHumid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRelativeHumid.Location = new System.Drawing.Point(64, 136);
            this.lblRelativeHumid.Name = "lblRelativeHumid";
            this.lblRelativeHumid.Size = new System.Drawing.Size(237, 20);
            this.lblRelativeHumid.TabIndex = 8;
            this.lblRelativeHumid.Text = "Enter Relative Humidity Percent:";
            // 
            // lblCelcius
            // 
            this.lblCelcius.AutoSize = true;
            this.lblCelcius.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCelcius.Location = new System.Drawing.Point(64, 48);
            this.lblCelcius.Name = "lblCelcius";
            this.lblCelcius.Size = new System.Drawing.Size(107, 20);
            this.lblCelcius.TabIndex = 7;
            this.lblCelcius.Text = "Enter Celcius:";
            // 
            // HeatIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 401);
            this.Controls.Add(this.txtResults);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtPercent);
            this.Controls.Add(this.txtCelcius);
            this.Controls.Add(this.lblRelativeHumid);
            this.Controls.Add(this.lblCelcius);
            this.Name = "HeatIndex";
            this.Text = "Heat Index";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResults;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtPercent;
        private System.Windows.Forms.TextBox txtCelcius;
        private System.Windows.Forms.Label lblRelativeHumid;
        private System.Windows.Forms.Label lblCelcius;
    }
}