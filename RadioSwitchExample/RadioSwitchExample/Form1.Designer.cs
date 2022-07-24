namespace RadioSwitchExample
{
    partial class frmRadioSwitch
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
            this.grpDrinks = new System.Windows.Forms.GroupBox();
            this.radCoffee = new System.Windows.Forms.RadioButton();
            this.radTea = new System.Windows.Forms.RadioButton();
            this.lstBands = new System.Windows.Forms.ListBox();
            this.btnRating = new System.Windows.Forms.Button();
            this.grpDrinks.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDrinks
            // 
            this.grpDrinks.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grpDrinks.Controls.Add(this.radTea);
            this.grpDrinks.Controls.Add(this.radCoffee);
            this.grpDrinks.Location = new System.Drawing.Point(61, 21);
            this.grpDrinks.Name = "grpDrinks";
            this.grpDrinks.Size = new System.Drawing.Size(128, 78);
            this.grpDrinks.TabIndex = 0;
            this.grpDrinks.TabStop = false;
            this.grpDrinks.Text = "Choose Your Drink";
            // 
            // radCoffee
            // 
            this.radCoffee.AutoSize = true;
            this.radCoffee.Checked = true;
            this.radCoffee.Location = new System.Drawing.Point(7, 20);
            this.radCoffee.Name = "radCoffee";
            this.radCoffee.Size = new System.Drawing.Size(56, 17);
            this.radCoffee.TabIndex = 0;
            this.radCoffee.TabStop = true;
            this.radCoffee.Text = "Coffee";
            this.radCoffee.UseVisualStyleBackColor = true;
            this.radCoffee.CheckedChanged += new System.EventHandler(this.radCoffee_CheckedChanged);
            // 
            // radTea
            // 
            this.radTea.AutoSize = true;
            this.radTea.Location = new System.Drawing.Point(7, 44);
            this.radTea.Name = "radTea";
            this.radTea.Size = new System.Drawing.Size(44, 17);
            this.radTea.TabIndex = 1;
            this.radTea.Text = "Tea";
            this.radTea.UseVisualStyleBackColor = true;
            this.radTea.CheckedChanged += new System.EventHandler(this.radTea_CheckedChanged);
            // 
            // lstBands
            // 
            this.lstBands.FormattingEnabled = true;
            this.lstBands.Items.AddRange(new object[] {
            "Rolling Stone",
            "John Merk",
            "The Beetles"});
            this.lstBands.Location = new System.Drawing.Point(13, 105);
            this.lstBands.Name = "lstBands";
            this.lstBands.Size = new System.Drawing.Size(223, 95);
            this.lstBands.TabIndex = 1;
            // 
            // btnRating
            // 
            this.btnRating.Location = new System.Drawing.Point(61, 222);
            this.btnRating.Name = "btnRating";
            this.btnRating.Size = new System.Drawing.Size(128, 23);
            this.btnRating.TabIndex = 2;
            this.btnRating.Text = "Rating";
            this.btnRating.UseVisualStyleBackColor = true;
            this.btnRating.Click += new System.EventHandler(this.btnRating_Click);
            // 
            // frmRadioSwitch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 302);
            this.Controls.Add(this.btnRating);
            this.Controls.Add(this.lstBands);
            this.Controls.Add(this.grpDrinks);
            this.Name = "frmRadioSwitch";
            this.Text = "Radio Switch Example";
            this.grpDrinks.ResumeLayout(false);
            this.grpDrinks.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDrinks;
        private System.Windows.Forms.RadioButton radTea;
        private System.Windows.Forms.RadioButton radCoffee;
        private System.Windows.Forms.ListBox lstBands;
        private System.Windows.Forms.Button btnRating;
    }
}

