using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Diplomski
{
    public partial class formaPrijava : Form
    {
        Serializer serializer;
        Stream fs;
        List<Korisnik> korisnici;
        string putanja = "korisnik.bin";
        public formaPrijava()
        {
            InitializeComponent();
            serializer = new Serializer();
            korisnici = new List<Korisnik>();
        }

        private void formaPrijava_FormClosed(object sender, FormClosedEventArgs e)
        {
            formaPocetak formaPocetak = new formaPocetak();
            formaPocetak.Show();
            this.Dispose();
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            fs = File.OpenRead(putanja);
            if (fs.Length == 0)
            {
                MessageBox.Show("Trenutno nema registrovanih korisnika!");
                return;
            }
            korisnici = serializer.DeserializeKorisnik(fs);
            fs.Close();
            string korisnickoIme = "";
            string lozinka = "";
            korisnickoIme = tbKorIme.Text;
            lozinka = tbLozinka.Text;
            /*Provera jesu li vrednosti uopšte upisane*/
            if (korisnickoIme == "")
            {
                MessageBox.Show("Morate uneti korisničko ime!");
                return;
            }
            if (lozinka == "")
            {
                MessageBox.Show("Morate uneti lozinku!");
                return;
            }
            /*Provera koji korisnik je prijavljen*/
            foreach (Korisnik kor in korisnici)
            {
                if (korisnickoIme.ToLower() == kor.Korisnicko_ime && lozinka == kor.Lozinka)
                {
                    MessageBox.Show("Uspesno ste se prijavili " + kor.Ime + " !");
                    if (kor.Posao.ToLower() == "administrator")
                    {
                        formaAdminPregled AdminPregled = new formaAdminPregled();
                        AdminPregled.Show();
                        this.Hide();
                    }
                    if (kor.Posao.ToLower() == "menadzer")
                    {
                        formaMenadzerPregled MenadzerPregled = new formaMenadzerPregled(kor.Id_korisnika);
                        MenadzerPregled.Show();
                        this.Hide();
                    }
                    if (kor.Posao.ToLower() == "zaposleni")
                    {
                        formaZaposleniPregled1 ZaposleniPregled = new formaZaposleniPregled1(kor.Id_korisnika);
                        ZaposleniPregled.Show();
                        this.Hide();
                    }
                    fs.Close();
                    return;
                }
            }
            
            MessageBox.Show("Proverite podatke!");
        }
    }
}
