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
        private const string ImagesPath = ".\\Images";
        public Settings settings;


        public MainForm()
        {
            InitializeComponent();
            SetLocation();
            Start();
            UpdateInfo();
            if (!Properties.Settings.Default.FixedBackImage)
                UpdateBackground();
            UpdateColors();
            settings = new Settings(this);
        }

        public void SetLocation()
        {
            this.Location = Properties.Settings.Default.LastLocation;
        }

        public void UpdateBackground()
        {
            if (GetRandomPicPath() != null)
                BackgroundImage = Image.FromFile(GetRandomPicPath());
        }

        public void UpdateColors()
        {
            foreach (Control control in this.Controls)
                control.ForeColor = Properties.Settings.Default.ForeColor;
            Menu_UserControl.UpdateColors();
        }

        private string GetRandomPicPath()
        {
            if (IsValidPath(ImagesPath))
            {
                Random rand = new Random();

                string[] files = Directory.GetFiles(ImagesPath);
                return files[rand.Next(0, files.Length)];
            }
            return null;
        }

        private bool IsValidPath(in string path)
        {
            try
            {
                string[] files = Directory.GetFiles(path, "*.jpeg");
                return true;
            }
            catch (Exception)
            {
                return false;
            }
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
            if ((int)Days[0].GetMaxTemp() == (int)Days[0].GetMinTemp())
            {
                MaxTemp_label.Text = $"{(int)Days[0].GetMaxTemp()}°C";
                MinTemp_label.Text = "";
            }
            else
            {
                MaxTemp_label.Text = $"{(int)Days[0].GetMaxTemp()}°C";
                MinTemp_label.Text = $"{(int)Days[0].GetMinTemp()}°C";
            }
            WeatherType_label.Text = Days[0].GetDescription();
            Location_label.Text = $"{Days[0].City.name}, {Days[0].City.country}";
            DayOfWeek_label.Text = Days[0].Date.DayOfWeek.ToString();
            MonthAndYear_label.Text = Days[0].Date.ToShortDateString();

            Menu_UserControl.Main = this;
            Menu_UserControl.Days = Days;
            Menu_UserControl.AddItmes();
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

        private void MainForm_Activated(object sender, EventArgs e)
        {
            SendToBack();
        }
    }
}
