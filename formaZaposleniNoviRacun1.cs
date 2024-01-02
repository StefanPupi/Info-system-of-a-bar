using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Diplomski
{
    public partial class formaZaposleniNoviRacun1 : Form
    {
        List<Artikal> artikli;
        List<Artikal> izabrani;
        List<Racun> racuni;
        List<Artikal> filter;
        List<string> kriterijumi;
        Artikal izabran;
        Serializer serializer;
        Stream fs;
        int id;
        int idRacun = 1;
        int pristup;
        string putanja = "artikal.bin";
        public formaZaposleniNoviRacun1(int korisnik)
        {
            InitializeComponent();
            artikli = new List<Artikal>();
            izabrani = new List<Artikal>();
            filter = new List<Artikal>();
            kriterijumi = new List<string>();
            racuni = new List<Racun>();
            serializer = new Serializer();
            this.pristup = korisnik;
        }

        private void formaZaposleniNoviRacun_Load(object sender, EventArgs e)
        {
            OsveziArtikle();
        }

        private void OsveziArtikle()
        {
            artikli.Clear();
            if (File.Exists(putanja))
            {
                fs = File.OpenRead(putanja);
                if (fs.Length == 0)
                {
                    MessageBox.Show("Trenutno nemate artikle u bazi!");
                    fs.Close();
                    return;
                }
                artikli.Clear();
                artikli = serializer.DeserializeArtikal(fs);
                dgvArtikli.DataSource = artikli;
                foreach(DataGridViewColumn k in dgvArtikli.Columns)
                {
                    k.Visible = false;
                }
                dgvArtikli.Columns["id_artikal"].Visible = true;
                dgvArtikli.Columns["naziv"].Visible = true;
                dgvArtikli.Columns["kolicina"].Visible = true;
                dgvArtikli.Columns["cena"].Visible = true;
                dgvArtikli.Columns["barkod"].Visible = true;
            }
            else
            {
                fs = File.Open(putanja, FileMode.Create);
            }
            fs.Close();
        }



        private void dgvArtikli_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow red in dgvArtikli.SelectedRows)
            {
                id = int.Parse(red.Cells[0].Value.ToString());
            }

        }

        private void btnDodajProizvod_Click(object sender, EventArgs e)
        {
            foreach (Artikal a in artikli)
            {
                if (a.Id_artikal == id)
                {
                    izabran = a;
                    if (izabrani.Contains(izabran))
                    {
                        izabran.Kolicina += 1;
                    }
                    else
                    {
                        izabran.Kolicina = 1;
                        izabrani.Add(izabran);
                    }
                    break;
                }
            }
            dgvRacun.DataSource = null;
            dgvRacun.DataSource = izabrani;
            foreach (DataGridViewColumn k in dgvRacun.Columns)
            {
                k.Visible = false;
            }
            dgvRacun.Columns["naziv"].Visible = true;
            dgvRacun.Columns["kolicina"].Visible = true;
            dgvRacun.Columns["cena"].Visible = true;
            dgvRacun.Columns["barkod"].Visible = true;
        }

        private void btnDodajNovRacun_Click(object sender, EventArgs e)
        {
            float cena = 0;
            foreach (Artikal a in izabrani)
            {
                cena += a.Cena * a.Kolicina;
            }
            if (File.Exists("racun.bin"))
            {
                fs = File.OpenRead("racun.bin");
                if (fs.Length > 0)
                {
                    racuni = serializer.DeserializeRacun(fs);
                    fs.Close();
                }
                if (racuni.Count > 0)
                {
                    idRacun = racuni[racuni.Count - 1].Id_racun + 1;
                    fs.Close();
                }
                fs.Close();
            }
            else
            {
                fs = File.Open("racun.bin", FileMode.Create);
                fs.Close();
            }
            Racun r = new Racun(idRacun, pristup, DateTime.Now, cena, izabrani, false);
            racuni.Add(r);
            fs = File.OpenWrite("racun.bin");
            serializer.Serialize(racuni, fs);
            MessageBox.Show("Uspešno dodavanje novog računa!");
            fs.Close();
            btnOtkazi_Click(null, null);
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            formaZaposleniPregled1 zaposleniPregled = new formaZaposleniPregled1(pristup);
            zaposleniPregled.Show();
            this.Hide();
        }

        private void formaZaposleniNoviRacun_FormClosed(object sender, FormClosedEventArgs e)
        {
            formaZaposleniPregled1 zaposleniPregled = new formaZaposleniPregled1(pristup);
            zaposleniPregled.Show();
            this.Hide();
        }

        private void btnUkloniProizvod_Click(object sender, EventArgs e)
        {
            foreach (Artikal a in izabrani)
            {
                if (a.Id_artikal == id)
                {
                    izabrani.Remove(a);
                    break;
                }
            }
            dgvRacun.DataSource = null;
            dgvRacun.DataSource = izabrani;
        }

        private void dgvRacun_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow red in dgvArtikli.SelectedRows)
            {
                id = int.Parse(red.Cells[0].Value.ToString());
            }
        }

        private void cbSortiraj_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSortiraj.SelectedIndex == 0)
            {
                OsveziArtikle();
            }
            if (cbSortiraj.SelectedIndex == 1)
            {
                artikli.Sort((x, y) => x.Naziv.CompareTo(y.Naziv));
                dgvArtikli.DataSource = null;
                dgvArtikli.DataSource = artikli;
                return;
            }
            if (cbSortiraj.SelectedIndex == 2)
            {
                artikli.Sort((x, y) => y.Naziv.CompareTo(x.Naziv));
                dgvArtikli.DataSource = null;
                dgvArtikli.DataSource = artikli;
                return;
            }
            if (cbSortiraj.SelectedIndex == 3)
            {
                artikli.Sort((x, y) => x.Kolicina.CompareTo(y.Kolicina));
                dgvArtikli.DataSource = null;
                dgvArtikli.DataSource = artikli;
                return;
            }
            if (cbSortiraj.SelectedIndex == 4)
            {
                artikli.Sort((x, y) => y.Kolicina.CompareTo(x.Kolicina));
                dgvArtikli.DataSource = null;
                dgvArtikli.DataSource = artikli;
                return;
            }
            if (cbSortiraj.SelectedIndex == 5)
            {
                artikli.Sort((x, y) => x.Cena.CompareTo(y.Cena));
                dgvArtikli.DataSource = null;
                dgvArtikli.DataSource = artikli;
                return;
            }
            if (cbSortiraj.SelectedIndex == 6)
            {
                artikli.Sort((x, y) => y.Cena.CompareTo(x.Cena));
                dgvArtikli.DataSource = null;
                dgvArtikli.DataSource = artikli;
                return;
            }
            if (cbSortiraj.SelectedIndex == 7)
            {
                artikli.Sort((x, y) => x.Jedinica_prodaje.CompareTo(y.Jedinica_prodaje));
                dgvArtikli.DataSource = null;
                dgvArtikli.DataSource = artikli;
                return;
            }
            if (cbSortiraj.SelectedIndex == 8)
            {
                artikli.Sort((x, y) => y.Jedinica_prodaje.CompareTo(x.Jedinica_prodaje));
                dgvArtikli.DataSource = null;
                dgvArtikli.DataSource = artikli;
                return;
            }
            if (cbSortiraj.SelectedIndex == 9)
            {
                artikli.Sort((x, y) => x.Kategorija.CompareTo(y.Kategorija));
                dgvArtikli.DataSource = null;
                dgvArtikli.DataSource = artikli;
                return;
            }
        }

        private void cbKategorija_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            if (cb.Checked)
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

        private void cbSve_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSve.Checked)
            {
                kriterijumi.Clear();
                kriterijumi.Add(cbSve.Text);
                cbId.Checked = false;
                cbNaziv.Checked = false;
                cbKolicina.Checked = false;
                cbMinimalnaKolicina.Checked = false;
                cbCena.Checked = false;
                cbBarkod.Checked = false;
                cbJedinica.Checked = false;
                cbKategorija.Checked = false;
            }
        }

        private void tbPretraga_TextChanged(object sender, EventArgs e)
        {
            if (tbPretraga.Text == "")
            {
                OsveziArtikle();
            }
            else
            {
                Pretrazi();
            }
        }

        private void btnPretraga_Click(object sender, EventArgs e)
        {
            Pretrazi();
        }

        private void Pretrazi()
        {
            string pretraga = tbPretraga.Text;
            filter.Clear();
            dgvArtikli.DataSource = null;
            if (kriterijumi.Contains(cbSve.Text))
            {
                foreach (Artikal a in artikli)
                {
                    if (a.Id_artikal.ToString().ToLower().Contains(pretraga.ToLower()))
                    {
                        filter.Add(a);
                        continue;
                    }
                    if (a.Naziv.ToString().ToLower().Contains(pretraga.ToLower()))
                    {
                        filter.Add(a);
                        continue;
                    }
                    if (a.Kolicina.ToString().ToLower().Contains(pretraga.ToLower()))
                    {
                        filter.Add(a);
                        continue;
                    }
                    if (a.Minimalna_kolicina.ToString().ToLower().Contains(pretraga.ToLower()))
                    {
                        filter.Add(a);
                        continue;
                    }
                    if (a.Cena.ToString().ToLower().Contains(pretraga.ToLower()))
                    {
                        filter.Add(a);
                        continue;
                    }
                    if (a.Barkod.ToString().ToLower().Contains(pretraga.ToLower()))
                    {
                        filter.Add(a);
                        continue;
                    }
                    if (a.Jedinica_prodaje.ToString().ToLower().Contains(pretraga.ToLower()))
                    {
                        filter.Add(a);
                        continue;
                    }
                    if (a.Kategorija.ToString().ToLower().Contains(pretraga.ToLower()))
                    {
                        filter.Add(a);
                        continue;
                    }
                }
            }
            else
            {
                if (kriterijumi.Contains(cbId.Text))
                {
                    foreach (Artikal a in artikli)
                    {
                        if (a.Id_artikal.ToString().ToLower().Contains(pretraga.ToLower()) && !filter.Contains(a))
                        {
                            filter.Add(a);
                            continue;
                        }
                    }
                }
                if (kriterijumi.Contains(cbNaziv.Text))
                {
                    foreach (Artikal a in artikli)
                    {
                        if (a.Naziv.ToString().ToLower().Contains(pretraga.ToLower()) && !filter.Contains(a))
                        {
                            filter.Add(a);
                            continue;
                        }
                    }
                }
                if (kriterijumi.Contains(cbKolicina.Text))
                {
                    foreach (Artikal a in artikli)
                    {
                        if (a.Kolicina.ToString().ToLower().Contains(pretraga.ToLower()) && !filter.Contains(a))
                        {
                            filter.Add(a);
                            continue;
                        }
                    }
                }
                if (kriterijumi.Contains(cbMinimalnaKolicina.Text))
                {
                    foreach (Artikal a in artikli)
                    {
                        if (a.Minimalna_kolicina.ToString().ToLower().Contains(pretraga.ToLower()) && !filter.Contains(a))
                        {
                            filter.Add(a);
                            continue;
                        }
                    }
                }
                if (kriterijumi.Contains(cbCena.Text))
                {
                    foreach (Artikal a in artikli)
                    {
                        if (a.Cena.ToString().ToLower().Contains(pretraga.ToLower()) && !filter.Contains(a))
                        {
                            filter.Add(a);
                            continue;
                        }
                    }
                }
                if (kriterijumi.Contains(cbBarkod.Text))
                {
                    foreach (Artikal a in artikli)
                    {
                        if (a.Barkod.ToString().ToLower().Contains(pretraga.ToLower()) && !filter.Contains(a))
                        {
                            filter.Add(a);
                            continue;
                        }
                    }
                }
                if (kriterijumi.Contains(cbJedinica.Text))
                {
                    foreach (Artikal a in artikli)
                    {
                        if (a.Jedinica_prodaje.ToString().ToLower().Contains(pretraga.ToLower()) && !filter.Contains(a))
                        {
                            filter.Add(a);
                            continue;
                        }
                    }
                }
                if (kriterijumi.Contains(cbKategorija.Text))
                {
                    foreach (Artikal a in artikli)
                    {
                        if (a.Kategorija.ToString().ToLower().Contains(pretraga.ToLower()) && !filter.Contains(a))
                        {
                            filter.Add(a);
                            continue;
                        }
                    }
                }
            }
            dgvArtikli.DataSource = filter;
        }
    }
}
