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
        public Form1()
        {
            InitializeComponent();  // wyołanie designera okna 
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            //lblGodzina.Text = DateTime.Now.ToString("HH:mm");
            
            DataiGodzna aktualna = new DataiGodzna();   //Konstruktor obiektu
            
            lblGodzina.Text = aktualna.DajCzas();
            lblData.Text = aktualna.DajDate();
        }
                
    }
    
}
