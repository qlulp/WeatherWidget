using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace OpenWeatherMap
{
    class OpenWeather
    {
        private string URL { get; set; }

        public string StringResponce { get; private set; }

        public JSON ObjResponce { get; private set; }
        List<Day> Days;

        public OpenWeather(string url)
        {
            URL = url;
            if (IsAvaible(url))
                MakeRequest();
        }

        public OpenWeather()
        {

        }

        private void MakeRequest()
        {
            string responce;
            try
            {
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(URL);
                HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
                {
                    responce = streamReader.ReadToEnd();
                }
                httpWebResponse.Close();
                ObjResponce = new JSON();
                ObjResponce = JsonConvert.DeserializeObject<JSON>(responce);

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        public bool IsAvaible(in string URL)
        {
            try
            {
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(URL);

                HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                httpWebResponse.Close();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public List<Day> GetList()
        {
            Days = new List<Day>();

            // 0 element
            int counter = 1;
            int day = DateTime.Parse(ObjResponce.list[0].dt_txt).Day;
            Day temp = new Day();
            temp = Merge(temp, ObjResponce.list[0]);

            for (int i = 1; i < ObjResponce.list.Count; i++)
            {
                int tempDay = DateTime.Parse(ObjResponce.list[i].dt_txt).Day;
                if (day == tempDay)
                {
                    temp = Merge(temp, ObjResponce.list[i]);
                    counter++;
                }
                else
                {
                    Days.Add(temp);
                    counter = 1;
                    temp = new Day();
                    temp = Merge(temp, ObjResponce.list[i]);
                    day = tempDay;
                }
            }

            return Days;
        }

        public Day Merge(in Day day, in ListItem item)
        {
            day.Temp_min.Add(item.main.temp_min);
            day.Temp_max.Add(item.main.temp_max);
            day.Description.Add(item.weather[0].description);
            day.Date = DateTime.Parse(item.dt_txt);
            day.City = ObjResponce.city;
            return day;
        }
    }
}
