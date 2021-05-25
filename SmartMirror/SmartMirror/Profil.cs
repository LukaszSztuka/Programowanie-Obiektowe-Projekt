using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.IO;

namespace SmartMirror
{
    public class Profil
    {
        public int id { get; set; }
        public string nazwa { get; set; }
        public string login { get; set; }
        public string haslo { get; set; }
        public bool pogoda { get; set; }
        public bool pogodaProg { get; set; }
        public bool zegar { get; set; }
        public bool data { get; set; }

        public override string ToString()
        {
            return id.ToString() + ":" + nazwa.ToString();
        }
    }
}
