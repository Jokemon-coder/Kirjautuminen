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
    public partial class Kirjautuminen : Form
    {
        public Kirjautuminen()
        {
            InitializeComponent();
            this.Width = 610;
            this.Height = 440;
            //Kun ohjelma avataan, sille annetaan tietty leveys ja korkeus.
            

        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //Kun painat "Exit", ohjelma sammuu.
        }


        private void Rekisteri_Load(object sender, EventArgs e)
        {
            userNameLoota.Text = Rekisteroidy.SetValueForKayttaja;
            passWordLoota.Text = Rekisteroidy.SetValueForSalasana;
            passWordLoota.Text = Rekisteroidy.SetValueForSalasana2;
            //Antaa käyttäjätunnukselle ja salasanalle "Rekisteröidy" ikkunassa annetut arvot.
        }

        private void loginNappi_Click(object sender, EventArgs e)
        {

            String kayttaja = userNameLoota.Text;
            String salasana = passWordLoota.Text;
            if (kayttaja == Rekisteroidy.SetValueForKayttaja && salasana == Rekisteroidy.SetValueForSalasana)
            {
                this.Hide();
                Paaikkuna main = new Paaikkuna();
                main.Show();
            }
            //Jos annettu salasana ja käyttäjätunnus täsmää määrätyiden arvojen kanssa, Pääikkuna avautuu.
            else
            {
                MessageBox.Show("Käyttäjätunnus tai salasana ovat väärin", "Jokin meni vikaan!");
            }
            //Jos jompikumpi ei täsmää, saat Ilmoituksen siitä.

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tekijä: Joel", "About");
        //Kun painaa "About" painiketta, tulee ohjelmasta yllä annetut tiedot.        
        }

        private void rekisteröidy_Click(object sender, EventArgs e)
        {
            this.Hide();
            Rekisteroidy main = new Rekisteroidy();
            main.Show();
        //"Rekisteröidy" painiketta kun painaa, se sulkee kirjautumisikkunan ja avaa rekisteröitymisikkunan.
        }
    }
}
