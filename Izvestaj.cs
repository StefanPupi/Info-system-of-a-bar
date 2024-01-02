using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diplomski
{
    public partial class formaIzvestaj : Form
    {
        List<Racun> racuni;
        List<Racun> izabraniRacuni;
        List<Artikal> artikli;
        List<Artikal> filter;
        List<string> kriterijumi;
        Serializer serializer;
        Stream fs;
        int pristup;
        string putanja = "racun.bin";
        double ukupno = 0;
        DateTime pocetni;
        DateTime krajnji;
        public formaIzvestaj()
        {
            InitializeComponent();
            racuni = new List<Racun>();
            izabraniRacuni = new List<Racun>();
            filter = new List<Artikal>();
            kriterijumi = new List<string>();
            artikli = new List<Artikal>();
            serializer = new Serializer();
        }

        public formaIzvestaj(int pristup)
        {
            InitializeComponent();
            racuni = new List<Racun>();
            izabraniRacuni = new List<Racun>();
            filter = new List<Artikal>();
            artikli = new List<Artikal>();
            serializer = new Serializer();
            kriterijumi = new List<string>();
            this.pristup = pristup;
        }

        private void btnDanasnji_Click(object sender, EventArgs e)
        {
            artikli.Clear();
            izabraniRacuni.Clear();
            OsveziRacune();
            foreach (Racun r in racuni)
            {
                if (r.Vreme_izdavanja.CompareTo(DateTime.Today.AddDays(-1).AddHours(6))>0 && r.Vreme_izdavanja.CompareTo(DateTime.Today.AddHours(6))<0)
                {
                    izabraniRacuni.Add(r);
                }
            }

            foreach(Racun r1 in izabraniRacuni)
            {
                foreach(Artikal a in r1.Artikli)
                {
                    artikli.Add(a);
                    ukupno += a.Kolicina * a.Cena;
                }
            }
            dgvIzvestaj.DataSource = null;
            dgvIzvestaj.DataSource = artikli;
            lblUkupno.Text = "Ukupno: " + ukupno + " din";
        }

        private void btnDnevni_Click(object sender, EventArgs e)
        {
            ukupno = 0;
            artikli.Clear();
            izabraniRacuni.Clear();
            using (formaDatumiIzvestaj formaDatumiIzvestaj = new formaDatumiIzvestaj("dnevni"))
            {
                formaDatumiIzvestaj.ShowDialog();
                this.pocetni = formaDatumiIzvestaj.Pocetni;
                formaDatumiIzvestaj.Close();
            }
            OsveziRacune();
            foreach (Racun r in racuni)
            {
                if (r.Vreme_izdavanja.CompareTo(pocetni.AddHours(6))>0 && r.Vreme_izdavanja.CompareTo(pocetni.AddDays(1).AddHours(6))<0)
                {
                    izabraniRacuni.Add(r);
                }
            }
            foreach (Racun r1 in izabraniRacuni)
            {
                foreach (Artikal a in r1.Artikli)
                {
                    artikli.Add(a);
                    ukupno += a.Kolicina * a.Cena;
                }
            }
            dgvIzvestaj.DataSource = null;
            dgvIzvestaj.DataSource = artikli;
            lblUkupno.Text = "Ukupno: " + ukupno + " din";
        }

        private void btnNedeljni_Click(object sender, EventArgs e)
        {
            ukupno = 0;
            artikli.Clear();
            izabraniRacuni.Clear();
            using (formaDatumiIzvestaj formaDatumiIzvestaj = new formaDatumiIzvestaj("nedeljni"))
            {
                formaDatumiIzvestaj.ShowDialog();
                this.pocetni = formaDatumiIzvestaj.Pocetni;
                this.krajnji = formaDatumiIzvestaj.Krajnji;
                formaDatumiIzvestaj.Close();
            }
            OsveziRacune();
            foreach (Racun r in racuni)
            {
                if (r.Vreme_izdavanja.CompareTo(pocetni.AddHours(6)) > 0 && r.Vreme_izdavanja.CompareTo(krajnji.AddDays(1).AddHours(6)) < 0)
                {
                    izabraniRacuni.Add(r);
                }
            }
            foreach (Racun r1 in izabraniRacuni)
            {
                foreach (Artikal a in r1.Artikli)
                {
                    artikli.Add(a);
                    ukupno += a.Kolicina * a.Cena;
                }
            }
            dgvIzvestaj.DataSource = null;
            dgvIzvestaj.DataSource = artikli;
            lblUkupno.Text = "Ukupno: " + ukupno + " din";
        }

        private void btnMesecni_Click(object sender, EventArgs e)
        {
            ukupno = 0;
            artikli.Clear();
            izabraniRacuni.Clear();
            using (formaDatumiIzvestaj formaDatumiIzvestaj = new formaDatumiIzvestaj("mesecni"))
            {
                formaDatumiIzvestaj.ShowDialog();
                this.pocetni = formaDatumiIzvestaj.Pocetni;
                this.krajnji = formaDatumiIzvestaj.Krajnji;
                formaDatumiIzvestaj.Close();
            }
            OsveziRacune();
            foreach (Racun r in racuni)
            {
                if (r.Vreme_izdavanja.CompareTo(pocetni.AddHours(6)) > 0 && r.Vreme_izdavanja.CompareTo(krajnji.AddDays(1).AddHours(6)) < 0)
                {
                    izabraniRacuni.Add(r);
                }
            }
            foreach (Racun r1 in izabraniRacuni)
            {
                foreach (Artikal a in r1.Artikli)
                {
                    artikli.Add(a);
                    ukupno += a.Kolicina * a.Cena;
                }
            }
            dgvIzvestaj.DataSource = null;
            dgvIzvestaj.DataSource = artikli;
            lblUkupno.Text = "Ukupno: " + ukupno + " din";
        }

        private void btnGodisnji_Click(object sender, EventArgs e)
        {
            ukupno = 0;
            artikli.Clear();
            izabraniRacuni.Clear();
            using (formaDatumiIzvestaj formaDatumiIzvestaj = new formaDatumiIzvestaj("godisnji"))
            {
                formaDatumiIzvestaj.ShowDialog();
                this.pocetni = formaDatumiIzvestaj.Pocetni;
                this.krajnji = formaDatumiIzvestaj.Krajnji;
                formaDatumiIzvestaj.Close();
            }
            OsveziRacune();
            foreach (Racun r in racuni)
            {
                if (r.Vreme_izdavanja.CompareTo(pocetni.AddHours(6)) > 0 && r.Vreme_izdavanja.CompareTo(krajnji.AddDays(1).AddHours(6)) < 0)
                {
                    izabraniRacuni.Add(r);
                }
            }
            foreach (Racun r1 in izabraniRacuni)
            {
                foreach (Artikal a in r1.Artikli)
                {
                    artikli.Add(a);
                    ukupno += a.Kolicina * a.Cena;
                }
            }
            dgvIzvestaj.DataSource = null;
            dgvIzvestaj.DataSource = artikli;
            lblUkupno.Text = "Ukupno: " + ukupno + " din";
        }

        private void btnIzvezi_Click(object sender, EventArgs e)
        {
            if(dgvIzvestaj.Rows.Count == 0)
            {
                return;
            }
            dgvIzvestaj.SelectAll();
            DataObject izvoz = dgvIzvestaj.GetClipboardContent();
            if (izvoz != null)
            {
                Clipboard.SetDataObject(izvoz);
            }
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook excelWorkbook;
            Microsoft.Office.Interop.Excel.Worksheet excelWorksheet;

            object izvozData = System.Reflection.Missing.Value;
            excelWorkbook = excel.Workbooks.Add(izvozData);

            excelWorksheet = (Microsoft.Office.Interop.Excel.Worksheet)excelWorkbook.Worksheets[1];
            Microsoft.Office.Interop.Excel.Range excelRange = (Microsoft.Office.Interop.Excel.Range)excelWorksheet.Cells[2, 1];
            excelRange.Select();

            excelWorksheet.PasteSpecial(excelRange, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            formaZaposleniPregled1 zaposleniPregled1 = new formaZaposleniPregled1(pristup);
            zaposleniPregled1.Show();
            this.Hide();
        }

        private void formaIzvestaj_FormClosed(object sender, FormClosedEventArgs e)
        {
            formaZaposleniPregled1 zaposleniPregled1 = new formaZaposleniPregled1(pristup);
            zaposleniPregled1.Show();
            this.Hide();
        }

        private void OsveziRacune()
        {
            if (File.Exists(putanja))
            {
                fs = File.OpenRead(putanja);
                if (fs.Length == 0)
                {
                    MessageBox.Show("Trenutno nemate račune u arhivi, formiranje izveštaja bilo koje vrste neće biti moguće!");
                    fs.Close();
                    return;
                }
                racuni = serializer.DeserializeRacun(fs);
                fs.Close();
            }
            else
            {
                fs = File.Open(putanja, FileMode.Create);
                MessageBox.Show("Trenutno nemate račune u arhivi, formiranje izveštaja bilo koje vrste neće biti moguće!");
                fs.Close();
                return;
            }
        }

        private void formaIzvestaj_Load(object sender, EventArgs e)
        {
            OsveziRacune();
        }

        private void cbSortiraj_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSortiraj.SelectedIndex == 0)
            {
                OsveziRacune();
            }
            if (cbSortiraj.SelectedIndex == 1)
            {
                artikli.Sort((x, y) => x.Naziv.CompareTo(y.Naziv));
                dgvIzvestaj.DataSource = null;
                dgvIzvestaj.DataSource = artikli;
                return;
            }
            if (cbSortiraj.SelectedIndex == 2)
            {
                artikli.Sort((x, y) => y.Naziv.CompareTo(x.Naziv));
                dgvIzvestaj.DataSource = null;
                dgvIzvestaj.DataSource = artikli;
                return;
            }
            if (cbSortiraj.SelectedIndex == 3)
            {
                artikli.Sort((x, y) => x.Kolicina.CompareTo(y.Kolicina));
                dgvIzvestaj.DataSource = null;
                dgvIzvestaj.DataSource = artikli;
                return;
            }
            if (cbSortiraj.SelectedIndex == 4)
            {
                artikli.Sort((x, y) => y.Kolicina.CompareTo(x.Kolicina));
                dgvIzvestaj.DataSource = null;
                dgvIzvestaj.DataSource = artikli;
                return;
            }
            if (cbSortiraj.SelectedIndex == 5)
            {
                artikli.Sort((x, y) => x.Cena.CompareTo(y.Cena));
                dgvIzvestaj.DataSource = null;
                dgvIzvestaj.DataSource = artikli;
                return;
            }
            if (cbSortiraj.SelectedIndex == 6)
            {
                artikli.Sort((x, y) => y.Cena.CompareTo(x.Cena));
                dgvIzvestaj.DataSource = null;
                dgvIzvestaj.DataSource = artikli;
                return;
            }
            if (cbSortiraj.SelectedIndex == 7)
            {
                artikli.Sort((x, y) => x.Jedinica_prodaje.CompareTo(y.Jedinica_prodaje));
                dgvIzvestaj.DataSource = null;
                dgvIzvestaj.DataSource = artikli;
                return;
            }
            if (cbSortiraj.SelectedIndex == 8)
            {
                artikli.Sort((x, y) => y.Jedinica_prodaje.CompareTo(x.Jedinica_prodaje));
                dgvIzvestaj.DataSource = null;
                dgvIzvestaj.DataSource = artikli;
                return;
            }
            if (cbSortiraj.SelectedIndex == 9)
            {
                artikli.Sort((x, y) => x.Kategorija.CompareTo(y.Kategorija));
                dgvIzvestaj.DataSource = null;
                dgvIzvestaj.DataSource = artikli;
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
                OsveziRacune();
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
            dgvIzvestaj.DataSource = null;
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
            dgvIzvestaj.DataSource = filter;
        }
    }
}
