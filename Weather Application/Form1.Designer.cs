namespace Weather_Application
{
    partial class Form1
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
            this.LblCity = new System.Windows.Forms.Label();
            this.TBCity = new System.Windows.Forms.TextBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.LblCondition = new System.Windows.Forms.Label();
            this.LblDetails = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LblSunrise = new System.Windows.Forms.Label();
            this.LblSunset = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblWindSpeed = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LblPressure = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PicIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // LblCity
            // 
            this.LblCity.AutoSize = true;
            this.LblCity.BackColor = System.Drawing.Color.Transparent;
            this.LblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCity.ForeColor = System.Drawing.Color.White;
            this.LblCity.Location = new System.Drawing.Point(201, 31);
            this.LblCity.Name = "LblCity";
            this.LblCity.Size = new System.Drawing.Size(59, 29);
            this.LblCity.TabIndex = 0;
            this.LblCity.Text = "City:";
            // 
            // TBCity
            // 
            this.TBCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBCity.Location = new System.Drawing.Point(266, 28);
            this.TBCity.Name = "TBCity";
            this.TBCity.Size = new System.Drawing.Size(214, 35);
            this.TBCity.TabIndex = 1;
            // 
            // BtnSearch
            // 
            this.BtnSearch.BackColor = System.Drawing.Color.Black;
            this.BtnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSearch.ForeColor = System.Drawing.Color.White;
            this.BtnSearch.Location = new System.Drawing.Point(496, 23);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(106, 45);
            this.BtnSearch.TabIndex = 2;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = false;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // LblCondition
            // 
            this.LblCondition.BackColor = System.Drawing.Color.Transparent;
            this.LblCondition.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCondition.ForeColor = System.Drawing.Color.Black;
            this.LblCondition.Location = new System.Drawing.Point(39, 88);
            this.LblCondition.Name = "LblCondition";
            this.LblCondition.Size = new System.Drawing.Size(398, 41);
            this.LblCondition.TabIndex = 3;
            this.LblCondition.Text = "Condition";
            this.LblCondition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblDetails
            // 
            this.LblDetails.BackColor = System.Drawing.Color.Transparent;
            this.LblDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDetails.ForeColor = System.Drawing.Color.Black;
            this.LblDetails.Location = new System.Drawing.Point(39, 141);
            this.LblDetails.Name = "LblDetails";
            this.LblDetails.Size = new System.Drawing.Size(398, 41);
            this.LblDetails.TabIndex = 4;
            this.LblDetails.Text = "Details";
            this.LblDetails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(26, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 39);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sunrise:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblSunrise
            // 
            this.LblSunrise.BackColor = System.Drawing.Color.Transparent;
            this.LblSunrise.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSunrise.ForeColor = System.Drawing.Color.Black;
            this.LblSunrise.Location = new System.Drawing.Point(259, 201);
            this.LblSunrise.Name = "LblSunrise";
            this.LblSunrise.Size = new System.Drawing.Size(200, 39);
            this.LblSunrise.TabIndex = 6;
            this.LblSunrise.Text = "N/A";
            this.LblSunrise.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblSunset
            // 
            this.LblSunset.BackColor = System.Drawing.Color.Transparent;
            this.LblSunset.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSunset.ForeColor = System.Drawing.Color.Black;
            this.LblSunset.Location = new System.Drawing.Point(259, 256);
            this.LblSunset.Name = "LblSunset";
            this.LblSunset.Size = new System.Drawing.Size(200, 39);
            this.LblSunset.TabIndex = 8;
            this.LblSunset.Text = "N/A";
            this.LblSunset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(26, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 39);
            this.label3.TabIndex = 7;
            this.label3.Text = "Sunset:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblWindSpeed
            // 
            this.LblWindSpeed.BackColor = System.Drawing.Color.Transparent;
            this.LblWindSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblWindSpeed.ForeColor = System.Drawing.Color.Black;
            this.LblWindSpeed.Location = new System.Drawing.Point(259, 313);
            this.LblWindSpeed.Name = "LblWindSpeed";
            this.LblWindSpeed.Size = new System.Drawing.Size(200, 39);
            this.LblWindSpeed.TabIndex = 10;
            this.LblWindSpeed.Text = "N/A";
            this.LblWindSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(25, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(228, 39);
            this.label4.TabIndex = 9;
            this.label4.Text = "Wind Speed:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblPressure
            // 
            this.LblPressure.BackColor = System.Drawing.Color.Transparent;
            this.LblPressure.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPressure.ForeColor = System.Drawing.Color.Black;
            this.LblPressure.Location = new System.Drawing.Point(259, 368);
            this.LblPressure.Name = "LblPressure";
            this.LblPressure.Size = new System.Drawing.Size(200, 39);
            this.LblPressure.TabIndex = 12;
            this.LblPressure.Text = "N/A";
            this.LblPressure.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(26, 368);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(227, 39);
            this.label6.TabIndex = 11;
            this.label6.Text = "Pressure:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PicIcon
            // 
            this.PicIcon.BackColor = System.Drawing.Color.Transparent;
            this.PicIcon.Location = new System.Drawing.Point(480, 88);
            this.PicIcon.Name = "PicIcon";
            this.PicIcon.Size = new System.Drawing.Size(289, 319);
            this.PicIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicIcon.TabIndex = 13;
            this.PicIcon.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Weather_Application.Properties.Resources.pexels_pixabay_33834;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PicIcon);
            this.Controls.Add(this.LblPressure);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LblWindSpeed);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LblSunset);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblSunrise);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblDetails);
            this.Controls.Add(this.LblCondition);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.TBCity);
            this.Controls.Add(this.LblCity);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Weather Application";
            ((System.ComponentModel.ISupportInitialize)(this.PicIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblCity;
        private System.Windows.Forms.TextBox TBCity;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Label LblCondition;
        private System.Windows.Forms.Label LblDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblSunrise;
        private System.Windows.Forms.Label LblSunset;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblWindSpeed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblPressure;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox PicIcon;
    }
}

