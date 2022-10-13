using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net;

namespace Weather_Application
{
    public partial class Form1 : Form
    {
        string APIKey = "8d36f90fdbdacdcf0fdd5e789c7cbc49";
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            getWeather();
        }

        void getWeather()
        {
            try
            {
                using (WebClient web = new WebClient())
                {
                    string url = $"https://api.openweathermap.org/data/2.5/weather?q={TBCity.Text}&appid={APIKey}";
                    var json = web.DownloadString(url);
                    WeatherInfo.root Info = JsonConvert.DeserializeObject<WeatherInfo.root>(json);

                    PicIcon.ImageLocation = "https://openweathermap.org/img/w/" + Info.weather[0].icon + ".png";
                    LblCondition.Text = Info.weather[0].main;
                    LblDetails.Text = Info.weather[0].description[0].ToString().ToUpper() + Info.weather[0].description.Substring(1).ToString().ToLower();
                    LblSunset.Text = convertDateTime(Info.sys.sunset).ToShortTimeString();
                    LblSunrise.Text = convertDateTime(Info.sys.sunrise).ToShortTimeString();

                    LblWindSpeed.Text = Info.wind.speed.ToString();
                    LblPressure.Text = Info.main.pressure.ToString();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        DateTime convertDateTime(long millisec)
        {
            DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);

            day = day.AddSeconds(millisec).ToLocalTime();

            return day;
        }
    }
}
