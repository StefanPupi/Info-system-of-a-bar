using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diplomski
{
    public partial class formaZaposleniNoviRacun : Form
    {
        List<Artikal> artikli;
        List<Artikal> izabrani;
        List<Racun> racuni;
        Server srv;
        Racun racun;
        int id;
        int idRacun = 1;
        int pristup;
        public formaZaposleniNoviRacun(int korisnik)
        {
            InitializeComponent();
            artikli = new List<Artikal>();
            izabrani = new List<Artikal>();
            racuni = new List<Racun>();
            srv = new Server(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Pupi\Downloads\UgostiteljskiObjekat.accdb");
            this.pristup = korisnik;
        }

        private void formaZaposleniNoviRacun_Load(object sender, EventArgs e)
        {
            OsveziArtikle();
        }

        private void OsveziArtikle()
        {
            try
            {
                artikli.Clear();
                dgvArtikli.DataSource = null;
                srv.OtvoriKonekciju();
                OleDbCommand command = new OleDbCommand();
                command.Connection = srv.Connection;
                command.CommandText = "SELECT * FROM Artikal";
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Artikal a = new Artikal(int.Parse(reader["id_artikal"].ToString()), reader["naziv"].ToString(), reader["jedinica_prodaje"].ToString(), float.Parse(reader["kolicina"].ToString()), float.Parse(reader["cena_po_jedinici"].ToString()), float.Parse(reader["min_kolicina"].ToString()), double.Parse(reader["barkod"].ToString()));
                    artikli.Add(a);
                }
                srv.ZatvoriKonekciju();
                dgvArtikli.DataSource = artikli;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                srv.ZatvoriKonekciju();
            }
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
                    izabrani.Add(a);
                    break;
                }
            }
            dgvRacun.DataSource = null;
            dgvRacun.DataSource = izabrani;
        }

        private void btnDodajNovRacun_Click(object sender, EventArgs e)
        {
            float cena = 0;
            foreach (Artikal a in izabrani)
            {
                cena += a.Cena;
            }
            try
            {
                srv.OtvoriKonekciju();
                OleDbCommand comm = new OleDbCommand();
                comm.Connection = srv.Connection;
                comm.CommandText = "SELECT * FROM Racun";
                OleDbDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    idRacun = int.Parse(reader["id_racun"].ToString()) + 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                srv.ZatvoriKonekciju();
            }

            Racun r = new Racun(id, pristup, DateTime.Now.Date, cena, izabrani);

            try
            {
                string query = "insert into Racun (id_racun,id_korisnik,vreme_izdavanja,iznos_racuna) values(@id_racun,@id_korisnik,@vreme_izdavanja,@iznos_racuna)";
                OleDbCommand command = new OleDbCommand(query, srv.Connection);
                command.Parameters.AddWithValue("@id_racun", r.Id_racun);
                command.Parameters.AddWithValue("@id_korisnik", r.Id_korisnik);
                command.Parameters.AddWithValue("@vreme_izdavanja", r.Vreme_izdavanja);
                command.Parameters.AddWithValue("@iznos_racuna", r.Iznos_racuna);
                srv.OtvoriKonekciju();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                srv.ZatvoriKonekciju();
            }

            foreach (Artikal a in izabrani)
            {
                try
                {
                    srv.OtvoriKonekciju();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = srv.Connection;
                    command.CommandText = "insert into Racun_artikal (id_racun,id_artikal,kolicina,cena) values(@id_racun,@id_artikal,@kolicina,@cena)";
                    command.Parameters.AddWithValue("@id_racun", r.Id_racun);
                    command.Parameters.AddWithValue("@id_artikal", a.Id_artikal);
                    command.Parameters.AddWithValue("@kolicina", 1.0);
                    command.Parameters.AddWithValue("@cena", a.Cena);
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    srv.ZatvoriKonekciju();

                }
            }
            MessageBox.Show("Uspešno dodavanje novog računa!");
            btnOtkazi_Click(null, null);
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            formaZaposleniPregled zaposleniPregled = new formaZaposleniPregled(pristup);
            zaposleniPregled.Show();
            this.Hide();
        }

        private void formaZaposleniNoviRacun_FormClosed(object sender, FormClosedEventArgs e)
        {
            formaZaposleniPregled zaposleniPregled = new formaZaposleniPregled(pristup);
            zaposleniPregled.Show();
            this.Hide();
        }
    }
}
