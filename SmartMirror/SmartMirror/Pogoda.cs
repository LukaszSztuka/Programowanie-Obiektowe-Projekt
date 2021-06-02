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
        const string APPID = "Tu uzupełnić"; // ID z openweathermap.org
        public string Temp;
        public string NazwaObrazka;
               

        public string getTempAkt(string NazwaMiasta)
        {
            using(WebClient web = new WebClient())
            {
                string url = string.Format("http://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}&units=metric&cnt=6", NazwaMiasta, APPID);
                System.Diagnostics.Debug.WriteLine(url);
                var json = web.DownloadString(url);

                var dSerial = JsonConvert.DeserializeObject<PogodaAktualna.root>(json);

                PogodaAktualna.root dane = dSerial;

                Temp = string.Format("{0} \u00B0" + "C", Math.Round(dane.main.feels_like));   //\u00B0 = stopień 
                return Temp;
            }
        
        }
        public string getTempProg(string NazwaMiasta)
        {
            using (WebClient web = new WebClient())
            {
                string url2 = string.Format("http://api.openweathermap.org/data/2.5/forecast?q={0}&mode=json&appid={1}&units=metric", NazwaMiasta, APPID);

                var json2 = web.DownloadString(url2);

                var dSerial2 = JsonConvert.DeserializeObject<PogodaPrognozowana.dane>(json2);

                PogodaPrognozowana.dane dane2 = dSerial2;

                Temp = string.Format("{0} \u00B0" + "C", Math.Round(dane2.list[8].main.temp));   //\u00B0 = stopień 
                return Temp;
            }

        }
        public string ZmianaIkony(string NazwaMiasta)
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("http://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}&units=metric&cnt=6", NazwaMiasta, APPID);
                var json = web.DownloadString(url);
                var dSerial3 = JsonConvert.DeserializeObject<PogodaAktualna.root>(json);
                PogodaAktualna.root dane3 = dSerial3;

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
        public string ZmianaIkony2(string NazwaMiasta)
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("http://api.openweathermap.org/data/2.5/forecast?q={0}&mode=json&appid={1}&units=metric", NazwaMiasta, APPID);
                var json = web.DownloadString(url);
                var dSerial4 = JsonConvert.DeserializeObject<PogodaPrognozowana.dane>(json);
                PogodaPrognozowana.dane dane4 = dSerial4;

                if (string.Format("{0}", dane4.list[8].weather[0].icon) == string.Format("01d"))//słoneczko
                {
                    NazwaObrazka = "icon1";
                }
                else if (string.Format("{0}", dane4.list[8].weather[0].icon) == string.Format("01n"))//ksiezyc
                {
                    NazwaObrazka = "icon5";
                }
                else if (string.Format("{0}", dane4.list[8].weather[0].main) == string.Format("Clouds"))
                {
                    NazwaObrazka = "icon2";
                }
                else if (string.Format("{0}", dane4.list[8].weather[0].main) == string.Format("Rain"))
                {
                    NazwaObrazka = "icon3";
                }
                else if (string.Format("{0}", dane4.list[8].weather[0].main) == string.Format("Snow"))
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
