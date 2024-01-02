using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Diplomski
{
    public partial class formaAdminUrediKorisnika : Form
    {
        List<Korisnik> korisnici;
        List<Korisnik> filter;
        Serializer serializer;
        List<string> kriterijumi;
        Stream fs;
        string putanja = "korisnik.bin";
        public formaAdminUrediKorisnika()
        {
            InitializeComponent();
            korisnici = new List<Korisnik>();
            filter = new List<Korisnik>();
            serializer = new Serializer();
            kriterijumi = new List<string>();
        }

        private void formaAdminUrediKorisnika_FormClosed(object sender, FormClosedEventArgs e)
        {
            formaAdminPregled adminPregled = new formaAdminPregled();
            adminPregled.Show();
            this.Hide();
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            formaAdminPregled adminPregled = new formaAdminPregled();
            adminPregled.Show();
            this.Hide();
        }

        private void formaAdminUrediKorisnika_Load(object sender, EventArgs e)
        {
            OsveziListu();
            dgvKorisnici.DataSource = korisnici;
            cbSve.Checked = true;
        }
        int id;
        private void dgvKorisnici_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow red in dgvKorisnici.SelectedRows)
            {
                id = int.Parse(red.Cells[0].Value.ToString());
                tbIme.Text = red.Cells[1].Value.ToString();
                tbPrezime.Text = red.Cells[2].Value.ToString();
                tbKorIme.Text = red.Cells[3].Value.ToString();
                tbLozinka.Text = red.Cells[4].Value.ToString();
                dtpDatumZaposlenja.Value = DateTime.Parse(red.Cells[5].Value.ToString());
                dtpDatumIstekaUgovora.Value = DateTime.Parse(red.Cells[6].Value.ToString());
                if (red.Cells[7].Value.ToString() == "Administrator")
                {
                    cbPosao.SelectedIndex = 0;
                }
                if (red.Cells[7].Value.ToString() == "Menadzer")
                {
                    cbPosao.SelectedIndex = 1;
                }
                if (red.Cells[7].Value.ToString() == "Zaposleni")
                {
                    cbPosao.SelectedIndex = 2;
                }
                tbPlata.Text = red.Cells[8].Value.ToString();
            }
        }

        private void btnUrediKorisnika_Click(object sender, EventArgs e)
        {
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
            Korisnik k = new Korisnik(id, tbIme.Text, tbPrezime.Text, tbKorIme.Text, tbLozinka.Text, dtpDatumZaposlenja.Value, dtpDatumIstekaUgovora.Value, posao, float.Parse(tbPlata.Text));
            foreach (Korisnik ko in korisnici)
            {
                if (ko.Id_korisnika == k.Id_korisnika)
                {
                    if (k.Datum_zaposlenja < ko.Datum_zaposlenja || k.Datum_isteka_ugovora < ko.Datum_isteka_ugovora)
                    {
                        MessageBox.Show("Proverite datum zaposlenja i datum isteka ugovora!");
                        return;
                    }
                    ko.Id_korisnika = k.Id_korisnika;
                    ko.Ime = k.Ime;
                    ko.Prezime = k.Prezime;
                    ko.Korisnicko_ime = k.Korisnicko_ime;
                    ko.Lozinka = k.Lozinka;
                    ko.Datum_zaposlenja = k.Datum_zaposlenja;
                    ko.Datum_isteka_ugovora = k.Datum_isteka_ugovora;
                    ko.Posao = k.Posao;
                    ko.Plata = k.Plata;
                    break;
                }
            }
            fs = File.OpenWrite(putanja);
            serializer.Serialize(korisnici, fs);
            MessageBox.Show("Uspesna uređivanja korisnika!");
            fs.Close();
            OsveziListu();
            btnOtkazi_Click(null, null);
        }

        public void OsveziListu()
        {
            fs = File.OpenRead(putanja);
            if(fs.Length == 0)
            {
                MessageBox.Show("Trenutno nemate registrovanih korisnika!");
                return;
            }
            korisnici.Clear();
            korisnici = serializer.DeserializeKorisnik(fs);
            dgvKorisnici.DataSource = korisnici;
            fs.Close();
        }

        private void btnPretraga_Click(object sender, EventArgs e)
        {
            Pretrazi();
        }

        private void btnPretraga_TextChanged(object sender, EventArgs e)
        {
            if (tbPretraga.Text == "")
            {
                dgvKorisnici.DataSource = korisnici;
            }
        }

        private void Pretrazi()
        {
            string pretraga = tbPretraga.Text;
            filter.Clear();
            dgvKorisnici.DataSource = null;
            if (kriterijumi.Contains(cbSve.Text))
            {
                foreach (Korisnik k in korisnici)
                {
                    if (k.Id_korisnika.ToString() == pretraga)
                    {
                        filter.Add(k);
                        continue;
                    }
                    if (k.Ime.ToLower().Contains(pretraga.ToLower()))
                    {
                        filter.Add(k);
                        continue;
                    }
                    if (k.Prezime.ToLower().Contains(pretraga.ToLower()))
                    {
                        filter.Add(k);
                        continue;
                    }
                    if (k.Korisnicko_ime.ToLower().Contains(pretraga.ToLower()))
                    {
                        filter.Add(k);
                        continue;
                    }
                    if (k.Lozinka.ToLower().Contains(pretraga.ToLower()))
                    {
                        filter.Add(k);
                        continue;
                    }
                    if (k.Posao.ToLower().Contains(pretraga.ToLower()))
                    {
                        filter.Add(k);
                        continue;
                    }
                    if (k.Plata.ToString().ToLower().Contains(pretraga.ToLower()))
                    {
                        filter.Add(k);
                        continue;
                    }
                }
            }
            else
            {
                if (kriterijumi.Contains(cbId.Text))
                {
                    foreach (Korisnik k in korisnici)
                    {
                        if (k.Id_korisnika.ToString() == pretraga && !filter.Contains(k))
                        {
                            filter.Add(k);
                        }
                    }
                }
                if (kriterijumi.Contains(cbIme.Text))
                {
                    foreach (Korisnik k in korisnici)
                    {
                        if (k.Ime.ToLower().Contains(pretraga.ToLower()) && !filter.Contains(k))
                        {
                            filter.Add(k);
                        }
                    }
                }
                if (kriterijumi.Contains(cbPrezime.Text))
                {
                    foreach (Korisnik k in korisnici)
                    {
                        if (k.Prezime.ToLower().Contains(pretraga.ToLower()) && !filter.Contains(k))
                        {
                            filter.Add(k);
                        }
                    }
                }
                if (kriterijumi.Contains(cbKorisnickoIme.Text))
                {
                    foreach (Korisnik k in korisnici)
                    {
                        if (k.Korisnicko_ime.ToLower().Contains(pretraga.ToLower()) && !filter.Contains(k))
                        {
                            filter.Add(k);
                        }
                    }
                }
                if (kriterijumi.Contains(cbLozinka.Text))
                {
                    foreach (Korisnik k in korisnici)
                    {
                        if (k.Lozinka.ToLower().Contains(pretraga.ToLower()) && !filter.Contains(k))
                        {
                            filter.Add(k);
                        }
                    }
                }
                if (kriterijumi.Contains(chbPosao.Text))
                {
                    foreach (Korisnik k in korisnici)
                    {
                        if (k.Posao.ToLower().Contains(pretraga.ToLower()) && !filter.Contains(k))
                        {
                            filter.Add(k);
                        }
                    }
                }
                if (kriterijumi.Contains(cbPlata.Text))
                {
                    foreach (Korisnik k in korisnici)
                    {
                        if (k.Plata.ToString().ToLower().Contains(pretraga.ToLower()) && !filter.Contains(k))
                        {
                            filter.Add(k);
                        }
                    }
                }
                if (dtpDatumZaposljavanja.Enabled)
                {
                    foreach (Korisnik k in korisnici)
                    {
                        if (k.Datum_zaposlenja.Date == dtpDatumZaposljavanja.Value.Date && !filter.Contains(k))
                        {
                            filter.Add(k);
                        }
                    }
                }
                if (dtpDatumIstekaUgovora.Enabled)
                {
                    foreach (Korisnik k in korisnici)
                    {
                        if (k.Datum_isteka_ugovora.Date == dtpDatumIstekaUgovora.Value.Date && !filter.Contains(k))
                        {
                            filter.Add(k);
                        }
                    }
                }
            }
            dgvKorisnici.DataSource = filter;
        }

        private void cbSve_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSve.Checked == true)
            {
                kriterijumi.Clear();
                kriterijumi.Add(cbSve.Text);
                cbId.Checked = false;
                cbIme.Checked = false;
                cbPrezime.Checked = false;
                cbKorisnickoIme.Checked = false;
                cbLozinka.Checked = false;
                chbPosao.Checked = false;
                cbPlata.Checked = false;
                cbDatumZaposljenja.Checked = false;
                cbDatumIstekaUgovora.Checked = false;
            }
        }

        private void cbId_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            if (cb.Checked == true)
            {
                cbSve.Checked = false;
                kriterijumi.Remove(cbSve.Text);
                kriterijumi.Add(cb.Text);
            }
            else
            {
                kriterijumi.Remove(cb.Text);
            }
        }

        private void cbSortiraj_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSortiraj.SelectedIndex == 0)
            {
                OsveziListu();
            }
            if (cbSortiraj.SelectedIndex == 1)
            {
                korisnici.Sort((x, y) => x.Ime.CompareTo(y.Ime));
                dgvKorisnici.DataSource = null;
                dgvKorisnici.DataSource = korisnici;
            }
            if (cbSortiraj.SelectedIndex == 2)
            {
                korisnici.Sort((x, y) => y.Ime.CompareTo(x.Ime));
                dgvKorisnici.DataSource = null;
                dgvKorisnici.DataSource = korisnici;
            }
            if (cbSortiraj.SelectedIndex == 3)
            {
                korisnici.Sort((x, y) => x.Prezime.CompareTo(y.Prezime));
                dgvKorisnici.DataSource = null;
                dgvKorisnici.DataSource = korisnici;
            }
            if (cbSortiraj.SelectedIndex == 4)
            {
                korisnici.Sort((x, y) => y.Prezime.CompareTo(x.Prezime));
                dgvKorisnici.DataSource = null;
                dgvKorisnici.DataSource = korisnici;
            }
            if (cbSortiraj.SelectedIndex == 5)
            {
                korisnici.Sort((x, y) => x.Korisnicko_ime.CompareTo(y.Korisnicko_ime));
                dgvKorisnici.DataSource = null;
                dgvKorisnici.DataSource = korisnici;

            }
            if (cbSortiraj.SelectedIndex == 6)
            {
                korisnici.Sort((x, y) => y.Korisnicko_ime.CompareTo(x.Korisnicko_ime));
                dgvKorisnici.DataSource = null;
                dgvKorisnici.DataSource = korisnici;
            }
            if (cbSortiraj.SelectedIndex == 7)
            {
                korisnici.Sort((x, y) => x.Plata.CompareTo(y.Plata));
                dgvKorisnici.DataSource = null;
                dgvKorisnici.DataSource = korisnici;
            }
            if (cbSortiraj.SelectedIndex == 8)
            {
                korisnici.Sort((x, y) => y.Plata.CompareTo(x.Plata));
                dgvKorisnici.DataSource = null;
                dgvKorisnici.DataSource = korisnici;
            }
            if (cbSortiraj.SelectedIndex == 9)
            {
                korisnici.Sort((x, y) => x.Datum_zaposlenja.CompareTo(y.Datum_zaposlenja));
                dgvKorisnici.DataSource = null;
                dgvKorisnici.DataSource = korisnici;
            }
            if (cbSortiraj.SelectedIndex == 10)
            {
                korisnici.Sort((x, y) => y.Datum_zaposlenja.CompareTo(x.Datum_zaposlenja));
                dgvKorisnici.DataSource = null;
                dgvKorisnici.DataSource = korisnici;
            }
            if (cbSortiraj.SelectedIndex == 11)
            {
                korisnici.Sort((x, y) => x.Datum_isteka_ugovora.CompareTo(y.Datum_isteka_ugovora));
                dgvKorisnici.DataSource = null;
                dgvKorisnici.DataSource = korisnici;
            }
            if (cbSortiraj.SelectedIndex == 12)
            {
                korisnici.Sort((x, y) => y.Datum_isteka_ugovora.CompareTo(x.Datum_isteka_ugovora));
                dgvKorisnici.DataSource = null;
                dgvKorisnici.DataSource = korisnici;
            }
        }

        private void cbDatumZaposljenja_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            if (cb.Checked == true)
            {
                cbSve.Checked = false;
                kriterijumi.Remove(cbSve.Text);
                kriterijumi.Add(cb.Text);
                dtpDatumZaposljavanja.Enabled = true;
            }
            else
            {
                dtpDatumZaposljavanja.Enabled = false;
                cbSve.Checked = true;
                dgvKorisnici.DataSource = korisnici;
            }
        }

        private void cbDatumIstekaUgovora_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            if (cb.Checked == true)
            {
                cbSve.Checked = false;
                kriterijumi.Remove(cbSve.Text);
                kriterijumi.Add(cb.Text);
                dtpDatumIstekaUgovora.Enabled = true;
            }
            else
            {
                dtpDatumIstekaUgovora.Enabled = false;
                cbSve.Checked = true;
                dgvKorisnici.DataSource = korisnici;
            }
        }

        private void tbPretraga_TextChanged(object sender, EventArgs e)
        {
            if (tbPretraga.Text == "")
            {
                dgvKorisnici.DataSource = korisnici;
            }
            else
            {
                Pretrazi();
            }
        }
    }
}

