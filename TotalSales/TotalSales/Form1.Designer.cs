namespace TotalSales
{
    partial class frmTotalSales
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
            this.lstSales = new System.Windows.Forms.ListBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblAverage = new System.Windows.Forms.Label();
            this.lblLargest = new System.Windows.Forms.Label();
            this.lblSmallest = new System.Windows.Forms.Label();
            this.txtAverage = new System.Windows.Forms.TextBox();
            this.txtLargest = new System.Windows.Forms.TextBox();
            this.txtSmallest = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstSales
            // 
            this.lstSales.FormattingEnabled = true;
            this.lstSales.Location = new System.Drawing.Point(12, 12);
            this.lstSales.Name = "lstSales";
            this.lstSales.Size = new System.Drawing.Size(263, 95);
            this.lstSales.TabIndex = 0;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(87, 113);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(130, 23);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "Calculate Total Sales";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.Location = new System.Drawing.Point(12, 143);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(71, 23);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "Total Sales: ";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(87, 146);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(130, 20);
            this.txtTotal.TabIndex = 3;
            // 
            // lblAverage
            // 
            this.lblAverage.Location = new System.Drawing.Point(15, 170);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(68, 23);
            this.lblAverage.TabIndex = 4;
            this.lblAverage.Text = "Average:";
            this.lblAverage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLargest
            // 
            this.lblLargest.Location = new System.Drawing.Point(15, 193);
            this.lblLargest.Name = "lblLargest";
            this.lblLargest.Size = new System.Drawing.Size(100, 23);
            this.lblLargest.TabIndex = 5;
            this.lblLargest.Text = "Largest:";
            this.lblLargest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSmallest
            // 
            this.lblSmallest.Location = new System.Drawing.Point(15, 216);
            this.lblSmallest.Name = "lblSmallest";
            this.lblSmallest.Size = new System.Drawing.Size(100, 23);
            this.lblSmallest.TabIndex = 6;
            this.lblSmallest.Text = "Smallest:";
            this.lblSmallest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAverage
            // 
            this.txtAverage.Location = new System.Drawing.Point(87, 170);
            this.txtAverage.Name = "txtAverage";
            this.txtAverage.ReadOnly = true;
            this.txtAverage.Size = new System.Drawing.Size(130, 20);
            this.txtAverage.TabIndex = 7;
            // 
            // txtLargest
            // 
            this.txtLargest.Location = new System.Drawing.Point(87, 193);
            this.txtLargest.Name = "txtLargest";
            this.txtLargest.ReadOnly = true;
            this.txtLargest.Size = new System.Drawing.Size(130, 20);
            this.txtLargest.TabIndex = 8;
            // 
            // txtSmallest
            // 
            this.txtSmallest.Location = new System.Drawing.Point(87, 218);
            this.txtSmallest.Name = "txtSmallest";
            this.txtSmallest.ReadOnly = true;
            this.txtSmallest.Size = new System.Drawing.Size(130, 20);
            this.txtSmallest.TabIndex = 9;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(110, 271);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmTotalSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 306);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtSmallest);
            this.Controls.Add(this.txtLargest);
            this.Controls.Add(this.txtAverage);
            this.Controls.Add(this.lblSmallest);
            this.Controls.Add(this.lblLargest);
            this.Controls.Add(this.lblAverage);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lstSales);
            this.Name = "frmTotalSales";
            this.Text = "Total Sales";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstSales;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.Label lblLargest;
        private System.Windows.Forms.Label lblSmallest;
        private System.Windows.Forms.TextBox txtAverage;
        private System.Windows.Forms.TextBox txtLargest;
        private System.Windows.Forms.TextBox txtSmallest;
        private System.Windows.Forms.Button btnExit;
    }
}

