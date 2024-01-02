using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Diplomski
{
    public partial class formaZaposleniPregled1 : Form
    {
        int pristup;
        List<Racun> racuni;
        List<Racun> neplaceni;
        List<Artikal> artikli;
        Serializer serializer;
        Stream fs;
        int id = -1;
        float cena;
        string putanja = "racun.bin";
        public formaZaposleniPregled1()
        {
            InitializeComponent();
        }

        public formaZaposleniPregled1(int korisnik)
        {
            InitializeComponent();
            racuni = new List<Racun>();
            neplaceni = new List<Racun>();
            serializer = new Serializer();
            artikli = new List<Artikal>();
            this.pristup = korisnik;
        }

        private void btnNovRac_Click(object sender, EventArgs e)
        {
            formaZaposleniNoviRacun1 zaposleniNoviRacun = new formaZaposleniNoviRacun1(pristup);
            zaposleniNoviRacun.Show();
            this.Hide();
        }

        private void btnUrediRac_Click(object sender, EventArgs e)
        {
            formaZaposleniUrediRacun zaposleniUrediRacun = new formaZaposleniUrediRacun(pristup, id);
            zaposleniUrediRacun.Show();
            this.Hide();
        }

        private void btnSviRac_Click(object sender, EventArgs e)
        {
            formaPregledRacuni pregledRacuni = new formaPregledRacuni("Zaposleni");
            pregledRacuni.Show();
            this.Hide();
        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            formaPrijava formaLogin = new formaPrijava();
            formaLogin.Show();
            this.Dispose();
        }

        private void formaZaposleniPregled1_FormClosed(object sender, FormClosedEventArgs e)
        {
            formaPrijava formaLogin = new formaPrijava();
            formaLogin.Show();
            this.Dispose();
        }

        private void formaZaposleniPregled1_Load(object sender, EventArgs e)
        {
            OsveziRacune();
        }

        private void OsveziArtikle(int idRacuna)
        {
            foreach (Racun r in racuni)
            {
                if (r.Id_racun == idRacuna)
                {
                    dgvTrenutniRacun.DataSource = r.Artikli;
                    return;
                }
            }
        }

        private void OsveziRacune()
        {
            racuni.Clear();
            neplaceni.Clear();
            dgvAktivniRacuni.DataSource = null;
            if (File.Exists(putanja))
            {
                fs = File.OpenRead(putanja);
                if(fs.Length == 0)
                {
                    MessageBox.Show("Trenutno nemate aktivnih racuna!");
                    fs.Close();
                    return;
                }
                racuni = serializer.DeserializeRacun(fs);
                fs.Close();
            }
            else
            {
                fs = File.Open(putanja, FileMode.Create);
                MessageBox.Show("Trenutno nemate aktivnih racuna!");
                fs.Close();
                return;
            }

            foreach (Racun r in racuni)
            {
                if (!r.Placeno)
                {
                    neplaceni.Add(r);
                    continue;
                }
            }
            dgvAktivniRacuni.DataSource = neplaceni;

            fs = File.OpenRead("artikal.bin");
            artikli = serializer.DeserializeArtikal(fs);
            fs.Close();
        }

        private void dgvAktivniRacuni_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow red in dgvAktivniRacuni.SelectedRows)
            {
                id = int.Parse(red.Cells[0].Value.ToString());
                cena = float.Parse(red.Cells[3].Value.ToString());
                lblNaplata.Text = cena + " din";
                break;
            }

        }

        private void btnVidiRacun_Click(object sender, EventArgs e)
        {
            OsveziArtikle(id);
        }

        private void tbUplaceno_TextChanged(object sender, EventArgs e)
        {
            if (float.TryParse(tbUplaceno.Text, out float uplata))
            {
                float povracaj = uplata - cena;
                lblPovracaj.Text = povracaj.ToString() + " din";
            }

        }

        private void btnNaplati_Click(object sender, EventArgs e)
        {
            if (float.TryParse(tbUplaceno.Text, out float uplata))
            {
                foreach (Racun r in neplaceni)
                {
                    if (r.Id_racun == id)
                    {
                        if (r.Iznos_racuna <= uplata)
                        {
                            r.Placeno = true;
                        }
                        else
                        {
                            MessageBox.Show("Uplacen iznos je manji od iznosa racuna!");
                            return;
                        }
                        foreach (Artikal a in r.Artikli)
                        {
                            foreach (Artikal a1 in artikli)
                            {
                                if (a1.Id_artikal == a.Id_artikal)
                                {
                                    a1.Kolicina -= 1;
                                    break;
                                }
                            }
                        }
                        break;
                    }

                }
                if (id >= 0)
                {
                    fs = File.OpenWrite(putanja);
                    serializer.Serialize(racuni, fs);
                    fs.Close();
                    fs = File.OpenWrite("artikal.bin");
                    serializer.Serialize(artikli, fs);
                    fs.Close();
                    MessageBox.Show("Uspesno naplaceno!");
                    OsveziRacune();
                    dgvTrenutniRacun.DataSource = null;
                    id = -1;
                }
                
            }
            else
            {
                MessageBox.Show("Proverite uplacen iznos!");
            }
        }

        private void btnStorniraj_Click(object sender, EventArgs e)
        {
            foreach (Racun r in racuni)
            {
                if (r.Id_racun == id)
                {
                    racuni.Remove(r);
                    break;
                }
            }
            fs = File.OpenWrite(putanja);
            serializer.Serialize(racuni, fs);
            fs.Close();
            OsveziRacune();
            dgvAktivniRacuni.DataSource = null;
            dgvAktivniRacuni.DataSource = neplaceni;
        }

        private void btnIzvestaji_Click(object sender, EventArgs e)
        {
            formaIzvestaj izvestaj = new formaIzvestaj(pristup);
            izvestaj.Show();
            this.Hide();
        }
    }
}
