using System;                       //dyrektywy (wszystkie przestrzenie nazw których używamy) 
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace SmartMirror
{
    public partial class Form1 : Form
    {
        public string NazwaMiastaLok;   // Zmienna przechowywująca nazwę miasta na potrzeby tego obiektu

        string KopiaNazwaObrazka1 = "icon1";
        string KopiaNazwaObrazka2 = "icon2";
        string KopiaNazwaObrazka3 = "icon3";
        string KopiaNazwaObrazka4 = "icon4";
        string KopiaNazwaObrazka5 = "icon5";
        string NazwaObrazkaLok;
        string NazwaObrazkaLok2;

        public Form1(string NazwaMiastaUzytkownika, bool[] UstawieniaCheckBox )
        {
            InitializeComponent();  // wyołanie designera okna 
            NazwaMiastaLok = NazwaMiastaUzytkownika;

            //Form2 Ustawienia = new Form2();
            //Ustawienia.CheckboxChanged += ustawienia_CheckboxChanged;

            //Form2 Settings = new Form2();
            //Settings.CheckboxChanged += settings_CheckboxChanged;

            if (!UstawieniaCheckBox[0])
            {
                pogodaTemp.Visible = false;
                pogodaIcon.Visible = false;
            }

            if (!UstawieniaCheckBox[1])
            {
                zegarLabel.Visible = false;
            }

            if (!UstawieniaCheckBox[2])
            {
                dataLabel.Visible = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Start();
        }

        public void timer_Tick(object sender, EventArgs e)
        {           
            DataiGodzna aktualna = new DataiGodzna();   //Konstruktor obiektu
            
            zegarLabel.Text = aktualna.DajCzas();
            dataLabel.Text = aktualna.DajDate();

            Pogoda aktualnaT = new Pogoda();           
            pogodaTemp.Text = aktualnaT.getWeather(NazwaMiastaLok);
            pogodaTemp2.Text = aktualnaT.getWeatherForcast(NazwaMiastaLok);

            NazwaObrazkaLok = aktualnaT.ZmianaIkony(NazwaMiastaLok);    //Zwraca nazwe obrazka aktualnej pogody

            if (NazwaObrazkaLok.Equals(KopiaNazwaObrazka1)) //Ustawia obrazek aktualnej pogoidy 
            {
                pogodaIcon.Image = Properties.Resources.icon1;
                pogodaIcon.SizeMode = PictureBoxSizeMode.StretchImage;

            }
            else if (NazwaObrazkaLok.Equals(KopiaNazwaObrazka5))
            {
                pogodaIcon.Image = Properties.Resources.icon5;
                pogodaIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (NazwaObrazkaLok.Equals(KopiaNazwaObrazka2))
            {
                pogodaIcon.Image = Properties.Resources.icon2;
                pogodaIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (NazwaObrazkaLok.Equals(KopiaNazwaObrazka3))
            {
                pogodaIcon.Image = Properties.Resources.icon3;
                pogodaIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (NazwaObrazkaLok.Equals(KopiaNazwaObrazka4))
            {
                pogodaIcon.Image = Properties.Resources.icon4;
                pogodaIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                pogodaIcon.Image = Properties.Resources.icon0;
                pogodaIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            NazwaObrazkaLok2 = aktualnaT.ZmianaIkony2(NazwaMiastaLok);    //Zwraca nazwe obrazka przyszłej pogody
            if (NazwaObrazkaLok2.Equals(KopiaNazwaObrazka1)) //Ustawia obrazek przyszłej pogoidy 
            {
                pogodaIcon2.Image = Properties.Resources.icon1;
                pogodaIcon2.SizeMode = PictureBoxSizeMode.StretchImage;

            }
            else if (NazwaObrazkaLok2.Equals(KopiaNazwaObrazka5))
            {
                pogodaIcon2.Image = Properties.Resources.icon5;
                pogodaIcon2.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (NazwaObrazkaLok2.Equals(KopiaNazwaObrazka2))
            {
                pogodaIcon2.Image = Properties.Resources.icon2;
                pogodaIcon2.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (NazwaObrazkaLok2.Equals(KopiaNazwaObrazka3))
            {
                pogodaIcon2.Image = Properties.Resources.icon3;
                pogodaIcon2.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (NazwaObrazkaLok2.Equals(KopiaNazwaObrazka4))
            {
                pogodaIcon2.Image = Properties.Resources.icon4;
                pogodaIcon2.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                pogodaIcon2.Image = Properties.Resources.icon0;
                pogodaIcon2.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        public void checkbox1_checkedChanged(object sender, CheckEventArgs2 e)
        {
            //test = e.pogodaChecked;
            MessageBox.Show("test", "test", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Debug.WriteLine(e.pogodaChecked);
            if (e.pogodaChecked)
            {
                //pogodaTemp.ForeColor = Color.FromArgb(255, 255, 255);
                MessageBox.Show("test", "test", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else
            {
                MessageBox.Show("xxx", "xxx", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void settings_CheckboxChanged(object sender, CheckEventArgs e)
        {
            //checkBox1.Checked = CheckEventArgs.Checked;
            //System.Diagnostics.Debug.WriteLine(CheckEventArgs.Checked);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void czasLabel_Click(object sender, EventArgs e)
        {

        }
    }
    
}
