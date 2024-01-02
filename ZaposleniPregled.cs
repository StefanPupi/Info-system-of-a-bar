using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diplomski
{
    public partial class formaZaposleniPregled : Form
    {
        int pristup;
        public formaZaposleniPregled()
        {
            InitializeComponent();
        }

        public formaZaposleniPregled(int korisnik)
        {
            InitializeComponent();
            this.pristup = korisnik;
        }

        private void btnNovRac_Click(object sender, EventArgs e)
        {
            formaZaposleniNoviRacun zaposleniNoviRacun = new formaZaposleniNoviRacun(pristup);
            zaposleniNoviRacun.Show();
            this.Hide();
        }

        private void btnUrediRac_Click(object sender, EventArgs e)
        {
            formaZaposleniUrediRacun zaposleniUrediRacun = new formaZaposleniUrediRacun();
            zaposleniUrediRacun.Show();
            this.Hide();
        }

        private void btnSviRac_Click(object sender, EventArgs e)
        {
            formaPregledRacuni pregledRacuni = new formaPregledRacuni();
            pregledRacuni.Show();
            this.Hide();
        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            formaPrijava formaLogin = new formaPrijava();
            formaLogin.Show();
            this.Dispose();
        }
    }
}
