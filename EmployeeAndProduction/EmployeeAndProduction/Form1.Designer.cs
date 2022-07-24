namespace EmployeeAndProduction
{
    partial class frmProduction
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblShift = new System.Windows.Forms.Label();
            this.lblPayRate = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtShift = new System.Windows.Forms.TextBox();
            this.txtPayRate = new System.Windows.Forms.TextBox();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.grpSupervisor = new System.Windows.Forms.GroupBox();
            this.radYes = new System.Windows.Forms.RadioButton();
            this.radNo = new System.Windows.Forms.RadioButton();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblBonus = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.txtBonus = new System.Windows.Forms.TextBox();
            this.grpSupervisor.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(13, 38);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(87, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Employee Name:";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(30, 66);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(70, 13);
            this.lblNumber.TabIndex = 1;
            this.lblNumber.Text = "Employee ID:";
            // 
            // lblShift
            // 
            this.lblShift.AutoSize = true;
            this.lblShift.Location = new System.Drawing.Point(29, 94);
            this.lblShift.Name = "lblShift";
            this.lblShift.Size = new System.Drawing.Size(71, 13);
            this.lblShift.TabIndex = 2;
            this.lblShift.Text = "Shift Number:";
            // 
            // lblPayRate
            // 
            this.lblPayRate.AutoSize = true;
            this.lblPayRate.Location = new System.Drawing.Point(19, 121);
            this.lblPayRate.Name = "lblPayRate";
            this.lblPayRate.Size = new System.Drawing.Size(81, 13);
            this.lblPayRate.TabIndex = 3;
            this.lblPayRate.Text = "Hourly pay rate:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(106, 35);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(140, 20);
            this.txtName.TabIndex = 4;
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(106, 63);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(140, 20);
            this.txtNumber.TabIndex = 5;
            // 
            // txtShift
            // 
            this.txtShift.Location = new System.Drawing.Point(106, 91);
            this.txtShift.Name = "txtShift";
            this.txtShift.Size = new System.Drawing.Size(140, 20);
            this.txtShift.TabIndex = 6;
            // 
            // txtPayRate
            // 
            this.txtPayRate.Location = new System.Drawing.Point(106, 118);
            this.txtPayRate.Name = "txtPayRate";
            this.txtPayRate.Size = new System.Drawing.Size(140, 20);
            this.txtPayRate.TabIndex = 7;
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(73, 264);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(115, 23);
            this.btnDisplay.TabIndex = 8;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // grpSupervisor
            // 
            this.grpSupervisor.Controls.Add(this.radNo);
            this.grpSupervisor.Controls.Add(this.radYes);
            this.grpSupervisor.Location = new System.Drawing.Point(73, 214);
            this.grpSupervisor.Name = "grpSupervisor";
            this.grpSupervisor.Size = new System.Drawing.Size(115, 44);
            this.grpSupervisor.TabIndex = 9;
            this.grpSupervisor.TabStop = false;
            this.grpSupervisor.Text = "Supervisor";
            // 
            // radYes
            // 
            this.radYes.AutoSize = true;
            this.radYes.Location = new System.Drawing.Point(10, 20);
            this.radYes.Name = "radYes";
            this.radYes.Size = new System.Drawing.Size(43, 17);
            this.radYes.TabIndex = 0;
            this.radYes.Text = "Yes";
            this.radYes.UseVisualStyleBackColor = true;
            this.radYes.CheckedChanged += new System.EventHandler(this.radYes_CheckedChanged);
            // 
            // radNo
            // 
            this.radNo.AutoSize = true;
            this.radNo.Checked = true;
            this.radNo.Location = new System.Drawing.Point(60, 21);
            this.radNo.Name = "radNo";
            this.radNo.Size = new System.Drawing.Size(39, 17);
            this.radNo.TabIndex = 1;
            this.radNo.TabStop = true;
            this.radNo.Text = "No";
            this.radNo.UseVisualStyleBackColor = true;
            this.radNo.CheckedChanged += new System.EventHandler(this.radNo_CheckedChanged);
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(25, 147);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(75, 13);
            this.lblSalary.TabIndex = 10;
            this.lblSalary.Text = "Annual Salary:";
            this.lblSalary.Visible = false;
            // 
            // lblBonus
            // 
            this.lblBonus.AutoSize = true;
            this.lblBonus.Location = new System.Drawing.Point(10, 172);
            this.lblBonus.Name = "lblBonus";
            this.lblBonus.Size = new System.Drawing.Size(130, 13);
            this.lblBonus.TabIndex = 11;
            this.lblBonus.Text = "Annual Production Bonus:";
            this.lblBonus.Visible = false;
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(106, 144);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(140, 20);
            this.txtSalary.TabIndex = 12;
            this.txtSalary.Visible = false;
            // 
            // txtBonus
            // 
            this.txtBonus.Location = new System.Drawing.Point(146, 169);
            this.txtBonus.Name = "txtBonus";
            this.txtBonus.Size = new System.Drawing.Size(100, 20);
            this.txtBonus.TabIndex = 13;
            this.txtBonus.Visible = false;
            // 
            // frmProduction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 304);
            this.Controls.Add(this.txtBonus);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.lblBonus);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.grpSupervisor);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.txtPayRate);
            this.Controls.Add(this.txtShift);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblPayRate);
            this.Controls.Add(this.lblShift);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.lblName);
            this.Name = "frmProduction";
            this.Text = "Factory Log";
            this.grpSupervisor.ResumeLayout(false);
            this.grpSupervisor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblShift;
        private System.Windows.Forms.Label lblPayRate;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtShift;
        private System.Windows.Forms.TextBox txtPayRate;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.GroupBox grpSupervisor;
        private System.Windows.Forms.RadioButton radNo;
        private System.Windows.Forms.RadioButton radYes;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label lblBonus;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.TextBox txtBonus;
    }
}

