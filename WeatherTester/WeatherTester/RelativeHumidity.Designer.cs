namespace WeatherTester
{
    partial class RelativeHumidity
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
            this.txtSatVapor = new System.Windows.Forms.TextBox();
            this.lblSatVapor = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtHumidity = new System.Windows.Forms.TextBox();
            this.txtActVapor = new System.Windows.Forms.TextBox();
            this.lblResults = new System.Windows.Forms.Label();
            this.lblActVapor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSatVapor
            // 
            this.txtSatVapor.Location = new System.Drawing.Point(56, 136);
            this.txtSatVapor.Name = "txtSatVapor";
            this.txtSatVapor.Size = new System.Drawing.Size(224, 20);
            this.txtSatVapor.TabIndex = 20;
            // 
            // lblSatVapor
            // 
            this.lblSatVapor.AutoSize = true;
            this.lblSatVapor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSatVapor.Location = new System.Drawing.Point(56, 112);
            this.lblSatVapor.Name = "lblSatVapor";
            this.lblSatVapor.Size = new System.Drawing.Size(174, 20);
            this.lblSatVapor.TabIndex = 19;
            this.lblSatVapor.Text = "Enter Saturated Vapor:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(128, 208);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(104, 32);
            this.btnCalculate.TabIndex = 18;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtHumidity
            // 
            this.txtHumidity.Location = new System.Drawing.Point(56, 296);
            this.txtHumidity.Name = "txtHumidity";
            this.txtHumidity.Size = new System.Drawing.Size(224, 20);
            this.txtHumidity.TabIndex = 17;
            // 
            // txtActVapor
            // 
            this.txtActVapor.Location = new System.Drawing.Point(56, 72);
            this.txtActVapor.Name = "txtActVapor";
            this.txtActVapor.Size = new System.Drawing.Size(224, 20);
            this.txtActVapor.TabIndex = 16;
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResults.Location = new System.Drawing.Point(56, 272);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(135, 20);
            this.lblResults.TabIndex = 15;
            this.lblResults.Text = "Relative Humidity:";
            // 
            // lblActVapor
            // 
            this.lblActVapor.AutoSize = true;
            this.lblActVapor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActVapor.Location = new System.Drawing.Point(56, 48);
            this.lblActVapor.Name = "lblActVapor";
            this.lblActVapor.Size = new System.Drawing.Size(148, 20);
            this.lblActVapor.TabIndex = 14;
            this.lblActVapor.Text = "Enter Actual Vapor:";
            // 
            // RelativeHumidity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 401);
            this.Controls.Add(this.txtSatVapor);
            this.Controls.Add(this.lblSatVapor);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtHumidity);
            this.Controls.Add(this.txtActVapor);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.lblActVapor);
            this.Name = "RelativeHumidity";
            this.Text = "Relative Humidity";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSatVapor;
        private System.Windows.Forms.Label lblSatVapor;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtHumidity;
        private System.Windows.Forms.TextBox txtActVapor;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.Label lblActVapor;
    }
}