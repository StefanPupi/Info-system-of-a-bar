using System;
using System.Windows.Forms;

namespace Diplomski
{
    public partial class formaMenadzerPregled : Form
    {
        int idMenadzera;
        public formaMenadzerPregled(int idMenadzera)
        {
            InitializeComponent();
            this.idMenadzera = idMenadzera;
        }

        public formaMenadzerPregled()
        {
            InitializeComponent();
        }

        private void btnPregledZaposlenih_Click(object sender, EventArgs e)
        {
            formaPregledKorisnici pregledKorisnici = new formaPregledKorisnici("Menadzer");
            pregledKorisnici.Show();
            this.Hide();
        }

        private void btnDodajZaposlenog_Click(object sender, EventArgs e)
        {
            formaMenadzerDodajZaposlenog menadzerDodajZaposlenog = new formaMenadzerDodajZaposlenog();
            menadzerDodajZaposlenog.Show();
            this.Hide();
        }

        private void btnUrediZaposlenog_Click(object sender, EventArgs e)
        {
            formaMenadzerUrediZaposlenog menadzerUrediZaposlenog = new formaMenadzerUrediZaposlenog();
            menadzerUrediZaposlenog.Show();
            this.Hide();
        }

        private void btnUkloniZaposlenog_Click(object sender, EventArgs e)
        {
            formaMenadzerUkloniZaposlenog menadzerUkloniZaposlenog = new formaMenadzerUkloniZaposlenog();
            menadzerUkloniZaposlenog.Show();
            this.Hide();
        }

        private void btnBazaRacuni_Click(object sender, EventArgs e)
        {
            formaPregledRacuni pregledRacuni = new formaPregledRacuni("Menadzer");
            pregledRacuni.Show();
            this.Hide();
        }

        private void btnBazaProizvodi_Click(object sender, EventArgs e)
        {
            formaPregledProizvoda pregledProizvoda = new formaPregledProizvoda("Menadzer");
            pregledProizvoda.Show();
            this.Hide();
        }

        private void btnBazaNabavke_Click(object sender, EventArgs e)
        {
            formaPregledNabavka pregledNabavka = new formaPregledNabavka("Menadzer");
            pregledNabavka.Show();
            this.Hide();
        }

        private void btnNovaNabavka_Click(object sender, EventArgs e)
        {
            formaMenadzerNovaNabavka menadzerNovaNabavka = new formaMenadzerNovaNabavka(idMenadzera);
            menadzerNovaNabavka.Show();
            this.Hide();
        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            formaPrijava formaLogin = new formaPrijava();
            formaLogin.Show();
            this.Dispose();
        }

        private void formaMenadzerPregled_FormClosed(object sender, FormClosedEventArgs e)
        {
            formaPrijava formaLogin = new formaPrijava();
            formaLogin.Show();
            this.Dispose();
        }
    }
}
