
namespace Diplomski
{
    partial class formaZaposleniNoviRacun1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvArtikli = new System.Windows.Forms.DataGridView();
            this.dgvRacun = new System.Windows.Forms.DataGridView();
            this.btnUkloniProizvod = new System.Windows.Forms.Button();
            this.btnDodajProizvod = new System.Windows.Forms.Button();
            this.btnOtkazi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDodajNovRacun = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSortiraj = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbKategorija = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbId = new System.Windows.Forms.CheckBox();
            this.cbBarkod = new System.Windows.Forms.CheckBox();
            this.cbJedinica = new System.Windows.Forms.CheckBox();
            this.cbCena = new System.Windows.Forms.CheckBox();
            this.cbMinimalnaKolicina = new System.Windows.Forms.CheckBox();
            this.cbKolicina = new System.Windows.Forms.CheckBox();
            this.cbNaziv = new System.Windows.Forms.CheckBox();
            this.cbSve = new System.Windows.Forms.CheckBox();
            this.btnPretraga = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.tbPretraga = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtikli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRacun)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvArtikli
            // 
            this.dgvArtikli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArtikli.Location = new System.Drawing.Point(333, 88);
            this.dgvArtikli.Name = "dgvArtikli";
            this.dgvArtikli.Size = new System.Drawing.Size(400, 359);
            this.dgvArtikli.TabIndex = 49;
            this.dgvArtikli.SelectionChanged += new System.EventHandler(this.dgvArtikli_SelectionChanged);
            // 
            // dgvRacun
            // 
            this.dgvRacun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRacun.Location = new System.Drawing.Point(748, 56);
            this.dgvRacun.Name = "dgvRacun";
            this.dgvRacun.Size = new System.Drawing.Size(349, 391);
            this.dgvRacun.TabIndex = 48;
            this.dgvRacun.SelectionChanged += new System.EventHandler(this.dgvRacun_SelectionChanged);
            // 
            // btnUkloniProizvod
            // 
            this.btnUkloniProizvod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUkloniProizvod.Location = new System.Drawing.Point(867, 511);
            this.btnUkloniProizvod.Name = "btnUkloniProizvod";
            this.btnUkloniProizvod.Size = new System.Drawing.Size(132, 32);
            this.btnUkloniProizvod.TabIndex = 47;
            this.btnUkloniProizvod.Text = "Ukloni proizvod";
            this.btnUkloniProizvod.UseVisualStyleBackColor = true;
            this.btnUkloniProizvod.Click += new System.EventHandler(this.btnUkloniProizvod_Click);
            // 
            // btnDodajProizvod
            // 
            this.btnDodajProizvod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajProizvod.Location = new System.Drawing.Point(464, 464);
            this.btnDodajProizvod.Name = "btnDodajProizvod";
            this.btnDodajProizvod.Size = new System.Drawing.Size(162, 32);
            this.btnDodajProizvod.TabIndex = 46;
            this.btnDodajProizvod.Text = "Dodaj proizvod";
            this.btnDodajProizvod.UseVisualStyleBackColor = true;
            this.btnDodajProizvod.Click += new System.EventHandler(this.btnDodajProizvod_Click);
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOtkazi.Location = new System.Drawing.Point(867, 558);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(132, 32);
            this.btnOtkazi.TabIndex = 45;
            this.btnOtkazi.Text = "Otkaži";
            this.btnOtkazi.UseVisualStyleBackColor = true;
            this.btnOtkazi.Click += new System.EventHandler(this.btnOtkazi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(861, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 31);
            this.label2.TabIndex = 44;
            this.label2.Text = "Nov račun";
            // 
            // btnDodajNovRacun
            // 
            this.btnDodajNovRacun.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajNovRacun.Location = new System.Drawing.Point(867, 464);
            this.btnDodajNovRacun.Name = "btnDodajNovRacun";
            this.btnDodajNovRacun.Size = new System.Drawing.Size(132, 32);
            this.btnDodajNovRacun.TabIndex = 43;
            this.btnDodajNovRacun.Text = "Dodaj novi racun";
            this.btnDodajNovRacun.UseVisualStyleBackColor = true;
            this.btnDodajNovRacun.Click += new System.EventHandler(this.btnDodajNovRacun_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(458, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 31);
            this.label1.TabIndex = 42;
            this.label1.Text = "Svi proizvodi";
            // 
            // cbSortiraj
            // 
            this.cbSortiraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSortiraj.FormattingEnabled = true;
            this.cbSortiraj.Items.AddRange(new object[] {
            "Uobicajeno",
            "Naziv rastuce (A-Z)",
            "Naziv opadajuce (Z-A)",
            "Kolicina rastuce",
            "Kolicina opadajuce",
            "Cena rastuce",
            "Cena opadajuce",
            "Jedinica prodaje rastuce",
            "Jedinica prodaje opadajuce",
            "Kategorija"});
            this.cbSortiraj.Location = new System.Drawing.Point(520, 59);
            this.cbSortiraj.Name = "cbSortiraj";
            this.cbSortiraj.Size = new System.Drawing.Size(213, 23);
            this.cbSortiraj.TabIndex = 81;
            this.cbSortiraj.SelectedIndexChanged += new System.EventHandler(this.cbSortiraj_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(425, 59);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 20);
            this.label11.TabIndex = 80;
            this.label11.Text = "Sortiraj po: ";
            // 
            // cbKategorija
            // 
            this.cbKategorija.AutoSize = true;
            this.cbKategorija.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKategorija.ForeColor = System.Drawing.Color.White;
            this.cbKategorija.Location = new System.Drawing.Point(37, 486);
            this.cbKategorija.Name = "cbKategorija";
            this.cbKategorija.Size = new System.Drawing.Size(99, 24);
            this.cbKategorija.TabIndex = 95;
            this.cbKategorija.Text = "Kategorija";
            this.cbKategorija.UseVisualStyleBackColor = true;
            this.cbKategorija.CheckedChanged += new System.EventHandler(this.cbKategorija_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(90, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(177, 20);
            this.label9.TabIndex = 94;
            this.label9.Text = "Pretraga po kljucnoj reci";
            // 
            // cbId
            // 
            this.cbId.AutoSize = true;
            this.cbId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbId.ForeColor = System.Drawing.Color.White;
            this.cbId.Location = new System.Drawing.Point(37, 213);
            this.cbId.Name = "cbId";
            this.cbId.Size = new System.Drawing.Size(42, 24);
            this.cbId.TabIndex = 93;
            this.cbId.Text = "Id";
            this.cbId.UseVisualStyleBackColor = true;
            this.cbId.CheckedChanged += new System.EventHandler(this.cbKategorija_CheckedChanged);
            // 
            // cbBarkod
            // 
            this.cbBarkod.AutoSize = true;
            this.cbBarkod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBarkod.ForeColor = System.Drawing.Color.White;
            this.cbBarkod.Location = new System.Drawing.Point(37, 410);
            this.cbBarkod.Name = "cbBarkod";
            this.cbBarkod.Size = new System.Drawing.Size(79, 24);
            this.cbBarkod.TabIndex = 92;
            this.cbBarkod.Text = "Barkod";
            this.cbBarkod.UseVisualStyleBackColor = true;
            this.cbBarkod.CheckedChanged += new System.EventHandler(this.cbKategorija_CheckedChanged);
            // 
            // cbJedinica
            // 
            this.cbJedinica.AutoSize = true;
            this.cbJedinica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbJedinica.ForeColor = System.Drawing.Color.White;
            this.cbJedinica.Location = new System.Drawing.Point(37, 449);
            this.cbJedinica.Name = "cbJedinica";
            this.cbJedinica.Size = new System.Drawing.Size(143, 24);
            this.cbJedinica.TabIndex = 91;
            this.cbJedinica.Text = "Jedinica prodaje";
            this.cbJedinica.UseVisualStyleBackColor = true;
            this.cbJedinica.CheckedChanged += new System.EventHandler(this.cbKategorija_CheckedChanged);
            // 
            // cbCena
            // 
            this.cbCena.AutoSize = true;
            this.cbCena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCena.ForeColor = System.Drawing.Color.White;
            this.cbCena.Location = new System.Drawing.Point(37, 371);
            this.cbCena.Name = "cbCena";
            this.cbCena.Size = new System.Drawing.Size(66, 24);
            this.cbCena.TabIndex = 90;
            this.cbCena.Text = "Cena";
            this.cbCena.UseVisualStyleBackColor = true;
            this.cbCena.CheckedChanged += new System.EventHandler(this.cbKategorija_CheckedChanged);
            // 
            // cbMinimalnaKolicina
            // 
            this.cbMinimalnaKolicina.AutoSize = true;
            this.cbMinimalnaKolicina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMinimalnaKolicina.ForeColor = System.Drawing.Color.White;
            this.cbMinimalnaKolicina.Location = new System.Drawing.Point(37, 332);
            this.cbMinimalnaKolicina.Name = "cbMinimalnaKolicina";
            this.cbMinimalnaKolicina.Size = new System.Drawing.Size(155, 24);
            this.cbMinimalnaKolicina.TabIndex = 89;
            this.cbMinimalnaKolicina.Text = "Minimalna kolicina";
            this.cbMinimalnaKolicina.UseVisualStyleBackColor = true;
            this.cbMinimalnaKolicina.CheckedChanged += new System.EventHandler(this.cbKategorija_CheckedChanged);
            // 
            // cbKolicina
            // 
            this.cbKolicina.AutoSize = true;
            this.cbKolicina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKolicina.ForeColor = System.Drawing.Color.White;
            this.cbKolicina.Location = new System.Drawing.Point(37, 293);
            this.cbKolicina.Name = "cbKolicina";
            this.cbKolicina.Size = new System.Drawing.Size(82, 24);
            this.cbKolicina.TabIndex = 88;
            this.cbKolicina.Text = "Kolicina";
            this.cbKolicina.UseVisualStyleBackColor = true;
            this.cbKolicina.CheckedChanged += new System.EventHandler(this.cbKategorija_CheckedChanged);
            // 
            // cbNaziv
            // 
            this.cbNaziv.AutoSize = true;
            this.cbNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNaziv.ForeColor = System.Drawing.Color.White;
            this.cbNaziv.Location = new System.Drawing.Point(37, 253);
            this.cbNaziv.Name = "cbNaziv";
            this.cbNaziv.Size = new System.Drawing.Size(66, 24);
            this.cbNaziv.TabIndex = 87;
            this.cbNaziv.Text = "Naziv";
            this.cbNaziv.UseVisualStyleBackColor = true;
            this.cbNaziv.CheckedChanged += new System.EventHandler(this.cbKategorija_CheckedChanged);
            // 
            // cbSve
            // 
            this.cbSve.AutoSize = true;
            this.cbSve.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSve.ForeColor = System.Drawing.Color.White;
            this.cbSve.Location = new System.Drawing.Point(37, 174);
            this.cbSve.Name = "cbSve";
            this.cbSve.Size = new System.Drawing.Size(55, 24);
            this.cbSve.TabIndex = 86;
            this.cbSve.Text = "Sve";
            this.cbSve.UseVisualStyleBackColor = true;
            this.cbSve.CheckedChanged += new System.EventHandler(this.cbSve_CheckedChanged);
            // 
            // btnPretraga
            // 
            this.btnPretraga.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPretraga.Location = new System.Drawing.Point(210, 133);
            this.btnPretraga.Name = "btnPretraga";
            this.btnPretraga.Size = new System.Drawing.Size(76, 26);
            this.btnPretraga.TabIndex = 85;
            this.btnPretraga.Text = "Pretrazi";
            this.btnPretraga.UseVisualStyleBackColor = true;
            this.btnPretraga.Click += new System.EventHandler(this.btnPretraga_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(121, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 31);
            this.label10.TabIndex = 84;
            this.label10.Text = "Pretraga";
            // 
            // tbPretraga
            // 
            this.tbPretraga.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPretraga.Location = new System.Drawing.Point(37, 133);
            this.tbPretraga.Name = "tbPretraga";
            this.tbPretraga.Size = new System.Drawing.Size(158, 26);
            this.tbPretraga.TabIndex = 83;
            this.tbPretraga.TextChanged += new System.EventHandler(this.tbPretraga_TextChanged);
            // 
            // formaZaposleniNoviRacun1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(1109, 605);
            this.Controls.Add(this.cbKategorija);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbId);
            this.Controls.Add(this.cbBarkod);
            this.Controls.Add(this.cbJedinica);
            this.Controls.Add(this.cbCena);
            this.Controls.Add(this.cbMinimalnaKolicina);
            this.Controls.Add(this.cbKolicina);
            this.Controls.Add(this.cbNaziv);
            this.Controls.Add(this.cbSve);
            this.Controls.Add(this.btnPretraga);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbPretraga);
            this.Controls.Add(this.cbSortiraj);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dgvArtikli);
            this.Controls.Add(this.dgvRacun);
            this.Controls.Add(this.btnUkloniProizvod);
            this.Controls.Add(this.btnDodajProizvod);
            this.Controls.Add(this.btnOtkazi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDodajNovRacun);
            this.Controls.Add(this.label1);
            this.Name = "formaZaposleniNoviRacun1";
            this.Text = "formaZaposleniNoviRacun1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formaZaposleniNoviRacun_FormClosed);
            this.Load += new System.EventHandler(this.formaZaposleniNoviRacun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtikli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRacun)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArtikli;
        private System.Windows.Forms.DataGridView dgvRacun;
        private System.Windows.Forms.Button btnUkloniProizvod;
        private System.Windows.Forms.Button btnDodajProizvod;
        private System.Windows.Forms.Button btnOtkazi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDodajNovRacun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSortiraj;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox cbKategorija;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox cbId;
        private System.Windows.Forms.CheckBox cbBarkod;
        private System.Windows.Forms.CheckBox cbJedinica;
        private System.Windows.Forms.CheckBox cbCena;
        private System.Windows.Forms.CheckBox cbMinimalnaKolicina;
        private System.Windows.Forms.CheckBox cbKolicina;
        private System.Windows.Forms.CheckBox cbNaziv;
        private System.Windows.Forms.CheckBox cbSve;
        private System.Windows.Forms.Button btnPretraga;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbPretraga;
    }
}