using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Diplomski
{
    public partial class formaZaposleniUrediRacun : Form
    {
        int pristup;
        List<Racun> racuni;
        List<Artikal> artikli;
        List<Artikal> izabrani;
        List<Artikal> filter;
        List<string> kriterijumi;
        Artikal izabran;
        Serializer serializer;
        Stream fs;
        List<int> idArtikla;
        int id;
        int idNovi;
        float cena;
        string putanjaRacun = "racun.bin";
        string putanjaArtikal = "artikal.bin";
        public formaZaposleniUrediRacun(int korisnik, int idRacuna)
        {
            InitializeComponent();
            racuni = new List<Racun>();
            artikli = new List<Artikal>();
            izabrani = new List<Artikal>();
            filter = new List<Artikal>();
            kriterijumi = new List<string>();
            idArtikla = new List<int>();
            serializer = new Serializer();
            this.pristup = korisnik;
            this.id = idRacuna;
        }

        private void formaZaposleniUrediRacun_Load(object sender, EventArgs e)
        {
            OsveziRacune();
            OsveziArtikle();
        }

        private void OsveziRacune()
        {
            racuni.Clear();
            if (File.Exists(putanjaRacun))
            {
                fs = File.OpenRead(putanjaRacun);
                if(fs.Length == 0)
                {
                    MessageBox.Show("Trenutno nemate aktivnih racuna!");
                    fs.Close();
                    return;
                }
                racuni.Clear();
                racuni = serializer.DeserializeRacun(fs);
                dgvArtikli.DataSource = racuni;
            }
            else
            {
                fs = File.Open(putanjaRacun, FileMode.Create);
                MessageBox.Show("Trenutno nemate aktivnih racuna!");
                fs.Close();
                return;
            }

            foreach(Racun r in racuni)
            {
                if(id == r.Id_racun)
                {
                    dgvRacun.DataSource = r.Artikli;
                    izabrani = r.Artikli;
                    break;
                }
            }
        }

        private void OsveziArtikle()
        {
            artikli.Clear();
            if (File.Exists(putanjaArtikal))
            {
                fs = File.OpenRead(putanjaArtikal);
                if (fs.Length == 0)
                {
                    MessageBox.Show("Trenutno nemate zavedene artikle!");
                    fs.Close();
                    return;
                }
                artikli.Clear();
                artikli = serializer.DeserializeArtikal(fs);
                dgvArtikli.DataSource = artikli;
            }
            else
            {
                fs = File.Open(putanjaArtikal, FileMode.Create);
                MessageBox.Show("Trenutno nemate zavedene artikle!");
            }
            fs.Close();
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            formaZaposleniPregled1 zaposleniPregled = new formaZaposleniPregled1(pristup);
            zaposleniPregled.Show();
            this.Hide();
        }

        private void formaZaposleniUrediRacun_FormClosed(object sender, FormClosedEventArgs e)
        {
            formaZaposleniPregled1 zaposleniPregled = new formaZaposleniPregled1(pristup);
            zaposleniPregled.Show();
            this.Hide();
        }

        private void btnDodajProizvod_Click(object sender, EventArgs e)
        {
            foreach (Artikal a in artikli)
            {
                if (a.Id_artikal == idNovi)
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
        }

        private void dgvArtikli_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow red in dgvArtikli.SelectedRows)
            {
                idNovi = int.Parse(red.Cells[0].Value.ToString());
            }
        }

        private void btnUkloniProizvod_Click(object sender, EventArgs e)
        {
            foreach (Artikal a in izabrani)
            {
                if (a.Id_artikal == idNovi)
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
                idNovi = int.Parse(red.Cells[0].Value.ToString());
            }
        }

        private void btnUrediRacun_Click(object sender, EventArgs e)
        {
            float cena = 0;
            foreach (Racun r in racuni)
            {
                if (r.Id_racun == id)
                {
                    List<Artikal> ar = new List<Artikal>();
                    foreach (Artikal a in izabrani)
                    {
                        ar.Add(a);
                    }
                    r.Artikli.Clear();
                    foreach(Artikal art in ar)
                    {
                        r.Artikli.Add(art);
                    }
                    foreach (Artikal a1 in r.Artikli)
                    {
                        cena += a1.Cena*a1.Kolicina;
                    }

                    r.Iznos_racuna = cena;
                }
            }

            fs = File.OpenWrite(putanjaRacun);
            serializer.Serialize(racuni, fs);
            MessageBox.Show("Uspesno uredjivanje racuna!");
            fs.Close();
            btnOtkazi_Click(null, null);
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
