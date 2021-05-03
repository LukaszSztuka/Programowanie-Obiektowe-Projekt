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
        public string Temp;
        public string NazwaObrazka;
               

        public string getWeather(string NazwaMiasta)
        {
            using(WebClient web = new WebClient())
            {
                string url = string.Format("http://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}&units=metric&cnt=6", NazwaMiasta, APPID);

                var json = web.DownloadString(url);

                var dSerial = JsonConvert.DeserializeObject<WeatherInfo.root>(json);

                WeatherInfo.root dane = dSerial;

                Temp = string.Format("{0} \u00B0" + "C", Math.Round(dane.main.feels_like));   //\u00B0 = stopień 
                return Temp;
            }
            
        }

        public string ZmianaIkony(string miasto)
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("http://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}&units=metric&cnt=6", miasto, APPID);
                var json = web.DownloadString(url);
                var dSerial3 = JsonConvert.DeserializeObject<WeatherInfo.root>(json);
                WeatherInfo.root dane3 = dSerial3;

                if (string.Format("{0}", dane3.weather[0].icon) == string.Format("01d"))//słoneczko
                {
                    NazwaObrazka = "icon1";
                }
                else if (string.Format("{0}", dane3.weather[0].icon) == string.Format("01n"))//ksiezyc
                {
                    NazwaObrazka = "icon5";
                }
                else if (string.Format("{0}", dane3.weather[0].main) == string.Format("Clouds"))
                {
                    NazwaObrazka = "icon2";
                }
                else if (string.Format("{0}", dane3.weather[0].main) == string.Format("Rain"))
                {
                    NazwaObrazka = "icon3";
                }
                else if (string.Format("{0}", dane3.weather[0].main) == string.Format("Snow"))
                {
                    NazwaObrazka = "icon4";
                }
                else
                {
                    NazwaObrazka = "icon0";
                }

                return NazwaObrazka;
            }
        }
    }
}
