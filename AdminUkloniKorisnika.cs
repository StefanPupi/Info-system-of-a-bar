using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Diplomski
{
    public partial class formaAdminUkloniKorisnika : Form
    {
        int id;
        List<Korisnik> korisnici;
        List<Korisnik> filter;
        List<string> kriterijumi;
        Serializer serializer;
        Stream fs;
        string putanja = "korisnik.bin";
        public formaAdminUkloniKorisnika()
        {
            InitializeComponent();
            korisnici = new List<Korisnik>();
            filter = new List<Korisnik>();
            serializer = new Serializer();
            kriterijumi = new List<string>();
        }

        private void formaAdminUkloniKorisnika_FormClosed(object sender, FormClosedEventArgs e)
        {
            formaAdminPregled adminPregled = new formaAdminPregled();
            adminPregled.Show();
            this.Hide();
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            foreach(Korisnik k in korisnici)
            {
                if(k.Posao == "Administrator")
                {
                    formaAdminPregled adminPregled = new formaAdminPregled();
                    adminPregled.Show();
                    this.Hide();
                    return;
                }
            }
            formaPocetak formaPocetak = new formaPocetak();
            formaPocetak.Show();
            this.Dispose();
        }

        private void dgvKorisnici_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow red in dgvKorisnici.SelectedRows)
            {
                id = int.Parse(red.Cells[0].Value.ToString());
            }
        }

        private void btnUkloniKorisnika_Click(object sender, EventArgs e)
        {
            foreach (Korisnik k in korisnici)
            {
                if (k.Id_korisnika == id)
                {
                    korisnici.Remove(k);
                    break;
                }
            }
            fs = File.OpenWrite(putanja);
            serializer.Serialize(korisnici, fs);
            fs.Close();
            OsveziListu();
            MessageBox.Show("Uspesno ste uklonili korisnika!");
            btnOtkazi_Click(null, null);
        }

        private void formaAdminUkloniKorisnika_Load(object sender, EventArgs e)
        {
            OsveziListu();
            cbSve.Checked = true;
        }

        private void btnPretraga_Click(object sender, EventArgs e)
        {
            Pretrazi();
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

        public void OsveziListu()
        {
            fs = File.OpenRead(putanja);
            if (fs.Length == 0)
            {
                MessageBox.Show("Trenutno nemate registrovanih korisnika!");
                fs.Close();
                return;
            }
            korisnici.Clear();
            korisnici = serializer.DeserializeKorisnik(fs);
            dgvKorisnici.DataSource = korisnici;
            fs.Close();
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
    }
}
