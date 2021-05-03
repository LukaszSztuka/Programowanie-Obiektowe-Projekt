using System;                       //dyrektywy (wszystkie przestrzenie nazw których używamy) 
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        

        public Form1(string NazwaMiastaUzytkownika)
        {
            InitializeComponent();  // wyołanie designera okna 
            NazwaMiastaLok = NazwaMiastaUzytkownika;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Start();
        }

        public void timer_Tick(object sender, EventArgs e)
        {           
            DataiGodzna aktualna = new DataiGodzna();   //Konstruktor obiektu
            
            lblGodzina.Text = aktualna.DajCzas();
            lblData.Text = aktualna.DajDate();

            Pogoda aktualnaT = new Pogoda();           
            lblTemp.Text = aktualnaT.getWeather(NazwaMiastaLok);

            NazwaObrazkaLok = aktualnaT.ZmianaIkony(NazwaMiastaLok);    //Zwraca nazwe obrazka aktualnej pogody

            if (NazwaObrazkaLok.Equals(KopiaNazwaObrazka1))                        //Ustawia obrazek aktualnej pogoidy 
            {
                pictureBox1.Image = Properties.Resources.icon1;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            }
            else if (NazwaObrazkaLok.Equals(KopiaNazwaObrazka5))
            {
                pictureBox1.Image = Properties.Resources.icon5;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (NazwaObrazkaLok.Equals(KopiaNazwaObrazka2))
            {
                pictureBox1.Image = Properties.Resources.icon2;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (NazwaObrazkaLok.Equals(KopiaNazwaObrazka3))
            {
                pictureBox1.Image = Properties.Resources.icon3;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (NazwaObrazkaLok.Equals(KopiaNazwaObrazka4))
            {
                pictureBox1.Image = Properties.Resources.icon4;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                pictureBox1.Image = Properties.Resources.icon0;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }

        }

        
    }
    
}
