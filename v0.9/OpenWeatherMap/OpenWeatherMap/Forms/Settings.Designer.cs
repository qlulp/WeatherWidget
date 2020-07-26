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
            this.Exit_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TextColor_comboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // City_label
            // 
            this.City_label.AutoSize = true;
            this.City_label.Location = new System.Drawing.Point(9, 15);
            this.City_label.Name = "City_label";
            this.City_label.Size = new System.Drawing.Size(27, 13);
            this.City_label.TabIndex = 0;
            this.City_label.Text = "City:";
            // 
            // City_textBox
            // 
            this.City_textBox.BackColor = System.Drawing.Color.CornflowerBlue;
            this.City_textBox.Location = new System.Drawing.Point(42, 12);
            this.City_textBox.Name = "City_textBox";
            this.City_textBox.Size = new System.Drawing.Size(154, 20);
            this.City_textBox.TabIndex = 1;
            // 
            // Save_button
            // 
            this.Save_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Save_button.ForeColor = System.Drawing.Color.Black;
            this.Save_button.Location = new System.Drawing.Point(12, 82);
            this.Save_button.Name = "Save_button";
            this.Save_button.Size = new System.Drawing.Size(61, 25);
            this.Save_button.TabIndex = 2;
            this.Save_button.Text = "Save";
            this.Save_button.UseVisualStyleBackColor = true;
            this.Save_button.Click += new System.EventHandler(this.Save_button_Click);
            // 
            // Exit_button
            // 
            this.Exit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Exit_button.Location = new System.Drawing.Point(135, 82);
            this.Exit_button.Name = "Exit_button";
            this.Exit_button.Size = new System.Drawing.Size(61, 25);
            this.Exit_button.TabIndex = 3;
            this.Exit_button.Text = "Close";
            this.Exit_button.UseVisualStyleBackColor = true;
            this.Exit_button.Click += new System.EventHandler(this.Exit_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Text Color";
            // 
            // TextColor_comboBox
            // 
            this.TextColor_comboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TextColor_comboBox.ForeColor = System.Drawing.Color.Black;
            this.TextColor_comboBox.FormattingEnabled = true;
            this.TextColor_comboBox.Items.AddRange(new object[] {
            "Black",
            "White"});
            this.TextColor_comboBox.Location = new System.Drawing.Point(70, 49);
            this.TextColor_comboBox.Name = "TextColor_comboBox";
            this.TextColor_comboBox.Size = new System.Drawing.Size(126, 21);
            this.TextColor_comboBox.TabIndex = 6;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(218, 119);
            this.Controls.Add(this.TextColor_comboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Exit_button);
            this.Controls.Add(this.Save_button);
            this.Controls.Add(this.City_textBox);
            this.Controls.Add(this.City_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Settings";
            this.Text = "Settings";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Settings_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label City_label;
        private System.Windows.Forms.TextBox City_textBox;
        private System.Windows.Forms.Button Save_button;
        private System.Windows.Forms.Button Exit_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox TextColor_comboBox;
    }
}