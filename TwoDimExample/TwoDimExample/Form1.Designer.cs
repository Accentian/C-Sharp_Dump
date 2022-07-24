namespace TwoDimExample
{
    partial class frmDim
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
            this.lblStudent1 = new System.Windows.Forms.Label();
            this.txtS1G1 = new System.Windows.Forms.TextBox();
            this.txtS1G2 = new System.Windows.Forms.TextBox();
            this.txtS1G3 = new System.Windows.Forms.TextBox();
            this.lblStudent2 = new System.Windows.Forms.Label();
            this.txtS2G1 = new System.Windows.Forms.TextBox();
            this.txtS2G2 = new System.Windows.Forms.TextBox();
            this.txtS2G3 = new System.Windows.Forms.TextBox();
            this.btnGrade = new System.Windows.Forms.Button();
            this.lstGrades = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblStudent1
            // 
            this.lblStudent1.AutoSize = true;
            this.lblStudent1.Location = new System.Drawing.Point(34, 43);
            this.lblStudent1.Name = "lblStudent1";
            this.lblStudent1.Size = new System.Drawing.Size(53, 13);
            this.lblStudent1.TabIndex = 0;
            this.lblStudent1.Text = "Student 1";
            // 
            // txtS1G1
            // 
            this.txtS1G1.Location = new System.Drawing.Point(37, 59);
            this.txtS1G1.Name = "txtS1G1";
            this.txtS1G1.Size = new System.Drawing.Size(100, 20);
            this.txtS1G1.TabIndex = 1;
            // 
            // txtS1G2
            // 
            this.txtS1G2.Location = new System.Drawing.Point(143, 59);
            this.txtS1G2.Name = "txtS1G2";
            this.txtS1G2.Size = new System.Drawing.Size(100, 20);
            this.txtS1G2.TabIndex = 2;
            // 
            // txtS1G3
            // 
            this.txtS1G3.Location = new System.Drawing.Point(249, 59);
            this.txtS1G3.Name = "txtS1G3";
            this.txtS1G3.Size = new System.Drawing.Size(100, 20);
            this.txtS1G3.TabIndex = 3;
            // 
            // lblStudent2
            // 
            this.lblStudent2.AutoSize = true;
            this.lblStudent2.Location = new System.Drawing.Point(34, 108);
            this.lblStudent2.Name = "lblStudent2";
            this.lblStudent2.Size = new System.Drawing.Size(53, 13);
            this.lblStudent2.TabIndex = 4;
            this.lblStudent2.Text = "Student 2";
            // 
            // txtS2G1
            // 
            this.txtS2G1.Location = new System.Drawing.Point(37, 124);
            this.txtS2G1.Name = "txtS2G1";
            this.txtS2G1.Size = new System.Drawing.Size(100, 20);
            this.txtS2G1.TabIndex = 5;
            // 
            // txtS2G2
            // 
            this.txtS2G2.Location = new System.Drawing.Point(143, 124);
            this.txtS2G2.Name = "txtS2G2";
            this.txtS2G2.Size = new System.Drawing.Size(100, 20);
            this.txtS2G2.TabIndex = 6;
            // 
            // txtS2G3
            // 
            this.txtS2G3.Location = new System.Drawing.Point(249, 124);
            this.txtS2G3.Name = "txtS2G3";
            this.txtS2G3.Size = new System.Drawing.Size(100, 20);
            this.txtS2G3.TabIndex = 7;
            // 
            // btnGrade
            // 
            this.btnGrade.Location = new System.Drawing.Point(143, 176);
            this.btnGrade.Name = "btnGrade";
            this.btnGrade.Size = new System.Drawing.Size(100, 36);
            this.btnGrade.TabIndex = 8;
            this.btnGrade.Text = "Put Grades into Array";
            this.btnGrade.UseVisualStyleBackColor = true;
            this.btnGrade.Click += new System.EventHandler(this.btnGrade_Click);
            // 
            // lstGrades
            // 
            this.lstGrades.FormattingEnabled = true;
            this.lstGrades.Location = new System.Drawing.Point(37, 255);
            this.lstGrades.Name = "lstGrades";
            this.lstGrades.Size = new System.Drawing.Size(312, 82);
            this.lstGrades.TabIndex = 9;
            // 
            // frmDim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 349);
            this.Controls.Add(this.lstGrades);
            this.Controls.Add(this.btnGrade);
            this.Controls.Add(this.txtS2G3);
            this.Controls.Add(this.txtS2G2);
            this.Controls.Add(this.txtS2G1);
            this.Controls.Add(this.lblStudent2);
            this.Controls.Add(this.txtS1G3);
            this.Controls.Add(this.txtS1G2);
            this.Controls.Add(this.txtS1G1);
            this.Controls.Add(this.lblStudent1);
            this.Name = "frmDim";
            this.Text = "Two Dimensional Example";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStudent1;
        private System.Windows.Forms.TextBox txtS1G1;
        private System.Windows.Forms.TextBox txtS1G2;
        private System.Windows.Forms.TextBox txtS1G3;
        private System.Windows.Forms.Label lblStudent2;
        private System.Windows.Forms.TextBox txtS2G1;
        private System.Windows.Forms.TextBox txtS2G2;
        private System.Windows.Forms.TextBox txtS2G3;
        private System.Windows.Forms.Button btnGrade;
        private System.Windows.Forms.ListBox lstGrades;
    }
}

