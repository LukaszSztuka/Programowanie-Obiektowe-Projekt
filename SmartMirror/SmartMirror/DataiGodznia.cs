using System;
using System.Collections.Generic;
using System.Text;

namespace SmartMirror
{
    public class DataiGodzna        //Obiekt odpowiedzialny za godzinę i datę 
    {
        private string Godzina;
        private string Minuta;
        public string Czas;

        private string Dzien;
        private string Miesiac;
        private string Rok;
        public string Data;

        public string DajCzas()     //Metoda tworzącza godzinę 
        {
            Godzina = DateTime.Now.ToString("HH");
            Minuta = DateTime.Now.ToString("mm");
            Czas = Godzina + ":" + Minuta;
            return Czas;
        }

        public string DajDate()     //Metoda tworząca datę 
        {
            Dzien = DateTime.Now.ToString("dd");
            Miesiac = DateTime.Now.ToString("MMMM");
            Rok = DateTime.Now.ToString("yyyy");
            Data = Dzien + " " + Miesiac + " " + Rok;
            return Data;

        }
    }  
     
}
