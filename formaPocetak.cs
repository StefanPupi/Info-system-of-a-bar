using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Diplomski
{
    public partial class formaPocetak : Form
    {
        Serializer serializer;
        Stream fs;
        List<Korisnik> korisnici;
        string putanja = "korisnik.bin";
        public formaPocetak()
        {
            InitializeComponent();
            serializer = new Serializer();
            korisnici = new List<Korisnik>();
        }

        private void OsveziKorisnike()
        { /*Provera da li fajl postoji*/
            if (!File.Exists(putanja))
            {
                fs = File.Open(putanja, FileMode.Create);
                fs.Close();
                return;
            }
                fs = File.OpenRead(putanja);
                if (fs.Length != 0)
                {
                    korisnici = serializer.DeserializeKorisnik(fs);
                    fs.Close();
                    return;
                }
                fs.Close();
        }

        private void formaPocetak_Load(object sender, EventArgs e)
        {/*Učitavanje forme,provera broja korisnika i biranje odgovarajućeg izgleda forme*/
            OsveziKorisnike();
            if (korisnici.Count == 0)
            {
                lblOpis.Text = "Trenutno nemate aktivnih administratora!\n Morate registrovati administratora pre prijave!";
                btnPrijaviSe.Visible = false;
                btnPrijaviSe.Enabled = false;
            }
            else
            {
                btnRegistrujSe.Visible = false;
                btnRegistrujSe.Enabled = false;
            }
        }

        private void btnPrijaviSe_Click(object sender, EventArgs e)
        {/*Slanje korisnika na formu za prijavu*/
            formaPrijava loginForma = new formaPrijava();
            this.Hide();
            loginForma.Show();
        }

        private void btnRegistrujSe_Click(object sender, EventArgs e)
        {/*Slanje korisnika na formu za registraciju*/
            formaRegAdmin registrujAdminaForma = new formaRegAdmin();
            this.Hide();
            registrujAdminaForma.Show();
        }

        private void formaPocetak_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
