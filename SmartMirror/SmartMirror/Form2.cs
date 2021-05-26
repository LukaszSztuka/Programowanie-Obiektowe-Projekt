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
    public partial class Form2 : Form
    {
        
        public Form2()
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
            System.Diagnostics.Debug.WriteLine(profile);


            foreach (Profil p in profile)
            {
                listBox1.Items.Add(p);
            }
        }
              

        public void button1_Click(object sender, EventArgs e)
        {
            string Nazwa = miastoTextBox.Text;
            //System.Diagnostics.Debug.WriteLine(pogodaCheckBox.Checked);

            Form1 form1 = new Form1(Nazwa, new bool[]{
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
            System.Diagnostics.Debug.WriteLine(profile[idProfil].pogoda);
            System.Diagnostics.Debug.WriteLine(listBox1.SelectedIndex);

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
    }
}
