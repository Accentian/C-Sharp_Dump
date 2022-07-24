namespace MilesPerGallon
{
    partial class frmMilesPerGallon
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
            this.lblMiles = new System.Windows.Forms.Label();
            this.boxMiles = new System.Windows.Forms.TextBox();
            this.boxGallons = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtMPG = new System.Windows.Forms.TextBox();
            this.lblGallons = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMiles
            // 
            this.lblMiles.AutoSize = true;
            this.lblMiles.Location = new System.Drawing.Point(76, 35);
            this.lblMiles.Name = "lblMiles";
            this.lblMiles.Size = new System.Drawing.Size(109, 13);
            this.lblMiles.TabIndex = 0;
            this.lblMiles.Text = "Enter Miles Travelled:";
            // 
            // boxMiles
            // 
            this.boxMiles.Location = new System.Drawing.Point(189, 35);
            this.boxMiles.Name = "boxMiles";
            this.boxMiles.Size = new System.Drawing.Size(100, 20);
            this.boxMiles.TabIndex = 1;
            // 
            // boxGallons
            // 
            this.boxGallons.Location = new System.Drawing.Point(189, 64);
            this.boxGallons.Name = "boxGallons";
            this.boxGallons.Size = new System.Drawing.Size(100, 20);
            this.boxGallons.TabIndex = 2;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(79, 105);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 35);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(214, 105);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 35);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtMPG
            // 
            this.txtMPG.Location = new System.Drawing.Point(79, 169);
            this.txtMPG.Name = "txtMPG";
            this.txtMPG.ReadOnly = true;
            this.txtMPG.Size = new System.Drawing.Size(210, 20);
            this.txtMPG.TabIndex = 5;
            // 
            // lblGallons
            // 
            this.lblGallons.AutoSize = true;
            this.lblGallons.Location = new System.Drawing.Point(76, 67);
            this.lblGallons.Name = "lblGallons";
            this.lblGallons.Size = new System.Drawing.Size(73, 13);
            this.lblGallons.TabIndex = 7;
            this.lblGallons.Text = "Gallons Used:";
            // 
            // frmMilesPerGallon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 246);
            this.Controls.Add(this.lblGallons);
            this.Controls.Add(this.txtMPG);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.boxGallons);
            this.Controls.Add(this.boxMiles);
            this.Controls.Add(this.lblMiles);
            this.Name = "frmMilesPerGallon";
            this.Text = "Miles Per Gallons Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMiles;
        private System.Windows.Forms.TextBox boxMiles;
        private System.Windows.Forms.TextBox boxGallons;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtMPG;
        private System.Windows.Forms.Label lblGallons;
    }
}

