using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Beatacwiczenia;

namespace okno
{
    public partial class Form1 : Form
    {
        //tworzenie listy generycznej typu text
        List<string> slownik = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
            Cwiczenia Nazwa = new Cwiczenia();
            label1.Text = Nazwa.odwroc_text(textBox1.Text);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = textBox1.Text;
            Cwiczenia Nazwa = new Cwiczenia();
            bool wynik;
           wynik = Nazwa.palindrom(textBox1.Text);
            if (wynik == true )
            {
                label2.Text = "Tak";
            }
            else
            {
                label2.Text = "Nie";
            }
            
        }

        private string wpisanytext = "";
        int y = 60;
        private void button3_Click(object sender, EventArgs e)
        {
            wpisanytext = textBox2.Text;
            slownik.Add(wpisanytext);
                     
            Label leabel = new Label();
            Controls.Add(leabel);
            leabel.Size = new Size(100, 20);
            leabel.Location = new Point(159, y = y+20);
            leabel.Text = wpisanytext;   
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            wpisanytext = textBox2.Text;
            slownik.Add(wpisanytext);
            listBox1 = new ListBox();
        }
    }
}
