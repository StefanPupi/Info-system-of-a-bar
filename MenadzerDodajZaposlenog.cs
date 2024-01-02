using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Diplomski
{
    public partial class formaMenadzerDodajZaposlenog : Form
    {
        Serializer serializer;
        Stream fs;
        List<Korisnik> korisnici;
        string putanja = "korisnik.bin";
        public formaMenadzerDodajZaposlenog()
        {
            InitializeComponent();
            serializer = new Serializer();
            korisnici = new List<Korisnik>();
        }

        string lozinka = "";
        private void btnDodajZaposlenog_Click(object sender, EventArgs e)
        {
            fs = File.OpenRead(putanja);
            if (fs.Length == 0)
            {
                MessageBox.Show("Trenutno nemate registrovanih korisnika!");
                fs.Close();
                return;
            }
            korisnici = serializer.DeserializeKorisnik(fs);
            fs.Close();
            int id = 1;
            if (korisnici.Count != 0)
            {
                id = korisnici[korisnici.Count - 1].Id_korisnika + 1;
            }
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
            if (dtpDatumZaposlenja.Value.CompareTo(dtpDatumIstekaUgovora.Value.Date) >= 0)
            {
                MessageBox.Show("Datum zaposlenja mora biti pre datuma isteka ugovora!");
                return;
            }
            if (dtpDatumIstekaUgovora.Value.Date.Year > dtpDatumZaposlenja.Value.Date.Year)
            {
                if ((dtpDatumIstekaUgovora.Value.Date.Month + 12) - dtpDatumZaposlenja.Value.Date.Month < 3)
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
            Korisnik kor = new Korisnik(id, tbIme.Text, tbPrezime.Text, tbKorIme.Text, tbLozinka.Text, dtpDatumZaposlenja.Value, dtpDatumIstekaUgovora.Value, posao, float.Parse(tbPlata.Text));
            korisnici.Add(kor);
            fs = File.OpenWrite(putanja);
            serializer.Serialize(korisnici, fs);
            fs.Close();
            MessageBox.Show("Uspesno dodavanje korisnika!");
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

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            formaMenadzerPregled menadzerPregled = new formaMenadzerPregled();
            menadzerPregled.Show();
            this.Hide();
        }

        private void formaMenadzerDodajZaposlenog_FormClosed(object sender, FormClosedEventArgs e)
        {
            formaMenadzerPregled menadzerPregled = new formaMenadzerPregled();
            menadzerPregled.Show();
            this.Hide();
        }
    }
}
