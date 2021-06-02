using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace SmartMirror
{
    public partial class DodajProfil : Form
    {
        string plikToken;
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
               

        private void dodajButtonClick(object sender, EventArgs e)
        {
           
           List<Profil> profile = new List<Profil>();
           Profil nowy = new Profil();
           

           string plik = File.ReadAllText("profile.json");
           profile = JsonConvert.DeserializeObject<List<Profil>>(plik);

           nowy.id = profile.Count + 1;
           nowy.nazwa = nazwaTextBox.Text;
           nowy.token = nowy.nazwa + "_token.json";
           nowy.kalendarz = kalendarzCheckBox.Checked;
           nowy.pogoda = pogodaCheckBox.Checked;
           nowy.pogodaProg = pogodaProgCheckBox.Checked;
           nowy.zegar = zegarCheckBox.Checked;
           nowy.data = dataCheckBox.Checked;
           profile.Add(nowy);

           plik = JsonConvert.SerializeObject(profile);
           File.WriteAllText("profile.json", plik);
           File.WriteAllText(nowy.token, plikToken);

           Ustawienia ust = new Ustawienia();
           ust.Refresh();
           this.Close();
        }

        private void dodajTokenClick(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.CheckFileExists = true;
            openFileDialog.AddExtension = true;
            openFileDialog.Multiselect = true;
            //openFileDialog.Filter = "Json files (*.json)|*.json|Text files (*.txt)|*.txt";
            openFileDialog.ToString();
                 
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string path = System.IO.Path.GetFullPath(openFileDialog.FileName);
                label2.Text = path;
                
                using (StreamReader p = new StreamReader(openFileDialog.OpenFile()))
                {
                    plikToken = p.ReadToEnd();
                }
            }
            System.Diagnostics.Debug.WriteLine(plikToken);

        }
    }
}
