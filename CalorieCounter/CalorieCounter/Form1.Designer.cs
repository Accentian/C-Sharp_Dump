namespace CalorieCounter
{
    partial class frmCalorieCounter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalorieCounter));
            this.picBananna = new System.Windows.Forms.PictureBox();
            this.picApple = new System.Windows.Forms.PictureBox();
            this.picOrange = new System.Windows.Forms.PictureBox();
            this.picPear = new System.Windows.Forms.PictureBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtCalorieBananna = new System.Windows.Forms.TextBox();
            this.txtAppleCalorie = new System.Windows.Forms.TextBox();
            this.txtPearCalorie = new System.Windows.Forms.TextBox();
            this.txtOrangeCalorie = new System.Windows.Forms.TextBox();
            this.txtCalorie = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBananna)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picApple)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOrange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPear)).BeginInit();
            this.SuspendLayout();
            // 
            // picBananna
            // 
            this.picBananna.Image = ((System.Drawing.Image)(resources.GetObject("picBananna.Image")));
            this.picBananna.Location = new System.Drawing.Point(12, 12);
            this.picBananna.Name = "picBananna";
            this.picBananna.Size = new System.Drawing.Size(128, 128);
            this.picBananna.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBananna.TabIndex = 0;
            this.picBananna.TabStop = false;
            this.picBananna.Click += new System.EventHandler(this.picBananna_Click);
            // 
            // picApple
            // 
            this.picApple.Image = ((System.Drawing.Image)(resources.GetObject("picApple.Image")));
            this.picApple.Location = new System.Drawing.Point(146, 12);
            this.picApple.Name = "picApple";
            this.picApple.Size = new System.Drawing.Size(128, 128);
            this.picApple.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picApple.TabIndex = 1;
            this.picApple.TabStop = false;
            this.picApple.Click += new System.EventHandler(this.picApple_Click);
            // 
            // picOrange
            // 
            this.picOrange.Image = ((System.Drawing.Image)(resources.GetObject("picOrange.Image")));
            this.picOrange.Location = new System.Drawing.Point(12, 163);
            this.picOrange.Name = "picOrange";
            this.picOrange.Size = new System.Drawing.Size(128, 128);
            this.picOrange.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picOrange.TabIndex = 2;
            this.picOrange.TabStop = false;
            this.picOrange.Click += new System.EventHandler(this.picOrange_Click);
            // 
            // picPear
            // 
            this.picPear.Image = ((System.Drawing.Image)(resources.GetObject("picPear.Image")));
            this.picPear.Location = new System.Drawing.Point(146, 163);
            this.picPear.Name = "picPear";
            this.picPear.Size = new System.Drawing.Size(128, 128);
            this.picPear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picPear.TabIndex = 3;
            this.picPear.TabStop = false;
            this.picPear.Click += new System.EventHandler(this.picPear_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(299, 12);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(119, 20);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Total Calories";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(322, 268);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(322, 239);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtCalorieBananna
            // 
            this.txtCalorieBananna.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtCalorieBananna.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCalorieBananna.ForeColor = System.Drawing.SystemColors.Window;
            this.txtCalorieBananna.Location = new System.Drawing.Point(12, 137);
            this.txtCalorieBananna.Name = "txtCalorieBananna";
            this.txtCalorieBananna.ReadOnly = true;
            this.txtCalorieBananna.Size = new System.Drawing.Size(128, 20);
            this.txtCalorieBananna.TabIndex = 8;
            this.txtCalorieBananna.Text = "115 Calories";
            this.txtCalorieBananna.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAppleCalorie
            // 
            this.txtAppleCalorie.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtAppleCalorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAppleCalorie.ForeColor = System.Drawing.SystemColors.Window;
            this.txtAppleCalorie.Location = new System.Drawing.Point(146, 137);
            this.txtAppleCalorie.Name = "txtAppleCalorie";
            this.txtAppleCalorie.ReadOnly = true;
            this.txtAppleCalorie.Size = new System.Drawing.Size(128, 20);
            this.txtAppleCalorie.TabIndex = 9;
            this.txtAppleCalorie.Text = "80 Calories";
            this.txtAppleCalorie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPearCalorie
            // 
            this.txtPearCalorie.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtPearCalorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPearCalorie.ForeColor = System.Drawing.SystemColors.Window;
            this.txtPearCalorie.Location = new System.Drawing.Point(146, 290);
            this.txtPearCalorie.Name = "txtPearCalorie";
            this.txtPearCalorie.ReadOnly = true;
            this.txtPearCalorie.Size = new System.Drawing.Size(128, 20);
            this.txtPearCalorie.TabIndex = 11;
            this.txtPearCalorie.Text = "120 Calories";
            this.txtPearCalorie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtOrangeCalorie
            // 
            this.txtOrangeCalorie.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtOrangeCalorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrangeCalorie.ForeColor = System.Drawing.SystemColors.Window;
            this.txtOrangeCalorie.Location = new System.Drawing.Point(12, 290);
            this.txtOrangeCalorie.Name = "txtOrangeCalorie";
            this.txtOrangeCalorie.ReadOnly = true;
            this.txtOrangeCalorie.Size = new System.Drawing.Size(128, 20);
            this.txtOrangeCalorie.TabIndex = 10;
            this.txtOrangeCalorie.Text = "90 Calories";
            this.txtOrangeCalorie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCalorie
            // 
            this.txtCalorie.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtCalorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCalorie.Location = new System.Drawing.Point(303, 36);
            this.txtCalorie.Name = "txtCalorie";
            this.txtCalorie.ReadOnly = true;
            this.txtCalorie.Size = new System.Drawing.Size(115, 22);
            this.txtCalorie.TabIndex = 12;
            this.txtCalorie.Text = "0";
            this.txtCalorie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmCalorieCounter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 322);
            this.Controls.Add(this.txtCalorie);
            this.Controls.Add(this.txtPearCalorie);
            this.Controls.Add(this.txtOrangeCalorie);
            this.Controls.Add(this.txtAppleCalorie);
            this.Controls.Add(this.txtCalorieBananna);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.picPear);
            this.Controls.Add(this.picOrange);
            this.Controls.Add(this.picApple);
            this.Controls.Add(this.picBananna);
            this.Name = "frmCalorieCounter";
            this.Text = "Calorie Counter";
            ((System.ComponentModel.ISupportInitialize)(this.picBananna)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picApple)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOrange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBananna;
        private System.Windows.Forms.PictureBox picApple;
        private System.Windows.Forms.PictureBox picOrange;
        private System.Windows.Forms.PictureBox picPear;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtCalorieBananna;
        private System.Windows.Forms.TextBox txtAppleCalorie;
        private System.Windows.Forms.TextBox txtPearCalorie;
        private System.Windows.Forms.TextBox txtOrangeCalorie;
        private System.Windows.Forms.TextBox txtCalorie;
    }
}

