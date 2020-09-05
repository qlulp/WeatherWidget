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
            this.MaxTemp_label = new System.Windows.Forms.Label();
            this.Location_label = new System.Windows.Forms.Label();
            this.DayOfWeek_label = new System.Windows.Forms.Label();
            this.MonthAndYear_label = new System.Windows.Forms.Label();
            this.WeatherType_label = new System.Windows.Forms.Label();
            this.MinTemp_label = new System.Windows.Forms.Label();
            this.Menu_UserControl = new OpenWeatherMap.MenuList_UserControl();
            this.SuspendLayout();
            // 
            // MaxTemp_label
            // 
            this.MaxTemp_label.AutoSize = true;
            this.MaxTemp_label.BackColor = System.Drawing.Color.Transparent;
            this.MaxTemp_label.Font = new System.Drawing.Font("Bookman Old Style", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaxTemp_label.ForeColor = System.Drawing.Color.White;
            this.MaxTemp_label.Location = new System.Drawing.Point(6, 188);
            this.MaxTemp_label.Name = "MaxTemp_label";
            this.MaxTemp_label.Size = new System.Drawing.Size(128, 58);
            this.MaxTemp_label.TabIndex = 1;
            this.MaxTemp_label.Text = "N/D";
            // 
            // Location_label
            // 
            this.Location_label.BackColor = System.Drawing.Color.Transparent;
            this.Location_label.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Location_label.ForeColor = System.Drawing.Color.White;
            this.Location_label.Location = new System.Drawing.Point(13, 273);
            this.Location_label.Name = "Location_label";
            this.Location_label.Size = new System.Drawing.Size(168, 16);
            this.Location_label.TabIndex = 2;
            this.Location_label.Text = "N/D";
            // 
            // DayOfWeek_label
            // 
            this.DayOfWeek_label.AutoSize = true;
            this.DayOfWeek_label.BackColor = System.Drawing.Color.Transparent;
            this.DayOfWeek_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DayOfWeek_label.ForeColor = System.Drawing.Color.White;
            this.DayOfWeek_label.Location = new System.Drawing.Point(13, 9);
            this.DayOfWeek_label.Name = "DayOfWeek_label";
            this.DayOfWeek_label.Size = new System.Drawing.Size(28, 15);
            this.DayOfWeek_label.TabIndex = 3;
            this.DayOfWeek_label.Text = "N/D";
            // 
            // MonthAndYear_label
            // 
            this.MonthAndYear_label.AutoSize = true;
            this.MonthAndYear_label.BackColor = System.Drawing.Color.Transparent;
            this.MonthAndYear_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MonthAndYear_label.ForeColor = System.Drawing.Color.White;
            this.MonthAndYear_label.Location = new System.Drawing.Point(13, 24);
            this.MonthAndYear_label.Name = "MonthAndYear_label";
            this.MonthAndYear_label.Size = new System.Drawing.Size(28, 15);
            this.MonthAndYear_label.TabIndex = 4;
            this.MonthAndYear_label.Text = "N/D";
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
            this.WeatherType_label.Text = "N/D";
            // 
            // MinTemp_label
            // 
            this.MinTemp_label.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.MinTemp_label.AutoSize = true;
            this.MinTemp_label.BackColor = System.Drawing.Color.Transparent;
            this.MinTemp_label.Font = new System.Drawing.Font("Bookman Old Style", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinTemp_label.ForeColor = System.Drawing.Color.White;
            this.MinTemp_label.Location = new System.Drawing.Point(10, 237);
            this.MinTemp_label.Name = "MinTemp_label";
            this.MinTemp_label.Size = new System.Drawing.Size(76, 36);
            this.MinTemp_label.TabIndex = 7;
            this.MinTemp_label.Text = "N/D";
            // 
            // Menu_UserControl
            // 
            this.Menu_UserControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Menu_UserControl.Days = null;
            this.Menu_UserControl.Location = new System.Drawing.Point(220, 0);
            this.Menu_UserControl.Main = null;
            this.Menu_UserControl.Margin = new System.Windows.Forms.Padding(0);
            this.Menu_UserControl.Name = "Menu_UserControl";
            this.Menu_UserControl.Size = new System.Drawing.Size(180, 300);
            this.Menu_UserControl.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.Menu_UserControl);
            this.Controls.Add(this.MinTemp_label);
            this.Controls.Add(this.WeatherType_label);
            this.Controls.Add(this.MonthAndYear_label);
            this.Controls.Add(this.DayOfWeek_label);
            this.Controls.Add(this.Location_label);
            this.Controls.Add(this.MaxTemp_label);
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
        private System.Windows.Forms.Label MaxTemp_label;
        private System.Windows.Forms.Label Location_label;
        private System.Windows.Forms.Label DayOfWeek_label;
        private System.Windows.Forms.Label MonthAndYear_label;
        private System.Windows.Forms.Label WeatherType_label;
        private System.Windows.Forms.Label MinTemp_label;
        private MenuList_UserControl Menu_UserControl;
    }
}

