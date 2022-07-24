namespace IfExamples
{
    partial class frmIfExamples
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
            this.lblTest1 = new System.Windows.Forms.Label();
            this.txtTest1 = new System.Windows.Forms.TextBox();
            this.lblTest2 = new System.Windows.Forms.Label();
            this.txtTest2 = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.txtAverage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTest1
            // 
            this.lblTest1.AutoSize = true;
            this.lblTest1.Location = new System.Drawing.Point(87, 41);
            this.lblTest1.Name = "lblTest1";
            this.lblTest1.Size = new System.Drawing.Size(99, 13);
            this.lblTest1.TabIndex = 0;
            this.lblTest1.Text = "Enter Test Score 1:";
            // 
            // txtTest1
            // 
            this.txtTest1.Location = new System.Drawing.Point(192, 38);
            this.txtTest1.Name = "txtTest1";
            this.txtTest1.Size = new System.Drawing.Size(100, 20);
            this.txtTest1.TabIndex = 1;
            // 
            // lblTest2
            // 
            this.lblTest2.AutoSize = true;
            this.lblTest2.Location = new System.Drawing.Point(87, 76);
            this.lblTest2.Name = "lblTest2";
            this.lblTest2.Size = new System.Drawing.Size(99, 13);
            this.lblTest2.TabIndex = 2;
            this.lblTest2.Text = "Enter Test Score 2:";
            // 
            // txtTest2
            // 
            this.txtTest2.Location = new System.Drawing.Point(192, 73);
            this.txtTest2.Name = "txtTest2";
            this.txtTest2.Size = new System.Drawing.Size(100, 20);
            this.txtTest2.TabIndex = 3;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(90, 109);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(202, 23);
            this.btnCalc.TabIndex = 4;
            this.btnCalc.Text = "&Calculate Average";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // txtAverage
            // 
            this.txtAverage.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtAverage.Location = new System.Drawing.Point(90, 161);
            this.txtAverage.Name = "txtAverage";
            this.txtAverage.ReadOnly = true;
            this.txtAverage.Size = new System.Drawing.Size(202, 20);
            this.txtAverage.TabIndex = 5;
            // 
            // frmIfExamples
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 235);
            this.Controls.Add(this.txtAverage);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtTest2);
            this.Controls.Add(this.lblTest2);
            this.Controls.Add(this.txtTest1);
            this.Controls.Add(this.lblTest1);
            this.Name = "frmIfExamples";
            this.Text = "If Examples";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTest1;
        private System.Windows.Forms.TextBox txtTest1;
        private System.Windows.Forms.Label lblTest2;
        private System.Windows.Forms.TextBox txtTest2;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.TextBox txtAverage;
    }
}

