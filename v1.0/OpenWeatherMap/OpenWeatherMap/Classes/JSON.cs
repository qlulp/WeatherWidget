using System.Collections.Generic;

namespace OpenWeatherMap
{
    public class JSON
    {
        public List<ListItem> list { get; set; }
        public City city { get; set; }
    }

    public class ListItem
    {
        public Main main { get; set; }
        public List<Weather> weather { get; set; }
        public string dt_txt { get; set; }
    }

    public class Main
    {
        public double temp_min { get; set; }
        public double temp_max { get; set; }

    }

    public class Weather
    {
        public string description { get; set; }
    }

    public class City
    {
        public string name { get; set; }
        public string country { get; set; }

    }
}
