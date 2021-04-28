using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace SmartMirror
{
    public class Pogoda
    {
        const string APPID = "846aad33c8c01e7f1baae5e467b7c21f";
        string NazwaMiasta = "warsaw,pl";
        public string test;

          

        public string getWeather()
        {
            using(WebClient web = new WebClient())
            {
                string url = string.Format("http://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}&units=metric&cnt=6", NazwaMiasta, APPID);

                var json = web.DownloadString(url);

                var dSerial = JsonConvert.DeserializeObject<WeatherInfo.root>(json);

                WeatherInfo.root dane = dSerial;

                test = string.Format("{0} \u00B0" + "C", Math.Round(dane.main.feels_like));   //\u00B0 = stopień 
                return test;
            }
            
        }

    }
}
