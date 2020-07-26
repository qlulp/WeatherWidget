using System;
using System.Collections.Generic;

namespace OpenWeatherMap
{
    public class Day
    {
        public City City { get; set; } // Город
        public List<double> Temp_min = new List<double>(); // Минимальная температура (каждые 3 часа)
        public List<double> Temp_max = new List<double>(); // Максимальная температура (каждые 3 часа)

        public List<string> Description = new List<string>(); // Тип погоды (каждые 3 часа)
        public DateTime Date { get; set; }

        public double GetAVGTemp()
        {
            return (GetMinTemp() + GetMaxTemp()) / 2;
        }

        public double GetMinTemp()
        {
            double res = Temp_min[0];
            foreach (double temp in Temp_min)
                if (res > temp)
                    res = temp;
            return res;
        }

        public string GetDescription() // Среднее значение типа погоды
        {
            int[] count = new int[Description.Count];

            for (int i = 0; i < Description.Count; i++)
                count[i] = CountInList(Description, Description[i]);
            return Description[IndexOfMaxValue(count)];
        }

        private int CountInList(List<string> list, string str)
        {
            int count = 0;
            foreach (string element in list)
                if (element == str)
                    count++;
            return count;
        }

        private int IndexOfMaxValue(int[] arr)
        {
            int index = 0;
            int a = arr[0];
            for (int i = 0; i < arr.Length; i++)
                if (a < arr[i])
                {
                    a = arr[i];
                    index = i;
                }
            return index;
        }

        public double GetMaxTemp()
        {
            double res = Temp_min[0];
            foreach (double temp in Temp_min)
                if (res < temp)
                    res = temp;
            return res;
        }
    }
}
