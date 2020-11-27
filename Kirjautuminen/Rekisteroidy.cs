using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kirjautuminen
{
    public partial class Rekisteroidy : Form
    {
        public Rekisteroidy()
        {
            InitializeComponent();
        }

        public static string SetValueForKayttaja = "";
        public static string SetValueForSalasana = "";
        public static string SetValueForSalasana2 = "";
        //Jokaiselle stringille on annettu "tyhjä" arvoksi


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tekijä: Joel", "About");
        }

        private void luoKayttajaNappi_Click(object sender, EventArgs e)
        {
            SetValueForKayttaja = kayttajaTunnusLoota.Text;
            SetValueForSalasana = salasanaLoota.Text;
            SetValueForSalasana2 = salasanaLoota2.Text;
            //Stringien arvot muuttuvat annetuiksi arvoiksi

            Kirjautuminen kirja = new Kirjautuminen();
            kirja.Show();
            //Vie takaisin kirjautumissivulle
        }
    }

}
    

    

