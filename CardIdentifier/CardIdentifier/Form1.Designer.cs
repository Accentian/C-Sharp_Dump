namespace CardIdentifier
{
    partial class frmTitle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTitle));
            this.nineDiamonds = new System.Windows.Forms.PictureBox();
            this.spadesAce = new System.Windows.Forms.PictureBox();
            this.fourClubs = new System.Windows.Forms.PictureBox();
            this.redJoker = new System.Windows.Forms.PictureBox();
            this.queenHearts = new System.Windows.Forms.PictureBox();
            this.txtCardType = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nineDiamonds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spadesAce)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fourClubs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redJoker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.queenHearts)).BeginInit();
            this.SuspendLayout();
            // 
            // nineDiamonds
            // 
            this.nineDiamonds.Image = ((System.Drawing.Image)(resources.GetObject("nineDiamonds.Image")));
            this.nineDiamonds.Location = new System.Drawing.Point(31, 25);
            this.nineDiamonds.Name = "nineDiamonds";
            this.nineDiamonds.Size = new System.Drawing.Size(100, 140);
            this.nineDiamonds.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.nineDiamonds.TabIndex = 0;
            this.nineDiamonds.TabStop = false;
            this.nineDiamonds.Click += new System.EventHandler(this.nineDiamonds_Click);
            // 
            // spadesAce
            // 
            this.spadesAce.Image = ((System.Drawing.Image)(resources.GetObject("spadesAce.Image")));
            this.spadesAce.Location = new System.Drawing.Point(155, 25);
            this.spadesAce.Name = "spadesAce";
            this.spadesAce.Size = new System.Drawing.Size(100, 140);
            this.spadesAce.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.spadesAce.TabIndex = 1;
            this.spadesAce.TabStop = false;
            this.spadesAce.Click += new System.EventHandler(this.spadesAce_Click);
            // 
            // fourClubs
            // 
            this.fourClubs.Image = ((System.Drawing.Image)(resources.GetObject("fourClubs.Image")));
            this.fourClubs.Location = new System.Drawing.Point(408, 25);
            this.fourClubs.Name = "fourClubs";
            this.fourClubs.Size = new System.Drawing.Size(100, 140);
            this.fourClubs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fourClubs.TabIndex = 3;
            this.fourClubs.TabStop = false;
            this.fourClubs.Click += new System.EventHandler(this.fourClubs_Click);
            // 
            // redJoker
            // 
            this.redJoker.Image = ((System.Drawing.Image)(resources.GetObject("redJoker.Image")));
            this.redJoker.Location = new System.Drawing.Point(284, 25);
            this.redJoker.Name = "redJoker";
            this.redJoker.Size = new System.Drawing.Size(100, 140);
            this.redJoker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.redJoker.TabIndex = 2;
            this.redJoker.TabStop = false;
            this.redJoker.Click += new System.EventHandler(this.redJoker_Click);
            // 
            // queenHearts
            // 
            this.queenHearts.Image = ((System.Drawing.Image)(resources.GetObject("queenHearts.Image")));
            this.queenHearts.Location = new System.Drawing.Point(539, 25);
            this.queenHearts.Name = "queenHearts";
            this.queenHearts.Size = new System.Drawing.Size(100, 140);
            this.queenHearts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.queenHearts.TabIndex = 4;
            this.queenHearts.TabStop = false;
            this.queenHearts.Click += new System.EventHandler(this.queenHearts_Click);
            // 
            // txtCardType
            // 
            this.txtCardType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCardType.Location = new System.Drawing.Point(12, 208);
            this.txtCardType.Name = "txtCardType";
            this.txtCardType.Size = new System.Drawing.Size(651, 20);
            this.txtCardType.TabIndex = 5;
            this.txtCardType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(284, 252);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmTitle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 299);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtCardType);
            this.Controls.Add(this.queenHearts);
            this.Controls.Add(this.fourClubs);
            this.Controls.Add(this.redJoker);
            this.Controls.Add(this.spadesAce);
            this.Controls.Add(this.nineDiamonds);
            this.Name = "frmTitle";
            this.Text = "Card Identifier";
            ((System.ComponentModel.ISupportInitialize)(this.nineDiamonds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spadesAce)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fourClubs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redJoker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.queenHearts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox nineDiamonds;
        private System.Windows.Forms.PictureBox spadesAce;
        private System.Windows.Forms.PictureBox fourClubs;
        private System.Windows.Forms.PictureBox redJoker;
        private System.Windows.Forms.PictureBox queenHearts;
        private System.Windows.Forms.TextBox txtCardType;
        private System.Windows.Forms.Button btnExit;
    }
}

