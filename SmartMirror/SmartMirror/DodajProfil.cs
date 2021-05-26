using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace SmartMirror
{
    public partial class DodajProfil : Form
    {
        public DodajProfil()
        {
            InitializeComponent();
        }

        private void nazwaTextBoxChanged(object sender, EventArgs e)
        {
            if (nazwaTextBox.Text.Length > 0)
            {
                dodajButton.Enabled = true;
            }
            else
            {
                dodajButton.Enabled = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dodajButtonClick(object sender, EventArgs e)
        {
           
           List<Profil> profile = new List<Profil>();
           Profil nowy = new Profil();
           

           string plik = File.ReadAllText("profile.json");
           profile = JsonConvert.DeserializeObject<List<Profil>>(plik);

           nowy.id = profile.Count + 1;
           nowy.nazwa = nazwaTextBox.Text;
           nowy.login = loginTextBox.Text;
           nowy.haslo = hasloTextBox.Text;
           nowy.pogoda = pogodaCheckBox.Checked;
           nowy.pogodaProg = pogodaProgCheckBox.Checked;
           nowy.zegar = zegarCheckBox.Checked;
           nowy.data = dataCheckBox.Checked;
           profile.Add(nowy);

           plik = JsonConvert.SerializeObject(profile);
           File.WriteAllText("profile.json", plik);

           Ustawienia ust = new Ustawienia();
           ust.Refresh();
           this.Close();
        }
    }
}
