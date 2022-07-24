namespace InheritanceExample
{
    partial class frmInheritance
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
            this.grpEmployee = new System.Windows.Forms.GroupBox();
            this.radStaff = new System.Windows.Forms.RadioButton();
            this.radFaculty = new System.Windows.Forms.RadioButton();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblDevHours = new System.Windows.Forms.Label();
            this.txtDevHours = new System.Windows.Forms.TextBox();
            this.lblCommittees = new System.Windows.Forms.Label();
            this.txtCommittees = new System.Windows.Forms.TextBox();
            this.lblWorkshopHours = new System.Windows.Forms.Label();
            this.txtWorkshopHours = new System.Windows.Forms.TextBox();
            this.lblFlexSpending = new System.Windows.Forms.Label();
            this.txtFlexSpending = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.grpEmployee.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpEmployee
            // 
            this.grpEmployee.Controls.Add(this.radStaff);
            this.grpEmployee.Controls.Add(this.radFaculty);
            this.grpEmployee.Location = new System.Drawing.Point(27, 34);
            this.grpEmployee.Name = "grpEmployee";
            this.grpEmployee.Size = new System.Drawing.Size(76, 80);
            this.grpEmployee.TabIndex = 0;
            this.grpEmployee.TabStop = false;
            this.grpEmployee.Text = "Employees";
            // 
            // radStaff
            // 
            this.radStaff.AutoSize = true;
            this.radStaff.Location = new System.Drawing.Point(7, 43);
            this.radStaff.Name = "radStaff";
            this.radStaff.Size = new System.Drawing.Size(47, 17);
            this.radStaff.TabIndex = 1;
            this.radStaff.TabStop = true;
            this.radStaff.Text = "Staff";
            this.radStaff.UseVisualStyleBackColor = true;
            this.radStaff.CheckedChanged += new System.EventHandler(this.radStaff_CheckedChanged);
            // 
            // radFaculty
            // 
            this.radFaculty.AutoSize = true;
            this.radFaculty.Checked = true;
            this.radFaculty.Location = new System.Drawing.Point(7, 20);
            this.radFaculty.Name = "radFaculty";
            this.radFaculty.Size = new System.Drawing.Size(59, 17);
            this.radFaculty.TabIndex = 0;
            this.radFaculty.TabStop = true;
            this.radFaculty.Text = "Faculty";
            this.radFaculty.UseVisualStyleBackColor = true;
            this.radFaculty.CheckedChanged += new System.EventHandler(this.radFaculty_CheckedChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(195, 35);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(198, 51);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(180, 20);
            this.txtName.TabIndex = 2;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(195, 77);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(48, 13);
            this.lblAddress.TabIndex = 3;
            this.lblAddress.Text = "Address:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(198, 94);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(180, 20);
            this.txtAddress.TabIndex = 4;
            // 
            // lblDevHours
            // 
            this.lblDevHours.AutoSize = true;
            this.lblDevHours.Location = new System.Drawing.Point(31, 149);
            this.lblDevHours.Name = "lblDevHours";
            this.lblDevHours.Size = new System.Drawing.Size(164, 13);
            this.lblDevHours.TabIndex = 5;
            this.lblDevHours.Text = "Professional Development Hours:";
            // 
            // txtDevHours
            // 
            this.txtDevHours.Location = new System.Drawing.Point(34, 165);
            this.txtDevHours.Name = "txtDevHours";
            this.txtDevHours.Size = new System.Drawing.Size(124, 20);
            this.txtDevHours.TabIndex = 6;
            // 
            // lblCommittees
            // 
            this.lblCommittees.AutoSize = true;
            this.lblCommittees.Location = new System.Drawing.Point(31, 204);
            this.lblCommittees.Name = "lblCommittees";
            this.lblCommittees.Size = new System.Drawing.Size(61, 13);
            this.lblCommittees.TabIndex = 7;
            this.lblCommittees.Text = "Committees";
            // 
            // txtCommittees
            // 
            this.txtCommittees.Location = new System.Drawing.Point(34, 220);
            this.txtCommittees.Name = "txtCommittees";
            this.txtCommittees.Size = new System.Drawing.Size(124, 20);
            this.txtCommittees.TabIndex = 8;
            // 
            // lblWorkshopHours
            // 
            this.lblWorkshopHours.AutoSize = true;
            this.lblWorkshopHours.Location = new System.Drawing.Point(233, 149);
            this.lblWorkshopHours.Name = "lblWorkshopHours";
            this.lblWorkshopHours.Size = new System.Drawing.Size(90, 13);
            this.lblWorkshopHours.TabIndex = 9;
            this.lblWorkshopHours.Text = "Workshop Hours:";
            this.lblWorkshopHours.Visible = false;
            // 
            // txtWorkshopHours
            // 
            this.txtWorkshopHours.Location = new System.Drawing.Point(236, 165);
            this.txtWorkshopHours.Name = "txtWorkshopHours";
            this.txtWorkshopHours.Size = new System.Drawing.Size(122, 20);
            this.txtWorkshopHours.TabIndex = 10;
            this.txtWorkshopHours.Visible = false;
            // 
            // lblFlexSpending
            // 
            this.lblFlexSpending.AutoSize = true;
            this.lblFlexSpending.Location = new System.Drawing.Point(233, 204);
            this.lblFlexSpending.Name = "lblFlexSpending";
            this.lblFlexSpending.Size = new System.Drawing.Size(77, 13);
            this.lblFlexSpending.TabIndex = 11;
            this.lblFlexSpending.Text = "Flex Spending:";
            this.lblFlexSpending.Visible = false;
            // 
            // txtFlexSpending
            // 
            this.txtFlexSpending.Location = new System.Drawing.Point(236, 220);
            this.txtFlexSpending.Name = "txtFlexSpending";
            this.txtFlexSpending.Size = new System.Drawing.Size(122, 20);
            this.txtFlexSpending.TabIndex = 12;
            this.txtFlexSpending.Visible = false;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(142, 274);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(114, 23);
            this.btnCreate.TabIndex = 13;
            this.btnCreate.Text = "Create Objects";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // frmInheritance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 325);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtFlexSpending);
            this.Controls.Add(this.lblFlexSpending);
            this.Controls.Add(this.txtWorkshopHours);
            this.Controls.Add(this.lblWorkshopHours);
            this.Controls.Add(this.txtCommittees);
            this.Controls.Add(this.lblCommittees);
            this.Controls.Add(this.txtDevHours);
            this.Controls.Add(this.lblDevHours);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.grpEmployee);
            this.Name = "frmInheritance";
            this.Text = "Inheritance Example";
            this.grpEmployee.ResumeLayout(false);
            this.grpEmployee.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpEmployee;
        private System.Windows.Forms.RadioButton radFaculty;
        private System.Windows.Forms.RadioButton radStaff;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblDevHours;
        private System.Windows.Forms.TextBox txtDevHours;
        private System.Windows.Forms.Label lblCommittees;
        private System.Windows.Forms.TextBox txtCommittees;
        private System.Windows.Forms.Label lblWorkshopHours;
        private System.Windows.Forms.TextBox txtWorkshopHours;
        private System.Windows.Forms.Label lblFlexSpending;
        private System.Windows.Forms.TextBox txtFlexSpending;
        private System.Windows.Forms.Button btnCreate;
    }
}

