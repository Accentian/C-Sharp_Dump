namespace PigLatin
{
    partial class frmPigLatin
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
            this.txtEnter = new System.Windows.Forms.TextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblWordCount = new System.Windows.Forms.Label();
            this.lblVowels = new System.Windows.Forms.Label();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.txtVowels = new System.Windows.Forms.TextBox();
            this.btnTranslate = new System.Windows.Forms.Button();
            this.txtTranslation = new System.Windows.Forms.TextBox();
            this.lblLatin = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEnter
            // 
            this.txtEnter.Location = new System.Drawing.Point(12, 80);
            this.txtEnter.Name = "txtEnter";
            this.txtEnter.Size = new System.Drawing.Size(497, 20);
            this.txtEnter.TabIndex = 0;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.Location = new System.Drawing.Point(70, 34);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(377, 25);
            this.lblDesc.TabIndex = 1;
            this.lblDesc.Text = "Enter your sentence or word below";
            // 
            // lblWordCount
            // 
            this.lblWordCount.AutoSize = true;
            this.lblWordCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWordCount.Location = new System.Drawing.Point(9, 124);
            this.lblWordCount.Name = "lblWordCount";
            this.lblWordCount.Size = new System.Drawing.Size(98, 20);
            this.lblWordCount.TabIndex = 2;
            this.lblWordCount.Text = "Word Count:";
            // 
            // lblVowels
            // 
            this.lblVowels.AutoSize = true;
            this.lblVowels.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVowels.Location = new System.Drawing.Point(9, 163);
            this.lblVowels.Name = "lblVowels";
            this.lblVowels.Size = new System.Drawing.Size(142, 20);
            this.lblVowels.TabIndex = 3;
            this.lblVowels.Text = "Number of Vowels:";
            // 
            // txtCount
            // 
            this.txtCount.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtCount.Location = new System.Drawing.Point(113, 126);
            this.txtCount.Name = "txtCount";
            this.txtCount.ReadOnly = true;
            this.txtCount.Size = new System.Drawing.Size(100, 20);
            this.txtCount.TabIndex = 4;
            // 
            // txtVowels
            // 
            this.txtVowels.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtVowels.Location = new System.Drawing.Point(157, 165);
            this.txtVowels.Name = "txtVowels";
            this.txtVowels.ReadOnly = true;
            this.txtVowels.Size = new System.Drawing.Size(100, 20);
            this.txtVowels.TabIndex = 5;
            // 
            // btnTranslate
            // 
            this.btnTranslate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTranslate.Location = new System.Drawing.Point(157, 207);
            this.btnTranslate.Name = "btnTranslate";
            this.btnTranslate.Size = new System.Drawing.Size(193, 29);
            this.btnTranslate.TabIndex = 6;
            this.btnTranslate.Text = "Translate to Pig Latin";
            this.btnTranslate.UseVisualStyleBackColor = true;
            this.btnTranslate.Click += new System.EventHandler(this.btnTranslate_Click);
            // 
            // txtTranslation
            // 
            this.txtTranslation.BackColor = System.Drawing.Color.Azure;
            this.txtTranslation.Location = new System.Drawing.Point(12, 279);
            this.txtTranslation.Multiline = true;
            this.txtTranslation.Name = "txtTranslation";
            this.txtTranslation.ReadOnly = true;
            this.txtTranslation.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTranslation.Size = new System.Drawing.Size(497, 55);
            this.txtTranslation.TabIndex = 7;
            // 
            // lblLatin
            // 
            this.lblLatin.AutoSize = true;
            this.lblLatin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLatin.Location = new System.Drawing.Point(204, 251);
            this.lblLatin.Name = "lblLatin";
            this.lblLatin.Size = new System.Drawing.Size(105, 25);
            this.lblLatin.TabIndex = 8;
            this.lblLatin.Text = "Pig Latin";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(194, 351);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(124, 23);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmPigLatin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 390);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblLatin);
            this.Controls.Add(this.txtTranslation);
            this.Controls.Add(this.btnTranslate);
            this.Controls.Add(this.txtVowels);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.lblVowels);
            this.Controls.Add(this.lblWordCount);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.txtEnter);
            this.Name = "frmPigLatin";
            this.Text = "Pig Latin Translator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEnter;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblWordCount;
        private System.Windows.Forms.Label lblVowels;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.TextBox txtVowels;
        private System.Windows.Forms.Button btnTranslate;
        private System.Windows.Forms.TextBox txtTranslation;
        private System.Windows.Forms.Label lblLatin;
        private System.Windows.Forms.Button btnClear;
    }
}

