namespace ClassesExample
{
    partial class frmExample
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
            this.btnToss = new System.Windows.Forms.Button();
            this.lblToss = new System.Windows.Forms.Label();
            this.btnProperty = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnToss
            // 
            this.btnToss.Location = new System.Drawing.Point(171, 45);
            this.btnToss.Name = "btnToss";
            this.btnToss.Size = new System.Drawing.Size(75, 23);
            this.btnToss.TabIndex = 0;
            this.btnToss.Text = "Toss";
            this.btnToss.UseVisualStyleBackColor = true;
            this.btnToss.Click += new System.EventHandler(this.btnToss_Click);
            // 
            // lblToss
            // 
            this.lblToss.AutoSize = true;
            this.lblToss.Location = new System.Drawing.Point(171, 91);
            this.lblToss.Name = "lblToss";
            this.lblToss.Size = new System.Drawing.Size(75, 13);
            this.lblToss.TabIndex = 1;
            this.lblToss.Text = "Heads or Tails";
            this.lblToss.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnProperty
            // 
            this.btnProperty.Location = new System.Drawing.Point(171, 125);
            this.btnProperty.Name = "btnProperty";
            this.btnProperty.Size = new System.Drawing.Size(75, 42);
            this.btnProperty.TabIndex = 2;
            this.btnProperty.Text = "Test Property";
            this.btnProperty.UseVisualStyleBackColor = true;
            this.btnProperty.Click += new System.EventHandler(this.btnProperty_Click);
            // 
            // frmExample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 322);
            this.Controls.Add(this.btnProperty);
            this.Controls.Add(this.lblToss);
            this.Controls.Add(this.btnToss);
            this.Name = "frmExample";
            this.Text = "Classes Example";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnToss;
        private System.Windows.Forms.Label lblToss;
        private System.Windows.Forms.Button btnProperty;
    }
}

