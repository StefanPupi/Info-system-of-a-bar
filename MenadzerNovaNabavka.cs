using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Diplomski
{
    public partial class formaMenadzerNovaNabavka : Form
    {
        int idkorisnik;
        int idArtikla;
        int idSelektovanog;
        string putanjaArtikal = "artikal.bin";
        string putanjaNabavka = "nabavka.bin";
        List<Artikal> artikli;
        List<Artikal> izabrani;
        List<Nabavka> nabavke;
        List<Artikal> filter;
        List<string> kriterijumi;
        List<Nabavka> neisporucene;
        Serializer serializer;
        Stream fs;
        public formaMenadzerNovaNabavka(int idKorisnik)
        {
            InitializeComponent();
            idkorisnik = idKorisnik;
            artikli = new List<Artikal>();
            izabrani = new List<Artikal>();
            nabavke = new List<Nabavka>();
            neisporucene = new List<Nabavka>();
            filter = new List<Artikal>();
            kriterijumi = new List<string>();
            serializer = new Serializer();
        }

        private void formaMenadzerNovaNabavka_Load(object sender, EventArgs e)
        {
            OsveziNabavke();
            OsveziArtikle();
            ProveriArtikle();
            cbSve.Checked = true;
        }

        private void OsveziNabavke()
        {
            if (File.Exists(putanjaNabavka))
            {
                fs = File.OpenRead(putanjaNabavka);
                if (fs.Length == 0)
                {
                    MessageBox.Show("Trenutno nemate zavedene nabavke!");
                    fs.Close();
                    return;
                }
                nabavke = serializer.DeserializeNabavka(fs);
                fs.Close();
            }
            else
            {
                fs = File.Open(putanjaNabavka, FileMode.Create);
                MessageBox.Show("Trenutno nemate zavedene nabavke!");
                fs.Close();
            }
        }

        private void OsveziArtikle()
        {
            if (File.Exists(putanjaArtikal))
            {
                fs = File.OpenRead(putanjaArtikal);
                if (fs.Length == 0)
                {
                    MessageBox.Show("Trenutno nemate artikle!");
                    return;
                }
                artikli = serializer.DeserializeArtikal(fs);
                fs.Close();
            }
            else
            {
                fs = File.Open(putanjaArtikal, FileMode.Create);
                MessageBox.Show("Trenutno nemate artikle!");
                fs.Close();
            }
            dgvProizvodi.DataSource = artikli;
        }

        private void ProveriArtikle()
        {
            foreach (Artikal a in artikli)
            {
                if (a.Kolicina <= a.Minimalna_kolicina)
                {
                    izabrani.Add(a);
                }
            }
            dgvNabavka.DataSource = izabrani;
        }

        private void dgvProizvodi_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow red in dgvProizvodi.Rows)
            {
                idArtikla = int.Parse(red.Cells[0].Value.ToString());
            }
        }

        private void dgvNabavka_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow red in dgvNabavka.Rows)
            {
                idSelektovanog = int.Parse(red.Cells[0].Value.ToString());
            }
        }
        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            formaMenadzerPregled formaMenadzerPregled = new formaMenadzerPregled();
            formaMenadzerPregled.Show();
            this.Hide();
        }

        private void formaMenadzerNovaNabavka_FormClosed(object sender, FormClosedEventArgs e)
        {
            formaMenadzerPregled formaMenadzerPregled = new formaMenadzerPregled();
            formaMenadzerPregled.Show();
            this.Hide();
        }

        private void btnDodajProizvod_Click(object sender, EventArgs e)
        {
            foreach (Artikal a in artikli)
            {
                if (a.Id_artikal == idArtikla)
                {
                    Artikal a1 = a;
                    if (tbKolicina.Text != "" && int.TryParse(tbKolicina.Text, out int kolicina))
                    {
                        a1.Kolicina = kolicina;
                        izabrani.Add(a1);
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Morate uneti kolicinu!");
                        break;
                    }
                }
            }
            dgvNabavka.DataSource = null;
            dgvNabavka.DataSource = izabrani;
        }

        private void btnUkloniProizvod_Click(object sender, EventArgs e)
        {
            foreach (Artikal a in izabrani)
            {
                if (a.Id_artikal == idArtikla)
                {
                    izabrani.Remove(a);
                    break;
                }
            }
            dgvNabavka.DataSource = null;
            dgvNabavka.DataSource = izabrani;
        }

        private void btnDodajNovuNabavku_Click(object sender, EventArgs e)
        {
            fs = File.OpenWrite(putanjaNabavka);
            Nabavka n;
            float iznos = 0;
            foreach (Artikal a in izabrani)
            {
                iznos = a.Kolicina * a.Cena * 6 / 10;
            }
            if (nabavke.Count != 0)
            {
                n = new Nabavka(nabavke[nabavke.Count - 1].Id_nabavka, idkorisnik, DateTime.Now, DateTime.Now.AddDays(1), iznos, izabrani, false);
            }
            else
            {
                n = new Nabavka(1, idkorisnik, DateTime.Now, DateTime.Now.AddDays(1), iznos, izabrani, false);
            }
            nabavke.Add(n);
            serializer.Serialize(nabavke, fs);
            MessageBox.Show("Nabavka uspesno snimljena!");
            fs.Close();
            OsveziNabavke();
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
                dgvProizvodi.DataSource = null;
                dgvProizvodi.DataSource = artikli;
                return;
            }
            if (cbSortiraj.SelectedIndex == 2)
            {
                artikli.Sort((x, y) => y.Naziv.CompareTo(x.Naziv));
                dgvProizvodi.DataSource = null;
                dgvProizvodi.DataSource = artikli;
                return;
            }
            if (cbSortiraj.SelectedIndex == 3)
            {
                artikli.Sort((x, y) => x.Kolicina.CompareTo(y.Kolicina));
                dgvProizvodi.DataSource = null;
                dgvProizvodi.DataSource = artikli;
                return;
            }
            if (cbSortiraj.SelectedIndex == 4)
            {
                artikli.Sort((x, y) => y.Kolicina.CompareTo(x.Kolicina));
                dgvProizvodi.DataSource = null;
                dgvProizvodi.DataSource = artikli;
                return;
            }
            if (cbSortiraj.SelectedIndex == 5)
            {
                artikli.Sort((x, y) => x.Cena.CompareTo(y.Cena));
                dgvProizvodi.DataSource = null;
                dgvProizvodi.DataSource = artikli;
                return;
            }
            if (cbSortiraj.SelectedIndex == 6)
            {
                artikli.Sort((x, y) => y.Cena.CompareTo(x.Cena));
                dgvProizvodi.DataSource = null;
                dgvProizvodi.DataSource = artikli;
                return;
            }
            if (cbSortiraj.SelectedIndex == 7)
            {
                artikli.Sort((x, y) => x.Jedinica_prodaje.CompareTo(y.Jedinica_prodaje));
                dgvProizvodi.DataSource = null;
                dgvProizvodi.DataSource = artikli;
                return;
            }
            if (cbSortiraj.SelectedIndex == 8)
            {
                artikli.Sort((x, y) => y.Jedinica_prodaje.CompareTo(x.Jedinica_prodaje));
                dgvProizvodi.DataSource = null;
                dgvProizvodi.DataSource = artikli;
                return;
            }
            if (cbSortiraj.SelectedIndex == 9)
            {
                artikli.Sort((x, y) => x.Kategorija.CompareTo(y.Kategorija));
                dgvProizvodi.DataSource = null;
                dgvProizvodi.DataSource = artikli;
                return;
            }
        }

        private void chbKategorija_CheckedChanged(object sender, EventArgs e)
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
                chbKategorija.Checked = false;
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
            dgvProizvodi.DataSource = null;
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
                if (kriterijumi.Contains(chbKategorija.Text))
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
            dgvProizvodi.DataSource = filter;
        }
    }
}
