namespace Chapter5Examples
{
    partial class frmLoop
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
            this.lstNumbers = new System.Windows.Forms.ListBox();
            this.btnAddNumbers = new System.Windows.Forms.Button();
            this.lstBands = new System.Windows.Forms.ListBox();
            this.btnBands = new System.Windows.Forms.Button();
            this.btnForLoop = new System.Windows.Forms.Button();
            this.btnFile = new System.Windows.Forms.Button();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.btnRandom = new System.Windows.Forms.Button();
            this.picDie = new System.Windows.Forms.PictureBox();
            this.btnFlip = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picDie)).BeginInit();
            this.SuspendLayout();
            // 
            // lstNumbers
            // 
            this.lstNumbers.FormattingEnabled = true;
            this.lstNumbers.Location = new System.Drawing.Point(12, 12);
            this.lstNumbers.Name = "lstNumbers";
            this.lstNumbers.Size = new System.Drawing.Size(120, 95);
            this.lstNumbers.TabIndex = 0;
            // 
            // btnAddNumbers
            // 
            this.btnAddNumbers.Location = new System.Drawing.Point(13, 114);
            this.btnAddNumbers.Name = "btnAddNumbers";
            this.btnAddNumbers.Size = new System.Drawing.Size(119, 23);
            this.btnAddNumbers.TabIndex = 1;
            this.btnAddNumbers.Text = "Add Numbers";
            this.btnAddNumbers.UseVisualStyleBackColor = true;
            this.btnAddNumbers.Click += new System.EventHandler(this.btnAddNumbers_Click);
            // 
            // lstBands
            // 
            this.lstBands.FormattingEnabled = true;
            this.lstBands.Location = new System.Drawing.Point(248, 12);
            this.lstBands.Name = "lstBands";
            this.lstBands.Size = new System.Drawing.Size(120, 95);
            this.lstBands.TabIndex = 2;
            // 
            // btnBands
            // 
            this.btnBands.Location = new System.Drawing.Point(248, 113);
            this.btnBands.Name = "btnBands";
            this.btnBands.Size = new System.Drawing.Size(120, 23);
            this.btnBands.TabIndex = 3;
            this.btnBands.Text = "Add Bands";
            this.btnBands.UseVisualStyleBackColor = true;
            this.btnBands.Click += new System.EventHandler(this.btnBands_Click);
            // 
            // btnForLoop
            // 
            this.btnForLoop.Location = new System.Drawing.Point(13, 143);
            this.btnForLoop.Name = "btnForLoop";
            this.btnForLoop.Size = new System.Drawing.Size(119, 23);
            this.btnForLoop.TabIndex = 4;
            this.btnForLoop.Text = "For Loop";
            this.btnForLoop.UseVisualStyleBackColor = true;
            this.btnForLoop.Click += new System.EventHandler(this.btnForLoop_Click);
            // 
            // btnFile
            // 
            this.btnFile.Location = new System.Drawing.Point(248, 143);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(120, 23);
            this.btnFile.TabIndex = 5;
            this.btnFile.Text = "Write to File";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(138, 162);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.ReadOnly = true;
            this.txtNumber.Size = new System.Drawing.Size(104, 20);
            this.txtNumber.TabIndex = 6;
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(138, 188);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(104, 23);
            this.btnRandom.TabIndex = 7;
            this.btnRandom.Text = "Random";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // picDie
            // 
            this.picDie.Image = global::Chapter5Examples.Properties.Resources._2Die;
            this.picDie.Location = new System.Drawing.Point(138, 52);
            this.picDie.Name = "picDie";
            this.picDie.Size = new System.Drawing.Size(104, 104);
            this.picDie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picDie.TabIndex = 8;
            this.picDie.TabStop = false;
            // 
            // btnFlip
            // 
            this.btnFlip.Location = new System.Drawing.Point(138, 12);
            this.btnFlip.Name = "btnFlip";
            this.btnFlip.Size = new System.Drawing.Size(104, 21);
            this.btnFlip.TabIndex = 9;
            this.btnFlip.Text = "Flip Image";
            this.btnFlip.UseVisualStyleBackColor = true;
            this.btnFlip.Click += new System.EventHandler(this.btnFlip_Click);
            // 
            // frmLoop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 223);
            this.Controls.Add(this.btnFlip);
            this.Controls.Add(this.picDie);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.btnFile);
            this.Controls.Add(this.btnForLoop);
            this.Controls.Add(this.btnBands);
            this.Controls.Add(this.lstBands);
            this.Controls.Add(this.btnAddNumbers);
            this.Controls.Add(this.lstNumbers);
            this.Name = "frmLoop";
            this.Text = "Chapter 5 Examples";
            ((System.ComponentModel.ISupportInitialize)(this.picDie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstNumbers;
        private System.Windows.Forms.Button btnAddNumbers;
        private System.Windows.Forms.ListBox lstBands;
        private System.Windows.Forms.Button btnBands;
        private System.Windows.Forms.Button btnForLoop;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.PictureBox picDie;
        private System.Windows.Forms.Button btnFlip;
    }
}

