using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Diplomski
{
    public partial class formaRegAdmin : Form
    {
        Serializer serializer;
        Stream fs;
        List<Korisnik> korisnici;
        string putanja;
        public formaRegAdmin()
        {
            InitializeComponent();
            serializer = new Serializer();
            putanja = "korisnik.bin";
            if (!File.Exists(putanja))
            {
                fs = File.Open(putanja, FileMode.Create);
                fs.Close();
            }
            else
            {
                fs = File.OpenWrite(putanja);
            }
            korisnici = new List<Korisnik>();
        }
        string lozinka = "";
        private void btnRegAdmin_Click(object sender, EventArgs e)
        {/*Niz provera da li je korisnik uneo sve potrebne podatke*/
            string posao = "";
            if (tbIme.Text == "")
            {
                MessageBox.Show("Morate uneti ime!");
                return;
            }
            if (tbPrezime.Text == "")
            {
                MessageBox.Show("Morate uneti prezime!");
                return;
            }
            if (tbKorIme.Text == "")
            {
                MessageBox.Show("Morate uneti korisničko ime!");
                return;
            }
            if (tbLozinka.Text == "")
            {
                MessageBox.Show("Morate uneti ili generisati lozinku!");
                return;
            }
            if (cbPosao.SelectedItem == null)
            {
                MessageBox.Show("Morate izabrati posao!");
                return;
            }
            if (tbPlata.Text == "")
            {
                MessageBox.Show("Morate uneti platu!");
                return;
            }
            if (dtpDatumZaposlenja.Value.Date < DateTime.Today.AddDays(-3))
            {
                MessageBox.Show("Izabrali ste pogrešan datum za datum zaposlenja!");
                return;
            }
            if (dtpDatumIstekaUgovora.Value.Date < DateTime.Today.AddDays(-3))
            {
                MessageBox.Show("Izabrali ste pogrešan datum za datum isteka ugovora!");
                return;
            }
            if(dtpDatumZaposlenja.Value.CompareTo(dtpDatumIstekaUgovora.Value.Date) >= 0)
            {
                MessageBox.Show("Datum zaposlenja mora biti pre datuma isteka ugovora!");
                return;
            }
            if (dtpDatumIstekaUgovora.Value.Date.Year > dtpDatumZaposlenja.Value.Date.Year)
            {
                if ((dtpDatumIstekaUgovora.Value.Date.Month+12) - dtpDatumZaposlenja.Value.Date.Month < 3)
                {
                    MessageBox.Show("Izmedju dva datuma mora biti barem 3 meseca!");
                    return;
                }
            }
            else
            {
                if ((dtpDatumIstekaUgovora.Value.Date.Month - dtpDatumZaposlenja.Value.Date.Month) < 3)
                {
                    MessageBox.Show("Izmedju dva datuma mora biti barem 3 meseca!");
                    return;
                }
            }
            posao = cbPosao.SelectedItem.ToString();
            /*Kreiranje novog korisnika sa id=1 jer je prvi i snimanje istog u sistem*/
            Korisnik admin = new Korisnik(1, tbIme.Text, tbPrezime.Text, tbKorIme.Text, tbLozinka.Text, dtpDatumZaposlenja.Value, dtpDatumIstekaUgovora.Value, posao, float.Parse(tbPlata.Text));
            korisnici.Add(admin);
            serializer.Serialize(korisnici, fs);
            fs.Close();
            MessageBox.Show("Uspesno registrovanje!");
            formaPrijava loginForma = new formaPrijava();
            loginForma.Show();
            this.Dispose();
        }

        private void formaRegAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            formaPocetak formaPocetak = new formaPocetak();
            formaPocetak.Show();
            this.Dispose();
        }

        private void btnGenerisi_Click(object sender, EventArgs e)
        {
            lozinka = "";
            tbLozinka.Text = "";
            Random random = new Random();
            for (int i = 0; i < 4; i++)
            {
                int broj = random.Next(0, 26);
                char slovo = Char.ToLower(Convert.ToChar(broj + 65));
                lozinka += slovo;
            }
            for (int i = 0; i < 4; i++)
            {
                int broj = random.Next(0, 9);
                lozinka += broj.ToString();
            }
            tbLozinka.Text = lozinka;
        }
    }
}
