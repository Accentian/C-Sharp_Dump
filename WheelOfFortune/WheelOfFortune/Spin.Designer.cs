namespace WheelOfFortune
{
    partial class Spin
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
            this.lblLand = new System.Windows.Forms.Label();
            this.txtLand = new System.Windows.Forms.TextBox();
            this.lblLetter = new System.Windows.Forms.Label();
            this.txtLetter = new System.Windows.Forms.TextBox();
            this.btnChoose = new System.Windows.Forms.Button();
            this.lblLettersLeft = new System.Windows.Forms.Label();
            this.btnOkay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLand
            // 
            this.lblLand.AutoSize = true;
            this.lblLand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLand.Location = new System.Drawing.Point(56, 24);
            this.lblLand.Name = "lblLand";
            this.lblLand.Size = new System.Drawing.Size(173, 20);
            this.lblLand.TabIndex = 0;
            this.lblLand.Text = "You have landed on ";
            // 
            // txtLand
            // 
            this.txtLand.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtLand.Location = new System.Drawing.Point(80, 56);
            this.txtLand.Name = "txtLand";
            this.txtLand.ReadOnly = true;
            this.txtLand.Size = new System.Drawing.Size(120, 20);
            this.txtLand.TabIndex = 1;
            // 
            // lblLetter
            // 
            this.lblLetter.AutoSize = true;
            this.lblLetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLetter.Location = new System.Drawing.Point(56, 136);
            this.lblLetter.Name = "lblLetter";
            this.lblLetter.Size = new System.Drawing.Size(98, 16);
            this.lblLetter.TabIndex = 2;
            this.lblLetter.Text = "Choose a letter";
            // 
            // txtLetter
            // 
            this.txtLetter.Location = new System.Drawing.Point(160, 136);
            this.txtLetter.Name = "txtLetter";
            this.txtLetter.Size = new System.Drawing.Size(56, 20);
            this.txtLetter.TabIndex = 3;
            // 
            // btnChoose
            // 
            this.btnChoose.Location = new System.Drawing.Point(96, 160);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(83, 23);
            this.btnChoose.TabIndex = 4;
            this.btnChoose.Text = "Submit";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // lblLettersLeft
            // 
            this.lblLettersLeft.AutoSize = true;
            this.lblLettersLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLettersLeft.Location = new System.Drawing.Point(8, 96);
            this.lblLettersLeft.Name = "lblLettersLeft";
            this.lblLettersLeft.Size = new System.Drawing.Size(268, 16);
            this.lblLettersLeft.TabIndex = 5;
            this.lblLettersLeft.Text = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            // 
            // btnOkay
            // 
            this.btnOkay.Location = new System.Drawing.Point(56, 192);
            this.btnOkay.Name = "btnOkay";
            this.btnOkay.Size = new System.Drawing.Size(160, 23);
            this.btnOkay.TabIndex = 6;
            this.btnOkay.Text = "Okay";
            this.btnOkay.UseVisualStyleBackColor = true;
            this.btnOkay.Visible = false;
            this.btnOkay.Click += new System.EventHandler(this.btnOkay_Click);
            // 
            // Spin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 230);
            this.Controls.Add(this.btnOkay);
            this.Controls.Add(this.lblLettersLeft);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.txtLetter);
            this.Controls.Add(this.lblLetter);
            this.Controls.Add(this.txtLand);
            this.Controls.Add(this.lblLand);
            this.Name = "Spin";
            this.Text = "Spin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLand;
        public System.Windows.Forms.Label lblLettersLeft;
        public System.Windows.Forms.TextBox txtLand;
        public System.Windows.Forms.TextBox txtLetter;
        public System.Windows.Forms.Label lblLetter;
        public System.Windows.Forms.Button btnChoose;
        public System.Windows.Forms.Button btnOkay;
    }
}