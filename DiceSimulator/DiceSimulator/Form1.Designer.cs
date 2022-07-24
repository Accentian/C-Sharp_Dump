namespace DiceSimulator
{
    partial class frmDice
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
            this.picDieP1 = new System.Windows.Forms.PictureBox();
            this.picDieP2 = new System.Windows.Forms.PictureBox();
            this.picDieC1 = new System.Windows.Forms.PictureBox();
            this.picDieC2 = new System.Windows.Forms.PictureBox();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.lblCPU = new System.Windows.Forms.Label();
            this.txtWin = new System.Windows.Forms.TextBox();
            this.lblWin = new System.Windows.Forms.Label();
            this.lblLost = new System.Windows.Forms.Label();
            this.txtLost = new System.Windows.Forms.TextBox();
            this.lblTie = new System.Windows.Forms.Label();
            this.txtTie = new System.Windows.Forms.TextBox();
            this.btnRoll = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picDieP1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDieP2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDieC1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDieC2)).BeginInit();
            this.SuspendLayout();
            // 
            // picDieP1
            // 
            this.picDieP1.Image = global::DiceSimulator.Properties.Resources._1Die;
            this.picDieP1.Location = new System.Drawing.Point(12, 52);
            this.picDieP1.Name = "picDieP1";
            this.picDieP1.Size = new System.Drawing.Size(104, 104);
            this.picDieP1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picDieP1.TabIndex = 0;
            this.picDieP1.TabStop = false;
            // 
            // picDieP2
            // 
            this.picDieP2.Image = global::DiceSimulator.Properties.Resources._3Die;
            this.picDieP2.Location = new System.Drawing.Point(122, 52);
            this.picDieP2.Name = "picDieP2";
            this.picDieP2.Size = new System.Drawing.Size(104, 104);
            this.picDieP2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picDieP2.TabIndex = 1;
            this.picDieP2.TabStop = false;
            // 
            // picDieC1
            // 
            this.picDieC1.Image = global::DiceSimulator.Properties.Resources._2Die;
            this.picDieC1.Location = new System.Drawing.Point(303, 52);
            this.picDieC1.Name = "picDieC1";
            this.picDieC1.Size = new System.Drawing.Size(104, 104);
            this.picDieC1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picDieC1.TabIndex = 2;
            this.picDieC1.TabStop = false;
            // 
            // picDieC2
            // 
            this.picDieC2.Image = global::DiceSimulator.Properties.Resources._4Die;
            this.picDieC2.Location = new System.Drawing.Point(413, 52);
            this.picDieC2.Name = "picDieC2";
            this.picDieC2.Size = new System.Drawing.Size(104, 104);
            this.picDieC2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picDieC2.TabIndex = 3;
            this.picDieC2.TabStop = false;
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPlayer.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer.Location = new System.Drawing.Point(84, 25);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(72, 24);
            this.lblPlayer.TabIndex = 4;
            this.lblPlayer.Text = "Player";
            // 
            // lblCPU
            // 
            this.lblCPU.AutoSize = true;
            this.lblCPU.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCPU.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPU.Location = new System.Drawing.Point(384, 25);
            this.lblCPU.Name = "lblCPU";
            this.lblCPU.Size = new System.Drawing.Size(53, 24);
            this.lblCPU.TabIndex = 5;
            this.lblCPU.Text = "CPU";
            // 
            // txtWin
            // 
            this.txtWin.BackColor = System.Drawing.SystemColors.Window;
            this.txtWin.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtWin.Location = new System.Drawing.Point(12, 249);
            this.txtWin.Name = "txtWin";
            this.txtWin.ReadOnly = true;
            this.txtWin.Size = new System.Drawing.Size(68, 20);
            this.txtWin.TabIndex = 6;
            // 
            // lblWin
            // 
            this.lblWin.AutoSize = true;
            this.lblWin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWin.Location = new System.Drawing.Point(6, 215);
            this.lblWin.Name = "lblWin";
            this.lblWin.Size = new System.Drawing.Size(70, 31);
            this.lblWin.TabIndex = 7;
            this.lblWin.Text = "WIN";
            // 
            // lblLost
            // 
            this.lblLost.AutoSize = true;
            this.lblLost.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLost.Location = new System.Drawing.Point(444, 217);
            this.lblLost.Name = "lblLost";
            this.lblLost.Size = new System.Drawing.Size(81, 29);
            this.lblLost.TabIndex = 8;
            this.lblLost.Text = "LOST";
            // 
            // txtLost
            // 
            this.txtLost.BackColor = System.Drawing.SystemColors.Window;
            this.txtLost.Location = new System.Drawing.Point(449, 249);
            this.txtLost.Name = "txtLost";
            this.txtLost.ReadOnly = true;
            this.txtLost.Size = new System.Drawing.Size(68, 20);
            this.txtLost.TabIndex = 9;
            // 
            // lblTie
            // 
            this.lblTie.AutoSize = true;
            this.lblTie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTie.Location = new System.Drawing.Point(242, 221);
            this.lblTie.Name = "lblTie";
            this.lblTie.Size = new System.Drawing.Size(47, 25);
            this.lblTie.TabIndex = 10;
            this.lblTie.Text = "TIE";
            // 
            // txtTie
            // 
            this.txtTie.BackColor = System.Drawing.SystemColors.Window;
            this.txtTie.Location = new System.Drawing.Point(234, 250);
            this.txtTie.Name = "txtTie";
            this.txtTie.ReadOnly = true;
            this.txtTie.Size = new System.Drawing.Size(65, 20);
            this.txtTie.TabIndex = 11;
            // 
            // btnRoll
            // 
            this.btnRoll.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRoll.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoll.Location = new System.Drawing.Point(122, 286);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(285, 46);
            this.btnRoll.TabIndex = 12;
            this.btnRoll.Text = "Roll!";
            this.btnRoll.UseVisualStyleBackColor = false;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnd.Location = new System.Drawing.Point(122, 338);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(285, 35);
            this.btnEnd.TabIndex = 13;
            this.btnEnd.Text = "End";
            this.btnEnd.UseVisualStyleBackColor = false;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // frmDice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 385);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.btnRoll);
            this.Controls.Add(this.txtTie);
            this.Controls.Add(this.lblTie);
            this.Controls.Add(this.txtLost);
            this.Controls.Add(this.lblLost);
            this.Controls.Add(this.lblWin);
            this.Controls.Add(this.txtWin);
            this.Controls.Add(this.lblCPU);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.picDieC2);
            this.Controls.Add(this.picDieC1);
            this.Controls.Add(this.picDieP2);
            this.Controls.Add(this.picDieP1);
            this.Name = "frmDice";
            this.Text = "Dice Simulator Game";
            ((System.ComponentModel.ISupportInitialize)(this.picDieP1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDieP2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDieC1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDieC2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picDieP1;
        private System.Windows.Forms.PictureBox picDieP2;
        private System.Windows.Forms.PictureBox picDieC1;
        private System.Windows.Forms.PictureBox picDieC2;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Label lblCPU;
        private System.Windows.Forms.TextBox txtWin;
        private System.Windows.Forms.Label lblWin;
        private System.Windows.Forms.Label lblLost;
        private System.Windows.Forms.TextBox txtLost;
        private System.Windows.Forms.Label lblTie;
        private System.Windows.Forms.TextBox txtTie;
        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.Button btnEnd;
    }
}

