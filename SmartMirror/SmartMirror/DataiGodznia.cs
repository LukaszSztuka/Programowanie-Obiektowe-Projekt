using System;
using System.Collections.Generic;
using System.Text;

namespace SmartMirror
{
    public class DataiGodzna        //Obiekt odpowiedzialny za godzinę i datę 
    {
        private String Godzina;
        private String Minuta;
        public String Czas;

        private String Dzien;
        private String Miesiac;
        private String Rok;
        public String Data;

        public String DajCzas()     //Metoda tworzącza godzinę 
        {
            Godzina = DateTime.Now.ToString("HH");
            Minuta = DateTime.Now.ToString("mm");
            Czas = Godzina + ":" + Minuta;
            return Czas;
        }

        public String DajDate()     //Metoda tworząca datę 
        {
            Dzien = DateTime.Now.ToString("dd");
            Miesiac = DateTime.Now.ToString("MMMM");
            Rok = DateTime.Now.ToString("yyyy");
            Data = Dzien + " " + Miesiac + " " + Rok;
            return Data;

        }
    }  
     
}
