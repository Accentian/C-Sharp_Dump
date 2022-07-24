namespace BankAccount
{
    partial class frmBank
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
            this.lblDeposit = new System.Windows.Forms.Label();
            this.txtAmount1 = new System.Windows.Forms.TextBox();
            this.txtAmount2 = new System.Windows.Forms.TextBox();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnPage2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDeposit
            // 
            this.lblDeposit.AutoSize = true;
            this.lblDeposit.Location = new System.Drawing.Point(29, 35);
            this.lblDeposit.Name = "lblDeposit";
            this.lblDeposit.Size = new System.Drawing.Size(140, 13);
            this.lblDeposit.TabIndex = 0;
            this.lblDeposit.Text = "Enter Amount to be Deposit:";
            // 
            // txtAmount1
            // 
            this.txtAmount1.Location = new System.Drawing.Point(32, 51);
            this.txtAmount1.Name = "txtAmount1";
            this.txtAmount1.Size = new System.Drawing.Size(100, 20);
            this.txtAmount1.TabIndex = 1;
            // 
            // txtAmount2
            // 
            this.txtAmount2.Location = new System.Drawing.Point(32, 77);
            this.txtAmount2.Name = "txtAmount2";
            this.txtAmount2.Size = new System.Drawing.Size(100, 20);
            this.txtAmount2.TabIndex = 2;
            // 
            // btnDeposit
            // 
            this.btnDeposit.Location = new System.Drawing.Point(158, 108);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(75, 23);
            this.btnDeposit.TabIndex = 3;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // btnPage2
            // 
            this.btnPage2.Location = new System.Drawing.Point(324, 108);
            this.btnPage2.Name = "btnPage2";
            this.btnPage2.Size = new System.Drawing.Size(75, 42);
            this.btnPage2.TabIndex = 4;
            this.btnPage2.Text = "Go to Page 2";
            this.btnPage2.UseVisualStyleBackColor = true;
            this.btnPage2.Click += new System.EventHandler(this.btnPage2_Click);
            // 
            // frmBank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 160);
            this.Controls.Add(this.btnPage2);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.txtAmount2);
            this.Controls.Add(this.txtAmount1);
            this.Controls.Add(this.lblDeposit);
            this.Name = "frmBank";
            this.Text = "Bank Account";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDeposit;
        private System.Windows.Forms.TextBox txtAmount1;
        private System.Windows.Forms.TextBox txtAmount2;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnPage2;
    }
}

