namespace DistanceConverter
{
    partial class frmDistanceConverter
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
            this.lblEnter = new System.Windows.Forms.Label();
            this.txtEnter = new System.Windows.Forms.TextBox();
            this.grpTo = new System.Windows.Forms.GroupBox();
            this.lstTo = new System.Windows.Forms.ListBox();
            this.grpFrom = new System.Windows.Forms.GroupBox();
            this.lstFrom = new System.Windows.Forms.ListBox();
            this.lblResults = new System.Windows.Forms.Label();
            this.txtResults = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpTo.SuspendLayout();
            this.grpFrom.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEnter
            // 
            this.lblEnter.AutoSize = true;
            this.lblEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnter.Location = new System.Drawing.Point(12, 23);
            this.lblEnter.Name = "lblEnter";
            this.lblEnter.Size = new System.Drawing.Size(192, 18);
            this.lblEnter.TabIndex = 0;
            this.lblEnter.Text = "Enter a distance to convert: ";
            // 
            // txtEnter
            // 
            this.txtEnter.Location = new System.Drawing.Point(197, 24);
            this.txtEnter.Name = "txtEnter";
            this.txtEnter.Size = new System.Drawing.Size(100, 20);
            this.txtEnter.TabIndex = 1;
            // 
            // grpTo
            // 
            this.grpTo.Controls.Add(this.lstTo);
            this.grpTo.Location = new System.Drawing.Point(159, 61);
            this.grpTo.Name = "grpTo";
            this.grpTo.Size = new System.Drawing.Size(138, 84);
            this.grpTo.TabIndex = 3;
            this.grpTo.TabStop = false;
            this.grpTo.Text = "To";
            // 
            // lstTo
            // 
            this.lstTo.FormattingEnabled = true;
            this.lstTo.Items.AddRange(new object[] {
            "Inches",
            "Feet",
            "Yards"});
            this.lstTo.Location = new System.Drawing.Point(6, 19);
            this.lstTo.Name = "lstTo";
            this.lstTo.Size = new System.Drawing.Size(126, 56);
            this.lstTo.TabIndex = 0;
            // 
            // grpFrom
            // 
            this.grpFrom.Controls.Add(this.lstFrom);
            this.grpFrom.Location = new System.Drawing.Point(15, 61);
            this.grpFrom.Name = "grpFrom";
            this.grpFrom.Size = new System.Drawing.Size(138, 84);
            this.grpFrom.TabIndex = 2;
            this.grpFrom.TabStop = false;
            this.grpFrom.Text = "From";
            // 
            // lstFrom
            // 
            this.lstFrom.FormattingEnabled = true;
            this.lstFrom.Items.AddRange(new object[] {
            "Inches",
            "Feet",
            "Yards"});
            this.lstFrom.Location = new System.Drawing.Point(6, 19);
            this.lstFrom.Name = "lstFrom";
            this.lstFrom.Size = new System.Drawing.Size(126, 56);
            this.lstFrom.TabIndex = 0;
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResults.Location = new System.Drawing.Point(15, 173);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(132, 16);
            this.lblResults.TabIndex = 4;
            this.lblResults.Text = "Converted Distance: ";
            // 
            // txtResults
            // 
            this.txtResults.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtResults.Location = new System.Drawing.Point(159, 172);
            this.txtResults.Name = "txtResults";
            this.txtResults.ReadOnly = true;
            this.txtResults.Size = new System.Drawing.Size(132, 20);
            this.txtResults.TabIndex = 5;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(72, 228);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 6;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(159, 228);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmDistanceConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 279);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txtResults);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.grpTo);
            this.Controls.Add(this.grpFrom);
            this.Controls.Add(this.txtEnter);
            this.Controls.Add(this.lblEnter);
            this.Name = "frmDistanceConverter";
            this.Text = "Distance Converter";
            this.grpTo.ResumeLayout(false);
            this.grpFrom.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnter;
        private System.Windows.Forms.TextBox txtEnter;
        private System.Windows.Forms.GroupBox grpTo;
        private System.Windows.Forms.GroupBox grpFrom;
        private System.Windows.Forms.ListBox lstFrom;
        private System.Windows.Forms.ListBox lstTo;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.TextBox txtResults;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnExit;
    }
}

