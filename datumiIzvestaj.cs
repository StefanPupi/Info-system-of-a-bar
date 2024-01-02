using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diplomski
{
    public partial class formaDatumiIzvestaj : Form
    {
        string period;
        DateTime pocetni;
        DateTime krajnji;
        public DateTime Pocetni { get => pocetni; set => pocetni = value; }
        public DateTime Krajnji { get => krajnji; set => krajnji = value; }

        public formaDatumiIzvestaj(string period)
        {
            InitializeComponent();
            this.period = period;
        }
        private void formaDatumiIzvestaj_Load(object sender, EventArgs e)
        {
            if (period == "dnevni")
            {
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                dtpKrajnji.Visible = false;
                cbMesec.Visible = false;
                cbGodina.Visible = false;
                return;
            }
            if (period == "nedeljni")
            {
                label4.Visible = false;
                label5.Visible = false;
                cbMesec.Visible = false;
                cbGodina.Visible = false;
                return;
            }
            if (period == "mesecni")
            {
                label2.Visible = false;
                label3.Visible = false;
                dtpPocetni.Visible = false;
                dtpKrajnji.Visible = false;
                return;
            }
            if (period == "godisnji")
            {
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                dtpPocetni.Visible = false;
                dtpKrajnji.Visible = false;
                cbMesec.Visible = false;
                return;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (period == "dnevni")
            {
                this.pocetni = dtpPocetni.Value.Date;
            }

            if (period == "nedeljni")
            {
                this.pocetni = dtpPocetni.Value.Date;
                this.krajnji = dtpKrajnji.Value.Date;
            }

            if (period == "mesecni")
            {
                this.pocetni = DateTime.Parse((cbMesec.SelectedIndex+1).ToString()+"/01/"+cbGodina.SelectedItem.ToString()+" 06:00:00 AM");
                this.krajnji = DateTime.Parse((cbMesec.SelectedIndex + 2).ToString() + "/01/" + cbGodina.SelectedItem.ToString() + " 06:00:00 AM");
                MessageBox.Show(pocetni.ToString() + krajnji.ToString());
            }

            if (period == "godisnji")
            {
                this.pocetni = DateTime.Parse("01/01/" + cbGodina.SelectedItem.ToString() + " 06:00:00 AM");
                this.krajnji = DateTime.Parse("01/01/" + (int.Parse(cbGodina.SelectedItem.ToString())+1).ToString() + " 06:00:00 AM");
                MessageBox.Show(pocetni.ToString() + krajnji.ToString());
            }

            this.Hide();
        }
    }
}
