using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace polugodisnjiZadatakJakov
{
    public partial class Form1 : Form
    {

        List<Sladoled> sladoled = new List<Sladoled>();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonUnos_Click(object sender, EventArgs e)
        {
            string naziv = textBoxNaziv.Text;
            string oblik = textBoxOblik.Text;
            string okus = textBoxOkus.Text;
            string preljev = comboBoxPreljev.Text;

            if (string.IsNullOrEmpty(naziv))
            {
                MessageBox.Show("Niste unijeli naziv!");
                return;
            }

            if (string.IsNullOrEmpty(oblik))
            {
                MessageBox.Show("Niste unijeli oblik!");
                return;
            }

            if (string.IsNullOrEmpty(okus))
            {
                MessageBox.Show("Niste unijeli okus!");
                return;
            }

            if (string.IsNullOrEmpty(preljev))
            {
                MessageBox.Show("Niste odabrali hoćete li preljev!");
                return;
            }
            sladoled.Add(new Sladoled(naziv, oblik, okus, preljev));

            for (int i = 0; i < sladoled.Count; i++)
            {
                if (sladoled[i].oblik == "Kornet")
                {
                    sladoled[i].cijena = 10;
                }
                else if (sladoled[i].oblik == "Na stapicu")
                {
                    sladoled[i].cijena = 15;
                }
                else if (sladoled[i].oblik == "Casica")
                {
                    sladoled[i].cijena = 13;
                }
            }


        }

        private void buttonIspis_Click(object sender, EventArgs e)
        {
            richTextBox.Clear();
            foreach (Sladoled sladoled in sladoled)
            {
                richTextBox.Text += sladoled.Ispis() + Environment.NewLine;
            }
        }

        private void buttonObradi_Click(object sender, EventArgs e)
        {
            richTextBox.Clear();
            foreach (Sladoled sladoled in sladoled)
            {
                richTextBox.Text += sladoled.Ispis2() + Environment.NewLine;
            }
        }
    }
}
