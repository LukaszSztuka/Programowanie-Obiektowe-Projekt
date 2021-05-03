using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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

        }
              

        public void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length > 0)
            {
                string Nazwa = textBox1.Text;
                Form1 form1 = new Form1(Nazwa);
                form1.ShowDialog();
                this.Close();
                
            }
            else
            {
                MessageBox.Show("Nie wpisałeś nazwy miasta!", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
    }
}
