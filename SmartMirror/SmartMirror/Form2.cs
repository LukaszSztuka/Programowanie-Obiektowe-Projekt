using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

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
        }
              

        public void button1_Click(object sender, EventArgs e)
        {
            string Nazwa = miastoTextBox.Text;
            System.Diagnostics.Debug.WriteLine(pogodaCheckBox.Checked);

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
    }
}
