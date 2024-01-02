using System;
using System.Windows.Forms;

namespace Diplomski
{
    public partial class formaAdminPregled : Form
    {
        public formaAdminPregled()
        {
            InitializeComponent();
        }

        private void btnPregledKorisnika_Click(object sender, EventArgs e)
        {
            formaPregledKorisnici pregledKorisnici = new formaPregledKorisnici("Administrator");
            pregledKorisnici.Show();
            this.Hide();
        }

        private void btnDodajKorisnika_Click(object sender, EventArgs e)
        {
            formaAdminDodajKorisnika adminDodajKorisnika = new formaAdminDodajKorisnika();
            adminDodajKorisnika.Show();
            this.Hide();
        }

        private void btnUrediKorisnika_Click(object sender, EventArgs e)
        {
            formaAdminUrediKorisnika adminUrediKorisnika = new formaAdminUrediKorisnika();
            adminUrediKorisnika.Show();
            this.Hide();
        }

        private void btnUkloniKorisnika_Click(object sender, EventArgs e)
        {
            formaAdminUkloniKorisnika adminUkloniKorisnika = new formaAdminUkloniKorisnika();
            adminUkloniKorisnika.Show();
            this.Hide();
        }

        private void btnBazaRacuni_Click(object sender, EventArgs e)
        {
            formaPregledRacuni pregledRacuni = new formaPregledRacuni("Administrator");
            pregledRacuni.Show();
            this.Hide();
        }

        private void btnBazaProizvodi_Click(object sender, EventArgs e)
        {
            formaPregledProizvoda pregledProizvoda = new formaPregledProizvoda("Administrator");
            pregledProizvoda.Show();
            this.Hide();
        }

        private void btnBazaNabavke_Click(object sender, EventArgs e)
        {
            formaPregledNabavka pregledNabavka = new formaPregledNabavka("Administrator");
            pregledNabavka.Show();
            this.Hide();
        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            formaPrijava formaLogin = new formaPrijava();
            formaLogin.Show();
            this.Dispose();
        }

        private void formaAdminPregled_FormClosed(object sender, FormClosedEventArgs e)
        {
            formaPrijava formaLogin = new formaPrijava();
            formaLogin.Show();
            this.Dispose();
        }
    }
}
