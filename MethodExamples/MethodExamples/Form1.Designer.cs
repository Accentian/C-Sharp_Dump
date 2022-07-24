namespace MethodExamples
{
    partial class frmMethod
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
            this.btnDisplay = new System.Windows.Forms.Button();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.btnShowMax = new System.Windows.Forms.Button();
            this.btnShowMin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(55, 147);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(110, 23);
            this.btnDisplay.TabIndex = 0;
            this.btnDisplay.Text = "Display Message";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(55, 26);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(110, 20);
            this.txtNum1.TabIndex = 1;
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(55, 52);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(110, 20);
            this.txtNum2.TabIndex = 2;
            // 
            // btnShowMax
            // 
            this.btnShowMax.Location = new System.Drawing.Point(55, 78);
            this.btnShowMax.Name = "btnShowMax";
            this.btnShowMax.Size = new System.Drawing.Size(110, 23);
            this.btnShowMax.TabIndex = 3;
            this.btnShowMax.Text = "Show Max";
            this.btnShowMax.UseVisualStyleBackColor = true;
            this.btnShowMax.Click += new System.EventHandler(this.btnShowMax_Click);
            // 
            // btnShowMin
            // 
            this.btnShowMin.Location = new System.Drawing.Point(55, 107);
            this.btnShowMin.Name = "btnShowMin";
            this.btnShowMin.Size = new System.Drawing.Size(110, 23);
            this.btnShowMin.TabIndex = 4;
            this.btnShowMin.Text = "Show Min";
            this.btnShowMin.UseVisualStyleBackColor = true;
            this.btnShowMin.Click += new System.EventHandler(this.btnShowMin_Click);
            // 
            // frmMethod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 182);
            this.Controls.Add(this.btnShowMin);
            this.Controls.Add(this.btnShowMax);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.btnDisplay);
            this.Name = "frmMethod";
            this.Text = "Methods";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Button btnShowMax;
        private System.Windows.Forms.Button btnShowMin;
    }
}

