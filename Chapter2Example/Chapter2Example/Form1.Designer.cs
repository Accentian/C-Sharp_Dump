namespace Chapter2Example
{
    partial class frmWelcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWelcome));
            this.btnWelcome = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.picIBM = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picIBM)).BeginInit();
            this.SuspendLayout();
            // 
            // btnWelcome
            // 
            this.btnWelcome.Location = new System.Drawing.Point(56, 223);
            this.btnWelcome.Name = "btnWelcome";
            this.btnWelcome.Size = new System.Drawing.Size(124, 35);
            this.btnWelcome.TabIndex = 0;
            this.btnWelcome.Text = "Click Me";
            this.btnWelcome.UseVisualStyleBackColor = true;
            this.btnWelcome.Click += new System.EventHandler(this.btnWelcome_Click);
            this.btnWelcome.MouseHover += new System.EventHandler(this.btnWelcome_MouseHover);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(164, 191);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(127, 13);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Message will appear here";
            // 
            // picIBM
            // 
            this.picIBM.Image = ((System.Drawing.Image)(resources.GetObject("picIBM.Image")));
            this.picIBM.Location = new System.Drawing.Point(56, 12);
            this.picIBM.Name = "picIBM";
            this.picIBM.Size = new System.Drawing.Size(340, 148);
            this.picIBM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picIBM.TabIndex = 2;
            this.picIBM.TabStop = false;
            this.picIBM.Click += new System.EventHandler(this.picIBM_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(272, 223);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(124, 35);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 295);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.picIBM);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnWelcome);
            this.Name = "frmWelcome";
            this.Text = "Welcome to CSC - 153";
            ((System.ComponentModel.ISupportInitialize)(this.picIBM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWelcome;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.PictureBox picIBM;
        private System.Windows.Forms.Button btnExit;
    }
}

