using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace OpenWeatherMap.Forms
{
    public partial class Settings : Form
    {
        private readonly MainForm Main;
        private readonly OpenWeather Weather;
        public Settings(MainForm main)
        {
            InitializeComponent();
            Weather = new OpenWeather();
            Main = main;
            City_textBox.Text = Properties.Settings.Default.City;
            TextColor_panel.BackColor = Properties.Settings.Default.ForeColor;
            MenuColor_panel.BackColor = Properties.Settings.Default.MenuColor;
            if (Properties.Settings.Default.FixedBackImage)
                FixedBackImage_radioButton.Checked = true;
            else
                RandomBackImage_radioButton.Checked = true;
        }

        /// <summary>
        /// Изящный хакерский способ для перемещения формы
        /// </summary>
        [DllImport("user32", CharSet = CharSet.Auto)]
        internal extern static bool PostMessage(IntPtr hWnd, uint Msg, uint WParam, uint LParam);

        [DllImport("user32", CharSet = CharSet.Auto)]
        internal extern static bool ReleaseCapture();

        const uint WM_SYSCOMMAND = 0x0112;
        const uint DOMOVE = 0xF012;

        public void Settings_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            PostMessage(this.Handle, WM_SYSCOMMAND, DOMOVE, 0);
        }
        // END

        private void Save_button_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void Save()
        {
            SaveChanges();
            Main.UpdateColors();
            Hide();
        }

        private void SaveChanges()
        {
            string url = $"http://api.openweathermap.org/data/2.5/weather?q={City_textBox.Text}&appid={Properties.Settings.Default.Key}";
            if (Weather.IsAvaible(url))
            {
                Properties.Settings.Default.City = City_textBox.Text;
                Main.Start();
                Main.UpdateInfo();
                Properties.Settings.Default.ForeColor = TextColor_panel.BackColor;
                Properties.Settings.Default.MenuColor = MenuColor_panel.BackColor;
                if (FixedBackImage_radioButton.Checked)
                    Properties.Settings.Default.FixedBackImage = true;
                else
                    Properties.Settings.Default.FixedBackImage = false;
                Properties.Settings.Default.Save();
            }
            else
            {
                City_textBox.Text = Properties.Settings.Default.City;
            }
        }

        private void ChangeImage_button_Click(object sender, EventArgs e)
        {
            Main.UpdateBackground();
        }

        private void Close_label_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void Minimize_label_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void Info_button_Click(object sender, EventArgs e)
        {
            // Default settings
            TextColor_panel.BackColor = Color.White;
            MenuColor_panel.BackColor = Color.Black;
        }

        private void TextColor_panel_Click(object sender, EventArgs e)
        {
            if (Text_ColorDialog.ShowDialog() != DialogResult.Cancel)
            {
                TextColor_panel.BackColor = Text_ColorDialog.Color;
            }
        }

        private void MenuColor_panel_Click(object sender, EventArgs e)
        {
            if (Text_ColorDialog.ShowDialog() != DialogResult.Cancel)
            {
                MenuColor_panel.BackColor = Text_ColorDialog.Color;
            }
        }

        private void City_textBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Save();
        }
    }
}
