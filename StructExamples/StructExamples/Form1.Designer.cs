namespace StructExamples
{
    partial class frmStructExamples
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
            this.txtBreed = new System.Windows.Forms.TextBox();
            this.txtHairType = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.lstDog = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtBreed
            // 
            this.txtBreed.Location = new System.Drawing.Point(51, 29);
            this.txtBreed.Name = "txtBreed";
            this.txtBreed.Size = new System.Drawing.Size(100, 20);
            this.txtBreed.TabIndex = 0;
            // 
            // txtHairType
            // 
            this.txtHairType.Location = new System.Drawing.Point(51, 68);
            this.txtHairType.Name = "txtHairType";
            this.txtHairType.Size = new System.Drawing.Size(100, 20);
            this.txtHairType.TabIndex = 1;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(51, 104);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 20);
            this.txtAge.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(51, 144);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(255, 144);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(194, 23);
            this.btnDisplay.TabIndex = 4;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // lstDog
            // 
            this.lstDog.FormattingEnabled = true;
            this.lstDog.Location = new System.Drawing.Point(255, 29);
            this.lstDog.Name = "lstDog";
            this.lstDog.Size = new System.Drawing.Size(194, 95);
            this.lstDog.TabIndex = 5;
            // 
            // frmStructExamples
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 220);
            this.Controls.Add(this.lstDog);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtHairType);
            this.Controls.Add(this.txtBreed);
            this.Name = "frmStructExamples";
            this.Text = "Structure Examples";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBreed;
        private System.Windows.Forms.TextBox txtHairType;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.ListBox lstDog;
    }
}

