using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace OpenWeatherMap.Forms
{
    public partial class Settings : Form
    {
        MainForm Main;
        readonly OpenWeather Weather;
        public Settings(MainForm main)
        {
            InitializeComponent();
            Weather = new OpenWeather();
            Main = main;
            City_textBox.Text = Properties.Settings.Default.City;
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
            string url = $"http://api.openweathermap.org/data/2.5/weather?q={City_textBox.Text}&appid={Properties.Settings.Default.Key}";
            if (Weather.IsAvaible(url))
            {
                Properties.Settings.Default.City = City_textBox.Text;
                Main.Start();
                Main.UpdateInfo();
                Properties.Settings.Default.ForeColor = GetColor();
                Properties.Settings.Default.Save();
                Main.UpdateForeColor();
                Hide();
            }
            else
            {
                City_textBox.Text = Properties.Settings.Default.City;
            }
        }

        private Color GetColor()
        {
            switch (TextColor_comboBox.Text)
            {
                case "Black":
                    return Color.Black;
                case "White":
                    return Color.White;
            }
            return Color.White;
        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
