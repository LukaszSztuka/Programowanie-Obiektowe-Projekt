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
            //System.Diagnostics.Debug.WriteLine(profile);


            foreach (Profil p in profile)
            {
                listBox1.Items.Add(p);
            }
        }
              

        public void button1_Click(object sender, EventArgs e)
        {
            string Nazwa = miastoTextBox.Text;
            //System.Diagnostics.Debug.WriteLine(pogodaCheckBox.Checked);

            SmartMirrorApp form1 = new SmartMirrorApp(Nazwa, new bool[]{
                pogodaCheckBox.Checked,
                pogodaProgCheckBox.Checked,
                zegarCheckBox.Checked,
                dataCheckBox.Checked});

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
                //System.Diagnostics.Debug.WriteLine(profile[idProfil].pogoda);
                //System.Diagnostics.Debug.WriteLine(listBox1.SelectedIndex);

                pogodaCheckBox.Checked = profile[idProfil].pogoda;
                pogodaProgCheckBox.Checked = profile[idProfil].pogodaProg;
                zegarCheckBox.Checked = profile[idProfil].zegar;
                dataCheckBox.Checked = profile[idProfil].data;
                Invalidate();
                Update();
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

      

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void wybierzButtonClick(object sender, EventArgs e)
        {
            List<Profil> profile = new List<Profil>();
            string plik = File.ReadAllText("profile.json");

            profile = JsonConvert.DeserializeObject<List<Profil>>(plik);

            int idProfil = listBox1.Items.IndexOf(listBox1.SelectedItem);
            //System.Diagnostics.Debug.WriteLine(profile[idProfil].pogoda);
            //System.Diagnostics.Debug.WriteLine(listBox1.SelectedIndex);

            pogodaCheckBox.Checked = profile[idProfil].pogoda;
            pogodaProgCheckBox.Checked = profile[idProfil].pogodaProg;
            zegarCheckBox.Checked = profile[idProfil].zegar;
            dataCheckBox.Checked = profile[idProfil].data;
            pogodaCheckBox.Invalidate();
            pogodaCheckBox.Update();
        }

        private void label2_Click(object sender, EventArgs e)
        {

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
