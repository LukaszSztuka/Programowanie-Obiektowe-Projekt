using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SmartMirror
{
    public partial class Ustawienia : Form
    {
        
        public Ustawienia()
        {
            InitializeComponent();

        }


        private void Form2_Load(object sender, EventArgs e)
        {
            IpLokalizacja lokalizacja = new IpLokalizacja();
            miastoTextBox.Text = lokalizacja.getMiasto();

            List<Profil> profile = new List<Profil>();
            string plik = File.ReadAllText("profile.json");

            profile = JsonConvert.DeserializeObject<List<Profil>>(plik);

            foreach (Profil p in profile)
            {
                listBox1.Items.Add(p);
            }
        }
              

        public void button1_Click(object sender, EventArgs e)
        {
            string Nazwa = miastoTextBox.Text;
            int id = listBox1.Items.IndexOf(listBox1.SelectedItem);
            if (listBox1.Items.IndexOf(listBox1.SelectedItem)>1)
            {
                id = listBox1.Items.IndexOf(listBox1.SelectedItem);
            }
            else
            {
                id = 0;
            }

            SmartMirrorApp form1 = new SmartMirrorApp(id, Nazwa, new bool[]{
                pogodaCheckBox.Checked,
                pogodaProgCheckBox.Checked,
                zegarCheckBox.Checked,
                dataCheckBox.Checked,
                kalendarzCheckBox.Checked});

            form1.ShowDialog();
            this.Close();

        }

        private void miastoTextBox_TextChanged(object sender, EventArgs e)
        {
            if (miastoTextBox.Text.Length > 0)
            {
                zatwierdzButton.Enabled = true;
            }
            else
            {
                zatwierdzButton.Enabled = false;
            } 
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
            {
                List<Profil> profile = new List<Profil>();
                string plik = File.ReadAllText("profile.json");

                profile = JsonConvert.DeserializeObject<List<Profil>>(plik);

                int idProfil = listBox1.Items.IndexOf(listBox1.SelectedItem);

                pogodaCheckBox.Checked = profile[idProfil].pogoda;
                pogodaProgCheckBox.Checked = profile[idProfil].pogodaProg;
                zegarCheckBox.Checked = profile[idProfil].zegar;
                dataCheckBox.Checked = profile[idProfil].data;
                kalendarzCheckBox.Checked = profile[idProfil].kalendarz;
                Invalidate();
                Update();
            }
        }

        
        private void button1_Click_1(object sender, EventArgs e)
        {
            DodajProfil dodajForm = new DodajProfil();
            dodajForm.FormClosed += new FormClosedEventHandler(DodajProfil_FormClosed);
            dodajForm.ShowDialog();
        }

        private void DodajProfil_FormClosed(object sender, FormClosedEventArgs e)
        {
            List<Profil> profile = new List<Profil>();
            string plik = File.ReadAllText("profile.json");

            profile = JsonConvert.DeserializeObject<List<Profil>>(plik);
            //System.Diagnostics.Debug.WriteLine(profile);

            listBox1.Items.Clear();

            foreach (Profil p in profile)
            {
                listBox1.Items.Add(p);
            }
        }

        private void usunButtonClick(object sender, MouseEventArgs e)
        {
            string profilName = listBox1.SelectedItem.ToString();
            DialogResult dialogResult = MessageBox.Show("Czy napewno chcesz usunąć profil " + profilName + " ?", "Usuń profil" , MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                List<Profil> profile = new List<Profil>();
                string plik = File.ReadAllText("profile.json");

                profile = JsonConvert.DeserializeObject<List<Profil>>(plik);
                profile.RemoveAt(listBox1.Items.IndexOf(listBox1.SelectedItem));

                plik = JsonConvert.SerializeObject(profile);
                File.WriteAllText("profile.json", plik);

                listBox1.Items.Clear();

                foreach (Profil p in profile)
                {
                    listBox1.Items.Add(p);
                }
            }
        }
    }
}
