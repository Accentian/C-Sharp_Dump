namespace ArrayExamples
{
    partial class frmArray
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
            this.btnShow = new System.Windows.Forms.Button();
            this.lblIndex0 = new System.Windows.Forms.Label();
            this.lblIndex1 = new System.Windows.Forms.Label();
            this.lblIndex2 = new System.Windows.Forms.Label();
            this.lblAverage = new System.Windows.Forms.Label();
            this.btnPassing = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(124, 42);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 0;
            this.btnShow.Text = "Show Array";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // lblIndex0
            // 
            this.lblIndex0.AutoSize = true;
            this.lblIndex0.Location = new System.Drawing.Point(121, 86);
            this.lblIndex0.Name = "lblIndex0";
            this.lblIndex0.Size = new System.Drawing.Size(42, 13);
            this.lblIndex0.TabIndex = 1;
            this.lblIndex0.Text = "Index 0";
            // 
            // lblIndex1
            // 
            this.lblIndex1.AutoSize = true;
            this.lblIndex1.Location = new System.Drawing.Point(121, 112);
            this.lblIndex1.Name = "lblIndex1";
            this.lblIndex1.Size = new System.Drawing.Size(42, 13);
            this.lblIndex1.TabIndex = 2;
            this.lblIndex1.Text = "Index 1";
            // 
            // lblIndex2
            // 
            this.lblIndex2.AutoSize = true;
            this.lblIndex2.Location = new System.Drawing.Point(121, 137);
            this.lblIndex2.Name = "lblIndex2";
            this.lblIndex2.Size = new System.Drawing.Size(42, 13);
            this.lblIndex2.TabIndex = 3;
            this.lblIndex2.Text = "Index 2";
            // 
            // lblAverage
            // 
            this.lblAverage.Location = new System.Drawing.Point(124, 168);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(75, 23);
            this.lblAverage.TabIndex = 4;
            this.lblAverage.Text = "Average";
            this.lblAverage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPassing
            // 
            this.btnPassing.Location = new System.Drawing.Point(124, 194);
            this.btnPassing.Name = "btnPassing";
            this.btnPassing.Size = new System.Drawing.Size(75, 48);
            this.btnPassing.TabIndex = 5;
            this.btnPassing.Text = "Passing Array to Method";
            this.btnPassing.UseVisualStyleBackColor = true;
            this.btnPassing.Click += new System.EventHandler(this.btnPassing_Click);
            // 
            // frmArray
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 298);
            this.Controls.Add(this.btnPassing);
            this.Controls.Add(this.lblAverage);
            this.Controls.Add(this.lblIndex2);
            this.Controls.Add(this.lblIndex1);
            this.Controls.Add(this.lblIndex0);
            this.Controls.Add(this.btnShow);
            this.Name = "frmArray";
            this.Text = "Array Examples";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label lblIndex0;
        private System.Windows.Forms.Label lblIndex1;
        private System.Windows.Forms.Label lblIndex2;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.Button btnPassing;
    }
}

