using OpenWeatherMap.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace OpenWeatherMap
{
    public partial class MainForm : Form
    {
        private List<Day> Days;
        private OpenWeather weather;
        public Settings settings;


        public MainForm()
        {
            InitializeComponent();
            Start();
            UpdateInfo();
            UpdateBackground();
            UpdateForeColor();
            settings = new Settings(this);
        }

        public void UpdateBackground()
        {
            BackgroundImage = Image.FromFile(GetRandomPicPath());
        }

        public void UpdateForeColor()
        {
            foreach (Control control in this.Controls)
                control.ForeColor = Properties.Settings.Default.ForeColor;
            List_UserControl.UpdateForeColor();
        }

        private string GetRandomPicPath()
        {
            Random rand = new Random();
            string[] files = Directory.GetFiles(".\\Images", "*.jpg");
            return files[rand.Next(0, files.Length)];
        }

        public void Start()
        {
            string
                city = Properties.Settings.Default.City,
                Key = Properties.Settings.Default.Key,
                url = $"http://api.openweathermap.org/data/2.5/forecast?q={city}&lang=en-us&units=metric&appid={Key}";

            weather = new OpenWeather(url);
            Days = new List<Day>();
            Days = weather.GetList();
        }

        public void UpdateInfo()
        {
            if ((int)Days[0].GetMaxTemp() != (int)Days[0].GetMinTemp())
            {
                TempNow_label.Text = $"{(int)Days[0].GetMaxTemp()}°C";
                label1.Text = $"{(int)Days[0].GetMinTemp()}°C";
            }
            else
            {
                TempNow_label.Text = $"{(int)Days[0].GetMaxTemp()}°C";
                label1.Text = "";
            }
            WeatherType_label.Text = Days[0].GetDescription();
            Location_label.Text = $"{Days[0].City.name}, {Days[0].City.country}";
            DayOfWeek_label.Text = Days[0].Date.DayOfWeek.ToString();
            MonthAndYear_label.Text = Days[0].Date.ToShortDateString();

            List_UserControl.Main = this;
            List_UserControl.Days = Days;
            List_UserControl.AddItmes();
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

        public void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            PostMessage(this.Handle, WM_SYSCOMMAND, DOMOVE, 0);
        }
        // End

        private void Close_label_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            SendToBack();
        }
    }
}
