using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GhostRider.Zaba.Bll;
using GhostRider.Zaba.Bll.BusinessLogicLayer;

namespace GhostRider.Zaba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DodajButton();
        }

        public void DodajButton()
        {
            Button przycisk = new Button();
            przycisk.Size = new Size(60, 20);
            przycisk.Location = new Point(40, 60);
            przycisk.Text = "Dodaj";
            przycisk.Click += przycisk_Click;
            Controls.Add(przycisk);
        }

        void przycisk_Click(object sender, EventArgs e)
        {
            Label nazwa = new Label();
            nazwa.Size = new Size(80, 200);
            nazwa.Location = new Point(40, 80);
            nazwa.Text = "Kocham was!!";
            Controls.Add(nazwa);
        }

        private void getProductsButton_Click(object sender, EventArgs e)
        {
            string imie = "ghostrider";
            char szukane = 'o';
            int pozycja = 0;

            for (int i = 0; i < imie.Length; i++)
            {
                
                if (imie[i] == szukane)
                {
                    pozycja = i;
                    break;
                }
            }

           // exscel csv text
           //while (sr.Readline())
           //foreach

            test test = new test();

            test.Test();
        }
    }
}
