namespace OpenWeatherMap.Forms
{
    partial class Settings
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
            this.City_label = new System.Windows.Forms.Label();
            this.City_textBox = new System.Windows.Forms.TextBox();
            this.Save_button = new System.Windows.Forms.Button();
            this.TextColor_label = new System.Windows.Forms.Label();
            this.RandomBackImage_radioButton = new System.Windows.Forms.RadioButton();
            this.FixedBackImage_radioButton = new System.Windows.Forms.RadioButton();
            this.BackImage_label = new System.Windows.Forms.Label();
            this.RandomBack_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Minimize_label = new System.Windows.Forms.Label();
            this.Close_label = new System.Windows.Forms.Label();
            this.Default_button = new System.Windows.Forms.Button();
            this.MenuColor_label = new System.Windows.Forms.Label();
            this.Text_ColorDialog = new System.Windows.Forms.ColorDialog();
            this.TextColor_panel = new System.Windows.Forms.Panel();
            this.MenuColor_panel = new System.Windows.Forms.Panel();
            this.Menu_ColorDialog = new System.Windows.Forms.ColorDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // City_label
            // 
            this.City_label.AutoSize = true;
            this.City_label.ForeColor = System.Drawing.Color.White;
            this.City_label.Location = new System.Drawing.Point(10, 32);
            this.City_label.Name = "City_label";
            this.City_label.Size = new System.Drawing.Size(27, 13);
            this.City_label.TabIndex = 0;
            this.City_label.Text = "City:";
            // 
            // City_textBox
            // 
            this.City_textBox.BackColor = System.Drawing.Color.White;
            this.City_textBox.Location = new System.Drawing.Point(43, 29);
            this.City_textBox.Name = "City_textBox";
            this.City_textBox.Size = new System.Drawing.Size(141, 20);
            this.City_textBox.TabIndex = 1;
            this.City_textBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.City_textBox_KeyUp);
            // 
            // Save_button
            // 
            this.Save_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(10)))), ((int)(((byte)(255)))));
            this.Save_button.FlatAppearance.BorderSize = 0;
            this.Save_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Save_button.ForeColor = System.Drawing.Color.White;
            this.Save_button.Location = new System.Drawing.Point(12, 222);
            this.Save_button.Margin = new System.Windows.Forms.Padding(3, 6, 6, 6);
            this.Save_button.Name = "Save_button";
            this.Save_button.Size = new System.Drawing.Size(78, 25);
            this.Save_button.TabIndex = 2;
            this.Save_button.Text = "Save";
            this.Save_button.UseVisualStyleBackColor = false;
            this.Save_button.Click += new System.EventHandler(this.Save_button_Click);
            // 
            // TextColor_label
            // 
            this.TextColor_label.AutoSize = true;
            this.TextColor_label.ForeColor = System.Drawing.Color.White;
            this.TextColor_label.Location = new System.Drawing.Point(10, 58);
            this.TextColor_label.Name = "TextColor_label";
            this.TextColor_label.Size = new System.Drawing.Size(58, 13);
            this.TextColor_label.TabIndex = 5;
            this.TextColor_label.Text = "Text Color:";
            // 
            // RandomBackImage_radioButton
            // 
            this.RandomBackImage_radioButton.AutoSize = true;
            this.RandomBackImage_radioButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
            this.RandomBackImage_radioButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RandomBackImage_radioButton.ForeColor = System.Drawing.Color.White;
            this.RandomBackImage_radioButton.Location = new System.Drawing.Point(26, 136);
            this.RandomBackImage_radioButton.Name = "RandomBackImage_radioButton";
            this.RandomBackImage_radioButton.Size = new System.Drawing.Size(64, 17);
            this.RandomBackImage_radioButton.TabIndex = 7;
            this.RandomBackImage_radioButton.TabStop = true;
            this.RandomBackImage_radioButton.Text = "Random";
            this.RandomBackImage_radioButton.UseVisualStyleBackColor = false;
            // 
            // FixedBackImage_radioButton
            // 
            this.FixedBackImage_radioButton.AutoSize = true;
            this.FixedBackImage_radioButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
            this.FixedBackImage_radioButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FixedBackImage_radioButton.ForeColor = System.Drawing.Color.White;
            this.FixedBackImage_radioButton.Location = new System.Drawing.Point(26, 159);
            this.FixedBackImage_radioButton.Name = "FixedBackImage_radioButton";
            this.FixedBackImage_radioButton.Size = new System.Drawing.Size(49, 17);
            this.FixedBackImage_radioButton.TabIndex = 8;
            this.FixedBackImage_radioButton.TabStop = true;
            this.FixedBackImage_radioButton.Text = "Fixed";
            this.FixedBackImage_radioButton.UseVisualStyleBackColor = false;
            // 
            // BackImage_label
            // 
            this.BackImage_label.AutoSize = true;
            this.BackImage_label.ForeColor = System.Drawing.Color.White;
            this.BackImage_label.Location = new System.Drawing.Point(9, 114);
            this.BackImage_label.Name = "BackImage_label";
            this.BackImage_label.Size = new System.Drawing.Size(99, 13);
            this.BackImage_label.TabIndex = 9;
            this.BackImage_label.Text = "Background image:";
            // 
            // RandomBack_button
            // 
            this.RandomBack_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(51)))), ((int)(((byte)(255)))));
            this.RandomBack_button.FlatAppearance.BorderSize = 0;
            this.RandomBack_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RandomBack_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.RandomBack_button.ForeColor = System.Drawing.Color.White;
            this.RandomBack_button.Location = new System.Drawing.Point(12, 185);
            this.RandomBack_button.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.RandomBack_button.Name = "RandomBack_button";
            this.RandomBack_button.Size = new System.Drawing.Size(172, 25);
            this.RandomBack_button.TabIndex = 10;
            this.RandomBack_button.Text = "Change image";
            this.RandomBack_button.UseVisualStyleBackColor = false;
            this.RandomBack_button.Click += new System.EventHandler(this.ChangeImage_button_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(34)))), ((int)(((byte)(63)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Minimize_label);
            this.panel1.Controls.Add(this.Close_label);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 20);
            this.panel1.TabIndex = 11;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Settings_MouseDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(75, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Settings";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Settings_MouseDown);
            // 
            // Minimize_label
            // 
            this.Minimize_label.AutoSize = true;
            this.Minimize_label.ForeColor = System.Drawing.Color.White;
            this.Minimize_label.Location = new System.Drawing.Point(158, 2);
            this.Minimize_label.Name = "Minimize_label";
            this.Minimize_label.Size = new System.Drawing.Size(19, 13);
            this.Minimize_label.TabIndex = 1;
            this.Minimize_label.Text = "__";
            this.Minimize_label.Click += new System.EventHandler(this.Minimize_label_Click);
            // 
            // Close_label
            // 
            this.Close_label.AutoSize = true;
            this.Close_label.ForeColor = System.Drawing.Color.White;
            this.Close_label.Location = new System.Drawing.Point(183, 3);
            this.Close_label.Name = "Close_label";
            this.Close_label.Size = new System.Drawing.Size(14, 13);
            this.Close_label.TabIndex = 0;
            this.Close_label.Text = "X";
            this.Close_label.Click += new System.EventHandler(this.Close_label_Click);
            // 
            // Default_button
            // 
            this.Default_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(51)))), ((int)(((byte)(255)))));
            this.Default_button.FlatAppearance.BorderSize = 0;
            this.Default_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Default_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Default_button.ForeColor = System.Drawing.Color.White;
            this.Default_button.Location = new System.Drawing.Point(106, 222);
            this.Default_button.Margin = new System.Windows.Forms.Padding(3, 6, 6, 6);
            this.Default_button.Name = "Default_button";
            this.Default_button.Size = new System.Drawing.Size(78, 25);
            this.Default_button.TabIndex = 12;
            this.Default_button.Text = "Default";
            this.Default_button.UseVisualStyleBackColor = false;
            this.Default_button.Click += new System.EventHandler(this.Info_button_Click);
            // 
            // MenuColor_label
            // 
            this.MenuColor_label.AutoSize = true;
            this.MenuColor_label.ForeColor = System.Drawing.Color.White;
            this.MenuColor_label.Location = new System.Drawing.Point(10, 85);
            this.MenuColor_label.Name = "MenuColor_label";
            this.MenuColor_label.Size = new System.Drawing.Size(64, 13);
            this.MenuColor_label.TabIndex = 13;
            this.MenuColor_label.Text = "Menu Color:";
            // 
            // TextColor_panel
            // 
            this.TextColor_panel.BackColor = System.Drawing.Color.White;
            this.TextColor_panel.Location = new System.Drawing.Point(80, 55);
            this.TextColor_panel.Name = "TextColor_panel";
            this.TextColor_panel.Size = new System.Drawing.Size(18, 18);
            this.TextColor_panel.TabIndex = 15;
            this.TextColor_panel.Click += new System.EventHandler(this.TextColor_panel_Click);
            // 
            // MenuColor_panel
            // 
            this.MenuColor_panel.BackColor = System.Drawing.Color.White;
            this.MenuColor_panel.Location = new System.Drawing.Point(80, 82);
            this.MenuColor_panel.Name = "MenuColor_panel";
            this.MenuColor_panel.Size = new System.Drawing.Size(18, 18);
            this.MenuColor_panel.TabIndex = 16;
            this.MenuColor_panel.Click += new System.EventHandler(this.MenuColor_panel_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(199, 259);
            this.Controls.Add(this.MenuColor_panel);
            this.Controls.Add(this.TextColor_panel);
            this.Controls.Add(this.MenuColor_label);
            this.Controls.Add(this.Default_button);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.RandomBack_button);
            this.Controls.Add(this.BackImage_label);
            this.Controls.Add(this.FixedBackImage_radioButton);
            this.Controls.Add(this.RandomBackImage_radioButton);
            this.Controls.Add(this.TextColor_label);
            this.Controls.Add(this.Save_button);
            this.Controls.Add(this.City_textBox);
            this.Controls.Add(this.City_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Settings_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label City_label;
        private System.Windows.Forms.TextBox City_textBox;
        private System.Windows.Forms.Button Save_button;
        private System.Windows.Forms.Label TextColor_label;
        private System.Windows.Forms.RadioButton RandomBackImage_radioButton;
        private System.Windows.Forms.RadioButton FixedBackImage_radioButton;
        private System.Windows.Forms.Label BackImage_label;
        private System.Windows.Forms.Button RandomBack_button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Minimize_label;
        private System.Windows.Forms.Label Close_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Default_button;
        private System.Windows.Forms.Label MenuColor_label;
        private System.Windows.Forms.ColorDialog Text_ColorDialog;
        private System.Windows.Forms.Panel TextColor_panel;
        private System.Windows.Forms.Panel MenuColor_panel;
        private System.Windows.Forms.ColorDialog Menu_ColorDialog;
    }
}