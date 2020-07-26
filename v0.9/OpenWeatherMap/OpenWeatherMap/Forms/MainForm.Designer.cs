namespace OpenWeatherMap
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TempNow_label = new System.Windows.Forms.Label();
            this.Location_label = new System.Windows.Forms.Label();
            this.DayOfWeek_label = new System.Windows.Forms.Label();
            this.MonthAndYear_label = new System.Windows.Forms.Label();
            this.WeatherType_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.List_UserControl = new OpenWeatherMap.MenuList_UserControl();
            this.SuspendLayout();
            // 
            // TempNow_label
            // 
            this.TempNow_label.AutoSize = true;
            this.TempNow_label.BackColor = System.Drawing.Color.Transparent;
            this.TempNow_label.Font = new System.Drawing.Font("Bookman Old Style", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TempNow_label.ForeColor = System.Drawing.Color.White;
            this.TempNow_label.Location = new System.Drawing.Point(6, 164);
            this.TempNow_label.Name = "TempNow_label";
            this.TempNow_label.Size = new System.Drawing.Size(123, 58);
            this.TempNow_label.TabIndex = 1;
            this.TempNow_label.Text = "N/A";
            // 
            // Location_label
            // 
            this.Location_label.BackColor = System.Drawing.Color.Transparent;
            this.Location_label.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Location_label.ForeColor = System.Drawing.Color.White;
            this.Location_label.Location = new System.Drawing.Point(13, 249);
            this.Location_label.Name = "Location_label";
            this.Location_label.Size = new System.Drawing.Size(168, 38);
            this.Location_label.TabIndex = 2;
            this.Location_label.Text = "N/A";
            // 
            // DayOfWeek_label
            // 
            this.DayOfWeek_label.AutoSize = true;
            this.DayOfWeek_label.BackColor = System.Drawing.Color.Transparent;
            this.DayOfWeek_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DayOfWeek_label.ForeColor = System.Drawing.Color.White;
            this.DayOfWeek_label.Location = new System.Drawing.Point(13, 9);
            this.DayOfWeek_label.Name = "DayOfWeek_label";
            this.DayOfWeek_label.Size = new System.Drawing.Size(26, 15);
            this.DayOfWeek_label.TabIndex = 3;
            this.DayOfWeek_label.Text = "N/A";
            // 
            // MonthAndYear_label
            // 
            this.MonthAndYear_label.AutoSize = true;
            this.MonthAndYear_label.BackColor = System.Drawing.Color.Transparent;
            this.MonthAndYear_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MonthAndYear_label.ForeColor = System.Drawing.Color.White;
            this.MonthAndYear_label.Location = new System.Drawing.Point(13, 24);
            this.MonthAndYear_label.Name = "MonthAndYear_label";
            this.MonthAndYear_label.Size = new System.Drawing.Size(26, 15);
            this.MonthAndYear_label.TabIndex = 4;
            this.MonthAndYear_label.Text = "N/A";
            // 
            // WeatherType_label
            // 
            this.WeatherType_label.BackColor = System.Drawing.Color.Transparent;
            this.WeatherType_label.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WeatherType_label.ForeColor = System.Drawing.Color.White;
            this.WeatherType_label.Location = new System.Drawing.Point(11, 51);
            this.WeatherType_label.Name = "WeatherType_label";
            this.WeatherType_label.Size = new System.Drawing.Size(191, 53);
            this.WeatherType_label.TabIndex = 5;
            this.WeatherType_label.Text = "N/A";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 36);
            this.label1.TabIndex = 7;
            this.label1.Text = "N/A";
            // 
            // List_UserControl
            // 
            this.List_UserControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.List_UserControl.Days = null;
            this.List_UserControl.Location = new System.Drawing.Point(220, 0);
            this.List_UserControl.Main = null;
            this.List_UserControl.Margin = new System.Windows.Forms.Padding(0);
            this.List_UserControl.Name = "List_UserControl";
            this.List_UserControl.Size = new System.Drawing.Size(180, 300);
            this.List_UserControl.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.List_UserControl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WeatherType_label);
            this.Controls.Add(this.MonthAndYear_label);
            this.Controls.Add(this.DayOfWeek_label);
            this.Controls.Add(this.Location_label);
            this.Controls.Add(this.TempNow_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(956, 10);
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label TempNow_label;
        private System.Windows.Forms.Label Location_label;
        private System.Windows.Forms.Label DayOfWeek_label;
        private System.Windows.Forms.Label MonthAndYear_label;
        private System.Windows.Forms.Label WeatherType_label;
        private System.Windows.Forms.Label label1;
        private MenuList_UserControl List_UserControl;
    }
}

