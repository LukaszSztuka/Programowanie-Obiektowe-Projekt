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
        //public event EventHandler<CheckEventArgs> CheckboxChanged;
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
            //CheckboxChanged?.Invoke(this, new CheckEventArgs() { Checked = pogodaCheckBox.Checked });
        
        
            string Nazwa = miastoTextBox.Text;
            System.Diagnostics.Debug.WriteLine(pogodaCheckBox.Checked);

            Form1 form1 = new Form1(Nazwa, new bool[]{
                pogodaCheckBox.Checked,
                zegarCheckBox.Checked,
                dataCheckBox.Checked});

            form1.ShowDialog();
            this.Close();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (miastoTextBox.Text.Length > 0)
            {
                zatwierdzButton.Enabled = true;
            } else
            {
                zatwierdzButton.Enabled = false;
            }
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //CheckboxChanged?.Invoke(this, new CheckEventArgs() { CheckEventArgs.Checked = pogodaCheckBox.Checked });
            //Form1 test = new Form1(miastoTextBox.Text);

            // if (pogodaCheckBox.Checked)
            //{
            //    CheckboxChanged?.Invoke(this, new CheckEventArgs()
            //     {
            //        pogodaChecked = pogodaCheckBox.Checked
            //    });
            // }

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
