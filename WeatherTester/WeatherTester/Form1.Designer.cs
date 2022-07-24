namespace WeatherTester
{
    partial class frmWeatherTester
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
            this.btnVolumnRainfall = new System.Windows.Forms.Button();
            this.btnHumidity = new System.Windows.Forms.Button();
            this.btnMixingRatio = new System.Windows.Forms.Button();
            this.btnWindSpeed = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnTemp = new System.Windows.Forms.Button();
            this.btnHeatIndex = new System.Windows.Forms.Button();
            this.btnWindChill = new System.Windows.Forms.Button();
            this.btnDew = new System.Windows.Forms.Button();
            this.btnVirtualTemp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVolumnRainfall
            // 
            this.btnVolumnRainfall.Location = new System.Drawing.Point(176, 192);
            this.btnVolumnRainfall.Name = "btnVolumnRainfall";
            this.btnVolumnRainfall.Size = new System.Drawing.Size(75, 40);
            this.btnVolumnRainfall.TabIndex = 0;
            this.btnVolumnRainfall.Text = "Volumn of Rainfall";
            this.btnVolumnRainfall.UseVisualStyleBackColor = true;
            this.btnVolumnRainfall.Click += new System.EventHandler(this.btnVolumnRainfall_Click);
            // 
            // btnHumidity
            // 
            this.btnHumidity.Location = new System.Drawing.Point(176, 96);
            this.btnHumidity.Name = "btnHumidity";
            this.btnHumidity.Size = new System.Drawing.Size(75, 23);
            this.btnHumidity.TabIndex = 1;
            this.btnHumidity.Text = "Humidity";
            this.btnHumidity.UseVisualStyleBackColor = true;
            this.btnHumidity.Click += new System.EventHandler(this.btnHumidity_Click);
            // 
            // btnMixingRatio
            // 
            this.btnMixingRatio.Location = new System.Drawing.Point(72, 96);
            this.btnMixingRatio.Name = "btnMixingRatio";
            this.btnMixingRatio.Size = new System.Drawing.Size(75, 23);
            this.btnMixingRatio.TabIndex = 2;
            this.btnMixingRatio.Text = "Mixing Ratio";
            this.btnMixingRatio.UseVisualStyleBackColor = true;
            this.btnMixingRatio.Click += new System.EventHandler(this.btnMixingRatio_Click);
            // 
            // btnWindSpeed
            // 
            this.btnWindSpeed.Location = new System.Drawing.Point(280, 96);
            this.btnWindSpeed.Name = "btnWindSpeed";
            this.btnWindSpeed.Size = new System.Drawing.Size(75, 23);
            this.btnWindSpeed.TabIndex = 3;
            this.btnWindSpeed.Text = "Wind Speed";
            this.btnWindSpeed.UseVisualStyleBackColor = true;
            this.btnWindSpeed.Click += new System.EventHandler(this.btnWindSpeed_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(128, 40);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(165, 25);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Weather Library";
            // 
            // btnTemp
            // 
            this.btnTemp.Location = new System.Drawing.Point(72, 192);
            this.btnTemp.Name = "btnTemp";
            this.btnTemp.Size = new System.Drawing.Size(75, 40);
            this.btnTemp.TabIndex = 5;
            this.btnTemp.Text = "Temperature Conversion";
            this.btnTemp.UseVisualStyleBackColor = true;
            this.btnTemp.Click += new System.EventHandler(this.btnTemp_Click);
            // 
            // btnHeatIndex
            // 
            this.btnHeatIndex.Location = new System.Drawing.Point(280, 144);
            this.btnHeatIndex.Name = "btnHeatIndex";
            this.btnHeatIndex.Size = new System.Drawing.Size(75, 23);
            this.btnHeatIndex.TabIndex = 6;
            this.btnHeatIndex.Text = "Heat Index";
            this.btnHeatIndex.UseVisualStyleBackColor = true;
            this.btnHeatIndex.Click += new System.EventHandler(this.btnHeatIndex_Click);
            // 
            // btnWindChill
            // 
            this.btnWindChill.Location = new System.Drawing.Point(72, 144);
            this.btnWindChill.Name = "btnWindChill";
            this.btnWindChill.Size = new System.Drawing.Size(75, 23);
            this.btnWindChill.TabIndex = 7;
            this.btnWindChill.Text = "Wind Chill";
            this.btnWindChill.UseVisualStyleBackColor = true;
            this.btnWindChill.Click += new System.EventHandler(this.btnWindChill_Click);
            // 
            // btnDew
            // 
            this.btnDew.Location = new System.Drawing.Point(176, 144);
            this.btnDew.Name = "btnDew";
            this.btnDew.Size = new System.Drawing.Size(75, 23);
            this.btnDew.TabIndex = 8;
            this.btnDew.Text = "Dew Point";
            this.btnDew.UseVisualStyleBackColor = true;
            this.btnDew.Click += new System.EventHandler(this.btnDew_Click);
            // 
            // btnVirtualTemp
            // 
            this.btnVirtualTemp.Location = new System.Drawing.Point(280, 192);
            this.btnVirtualTemp.Name = "btnVirtualTemp";
            this.btnVirtualTemp.Size = new System.Drawing.Size(75, 40);
            this.btnVirtualTemp.TabIndex = 9;
            this.btnVirtualTemp.Text = "Virtual Temperature";
            this.btnVirtualTemp.UseVisualStyleBackColor = true;
            this.btnVirtualTemp.Click += new System.EventHandler(this.btnVirtualTemp_Click);
            // 
            // frmWeatherTester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 287);
            this.Controls.Add(this.btnVirtualTemp);
            this.Controls.Add(this.btnDew);
            this.Controls.Add(this.btnWindChill);
            this.Controls.Add(this.btnHeatIndex);
            this.Controls.Add(this.btnTemp);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnWindSpeed);
            this.Controls.Add(this.btnMixingRatio);
            this.Controls.Add(this.btnHumidity);
            this.Controls.Add(this.btnVolumnRainfall);
            this.Name = "frmWeatherTester";
            this.Text = "Weather Calculation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolumnRainfall;
        private System.Windows.Forms.Button btnHumidity;
        private System.Windows.Forms.Button btnMixingRatio;
        private System.Windows.Forms.Button btnWindSpeed;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnTemp;
        private System.Windows.Forms.Button btnHeatIndex;
        private System.Windows.Forms.Button btnWindChill;
        private System.Windows.Forms.Button btnDew;
        private System.Windows.Forms.Button btnVirtualTemp;
    }
}

