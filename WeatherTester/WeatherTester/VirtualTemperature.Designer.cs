namespace WeatherTester
{
    partial class VirtualTemperature
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
            this.txtCel = new System.Windows.Forms.TextBox();
            this.lbCel = new System.Windows.Forms.Label();
            this.txtVP = new System.Windows.Forms.TextBox();
            this.lblVP = new System.Windows.Forms.Label();
            this.txtSP = new System.Windows.Forms.TextBox();
            this.lblSP = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.lblResults = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCel
            // 
            this.txtCel.Location = new System.Drawing.Point(104, 56);
            this.txtCel.Name = "txtCel";
            this.txtCel.Size = new System.Drawing.Size(224, 20);
            this.txtCel.TabIndex = 32;
            // 
            // lbCel
            // 
            this.lbCel.AutoSize = true;
            this.lbCel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCel.Location = new System.Drawing.Point(104, 32);
            this.lbCel.Name = "lbCel";
            this.lbCel.Size = new System.Drawing.Size(107, 20);
            this.lbCel.TabIndex = 31;
            this.lbCel.Text = "Enter Celsius:";
            // 
            // txtVP
            // 
            this.txtVP.Location = new System.Drawing.Point(104, 112);
            this.txtVP.Name = "txtVP";
            this.txtVP.Size = new System.Drawing.Size(224, 20);
            this.txtVP.TabIndex = 34;
            // 
            // lblVP
            // 
            this.lblVP.AutoSize = true;
            this.lblVP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVP.Location = new System.Drawing.Point(104, 88);
            this.lblVP.Name = "lblVP";
            this.lblVP.Size = new System.Drawing.Size(166, 20);
            this.lblVP.TabIndex = 33;
            this.lblVP.Text = "Enter Vapor Pressure:";
            // 
            // txtSP
            // 
            this.txtSP.Location = new System.Drawing.Point(104, 168);
            this.txtSP.Name = "txtSP";
            this.txtSP.Size = new System.Drawing.Size(224, 20);
            this.txtSP.TabIndex = 36;
            // 
            // lblSP
            // 
            this.lblSP.AutoSize = true;
            this.lblSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSP.Location = new System.Drawing.Point(104, 144);
            this.lblSP.Name = "lblSP";
            this.lblSP.Size = new System.Drawing.Size(174, 20);
            this.lblSP.TabIndex = 35;
            this.lblSP.Text = "Enter Station Pressure:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(160, 232);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(104, 32);
            this.btnCalculate.TabIndex = 41;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(104, 320);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(224, 20);
            this.txtResult.TabIndex = 40;
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResults.Location = new System.Drawing.Point(104, 296);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(153, 20);
            this.lblResults.TabIndex = 38;
            this.lblResults.Text = "Virtual Temperature:";
            // 
            // VirtualTemperature
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 401);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.txtSP);
            this.Controls.Add(this.lblSP);
            this.Controls.Add(this.txtVP);
            this.Controls.Add(this.lblVP);
            this.Controls.Add(this.txtCel);
            this.Controls.Add(this.lbCel);
            this.Name = "VirtualTemperature";
            this.Text = "Virtual Temperature";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCel;
        private System.Windows.Forms.Label lbCel;
        private System.Windows.Forms.TextBox txtVP;
        private System.Windows.Forms.Label lblVP;
        private System.Windows.Forms.TextBox txtSP;
        private System.Windows.Forms.Label lblSP;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label lblResults;
    }
}