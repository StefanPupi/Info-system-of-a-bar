namespace Diplomski
{
    partial class formaMenadzerNovaNabavka
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
            this.btnUkloniProizvod = new System.Windows.Forms.Button();
            this.btnDodajProizvod = new System.Windows.Forms.Button();
            this.btnOtkazi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDodajNovuNabavku = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvNabavka = new System.Windows.Forms.DataGridView();
            this.dgvProizvodi = new System.Windows.Forms.DataGridView();
            this.tbKolicina = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbSortiraj = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.chbKategorija = new System.Windows.Forms.CheckBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvNabavka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProizvodi)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUkloniProizvod
            // 
            this.btnUkloniProizvod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUkloniProizvod.Location = new System.Drawing.Point(833, 491);
            this.btnUkloniProizvod.Name = "btnUkloniProizvod";
            this.btnUkloniProizvod.Size = new System.Drawing.Size(182, 32);
            this.btnUkloniProizvod.TabIndex = 47;
            this.btnUkloniProizvod.Text = "Ukloni proizvod";
            this.btnUkloniProizvod.UseVisualStyleBackColor = true;
            this.btnUkloniProizvod.Click += new System.EventHandler(this.btnUkloniProizvod_Click);
            // 
            // btnDodajProizvod
            // 
            this.btnDodajProizvod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajProizvod.Location = new System.Drawing.Point(452, 539);
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
            this.btnOtkazi.Location = new System.Drawing.Point(833, 543);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(182, 32);
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
            this.label2.Location = new System.Drawing.Point(827, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 31);
            this.label2.TabIndex = 43;
            this.label2.Text = "Nova nabavka";
            // 
            // btnDodajNovuNabavku
            // 
            this.btnDodajNovuNabavku.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajNovuNabavku.Location = new System.Drawing.Point(833, 439);
            this.btnDodajNovuNabavku.Name = "btnDodajNovuNabavku";
            this.btnDodajNovuNabavku.Size = new System.Drawing.Size(182, 32);
            this.btnDodajNovuNabavku.TabIndex = 42;
            this.btnDodajNovuNabavku.Text = "Dodaj novu nabavku";
            this.btnDodajNovuNabavku.UseVisualStyleBackColor = true;
            this.btnDodajNovuNabavku.Click += new System.EventHandler(this.btnDodajNovuNabavku_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(446, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 31);
            this.label1.TabIndex = 41;
            this.label1.Text = "Svi proizvodi";
            // 
            // dgvNabavka
            // 
            this.dgvNabavka.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNabavka.Location = new System.Drawing.Point(744, 78);
            this.dgvNabavka.Name = "dgvNabavka";
            this.dgvNabavka.Size = new System.Drawing.Size(349, 341);
            this.dgvNabavka.TabIndex = 48;
            this.dgvNabavka.SelectionChanged += new System.EventHandler(this.dgvNabavka_SelectionChanged);
            // 
            // dgvProizvodi
            // 
            this.dgvProizvodi.AllowUserToAddRows = false;
            this.dgvProizvodi.AllowUserToDeleteRows = false;
            this.dgvProizvodi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProizvodi.Location = new System.Drawing.Point(336, 78);
            this.dgvProizvodi.Name = "dgvProizvodi";
            this.dgvProizvodi.Size = new System.Drawing.Size(392, 408);
            this.dgvProizvodi.TabIndex = 49;
            this.dgvProizvodi.SelectionChanged += new System.EventHandler(this.dgvProizvodi_SelectionChanged);
            // 
            // tbKolicina
            // 
            this.tbKolicina.Location = new System.Drawing.Point(525, 503);
            this.tbKolicina.Name = "tbKolicina";
            this.tbKolicina.Size = new System.Drawing.Size(100, 20);
            this.tbKolicina.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(439, 503);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 51;
            this.label3.Text = "Kolicina";
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
            this.cbSortiraj.Location = new System.Drawing.Point(515, 49);
            this.cbSortiraj.Name = "cbSortiraj";
            this.cbSortiraj.Size = new System.Drawing.Size(213, 23);
            this.cbSortiraj.TabIndex = 70;
            this.cbSortiraj.SelectedIndexChanged += new System.EventHandler(this.cbSortiraj_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(420, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 20);
            this.label11.TabIndex = 69;
            this.label11.Text = "Sortiraj po: ";
            // 
            // chbKategorija
            // 
            this.chbKategorija.AutoSize = true;
            this.chbKategorija.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbKategorija.ForeColor = System.Drawing.Color.White;
            this.chbKategorija.Location = new System.Drawing.Point(47, 477);
            this.chbKategorija.Name = "chbKategorija";
            this.chbKategorija.Size = new System.Drawing.Size(99, 24);
            this.chbKategorija.TabIndex = 84;
            this.chbKategorija.Text = "Kategorija";
            this.chbKategorija.UseVisualStyleBackColor = true;
            this.chbKategorija.CheckedChanged += new System.EventHandler(this.chbKategorija_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(100, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(177, 20);
            this.label9.TabIndex = 83;
            this.label9.Text = "Pretraga po kljucnoj reci";
            // 
            // cbId
            // 
            this.cbId.AutoSize = true;
            this.cbId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbId.ForeColor = System.Drawing.Color.White;
            this.cbId.Location = new System.Drawing.Point(47, 198);
            this.cbId.Name = "cbId";
            this.cbId.Size = new System.Drawing.Size(42, 24);
            this.cbId.TabIndex = 82;
            this.cbId.Text = "Id";
            this.cbId.UseVisualStyleBackColor = true;
            this.cbId.CheckedChanged += new System.EventHandler(this.chbKategorija_CheckedChanged);
            // 
            // cbBarkod
            // 
            this.cbBarkod.AutoSize = true;
            this.cbBarkod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBarkod.ForeColor = System.Drawing.Color.White;
            this.cbBarkod.Location = new System.Drawing.Point(47, 395);
            this.cbBarkod.Name = "cbBarkod";
            this.cbBarkod.Size = new System.Drawing.Size(79, 24);
            this.cbBarkod.TabIndex = 81;
            this.cbBarkod.Text = "Barkod";
            this.cbBarkod.UseVisualStyleBackColor = true;
            this.cbBarkod.CheckedChanged += new System.EventHandler(this.chbKategorija_CheckedChanged);
            // 
            // cbJedinica
            // 
            this.cbJedinica.AutoSize = true;
            this.cbJedinica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbJedinica.ForeColor = System.Drawing.Color.White;
            this.cbJedinica.Location = new System.Drawing.Point(47, 434);
            this.cbJedinica.Name = "cbJedinica";
            this.cbJedinica.Size = new System.Drawing.Size(143, 24);
            this.cbJedinica.TabIndex = 80;
            this.cbJedinica.Text = "Jedinica prodaje";
            this.cbJedinica.UseVisualStyleBackColor = true;
            this.cbJedinica.CheckedChanged += new System.EventHandler(this.chbKategorija_CheckedChanged);
            // 
            // cbCena
            // 
            this.cbCena.AutoSize = true;
            this.cbCena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCena.ForeColor = System.Drawing.Color.White;
            this.cbCena.Location = new System.Drawing.Point(47, 356);
            this.cbCena.Name = "cbCena";
            this.cbCena.Size = new System.Drawing.Size(66, 24);
            this.cbCena.TabIndex = 79;
            this.cbCena.Text = "Cena";
            this.cbCena.UseVisualStyleBackColor = true;
            this.cbCena.CheckedChanged += new System.EventHandler(this.chbKategorija_CheckedChanged);
            // 
            // cbMinimalnaKolicina
            // 
            this.cbMinimalnaKolicina.AutoSize = true;
            this.cbMinimalnaKolicina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMinimalnaKolicina.ForeColor = System.Drawing.Color.White;
            this.cbMinimalnaKolicina.Location = new System.Drawing.Point(47, 317);
            this.cbMinimalnaKolicina.Name = "cbMinimalnaKolicina";
            this.cbMinimalnaKolicina.Size = new System.Drawing.Size(155, 24);
            this.cbMinimalnaKolicina.TabIndex = 78;
            this.cbMinimalnaKolicina.Text = "Minimalna kolicina";
            this.cbMinimalnaKolicina.UseVisualStyleBackColor = true;
            this.cbMinimalnaKolicina.CheckedChanged += new System.EventHandler(this.chbKategorija_CheckedChanged);
            // 
            // cbKolicina
            // 
            this.cbKolicina.AutoSize = true;
            this.cbKolicina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKolicina.ForeColor = System.Drawing.Color.White;
            this.cbKolicina.Location = new System.Drawing.Point(47, 278);
            this.cbKolicina.Name = "cbKolicina";
            this.cbKolicina.Size = new System.Drawing.Size(82, 24);
            this.cbKolicina.TabIndex = 77;
            this.cbKolicina.Text = "Kolicina";
            this.cbKolicina.UseVisualStyleBackColor = true;
            this.cbKolicina.CheckedChanged += new System.EventHandler(this.chbKategorija_CheckedChanged);
            // 
            // cbNaziv
            // 
            this.cbNaziv.AutoSize = true;
            this.cbNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNaziv.ForeColor = System.Drawing.Color.White;
            this.cbNaziv.Location = new System.Drawing.Point(47, 238);
            this.cbNaziv.Name = "cbNaziv";
            this.cbNaziv.Size = new System.Drawing.Size(66, 24);
            this.cbNaziv.TabIndex = 76;
            this.cbNaziv.Text = "Naziv";
            this.cbNaziv.UseVisualStyleBackColor = true;
            this.cbNaziv.CheckedChanged += new System.EventHandler(this.chbKategorija_CheckedChanged);
            // 
            // cbSve
            // 
            this.cbSve.AutoSize = true;
            this.cbSve.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSve.ForeColor = System.Drawing.Color.White;
            this.cbSve.Location = new System.Drawing.Point(47, 159);
            this.cbSve.Name = "cbSve";
            this.cbSve.Size = new System.Drawing.Size(55, 24);
            this.cbSve.TabIndex = 75;
            this.cbSve.Text = "Sve";
            this.cbSve.UseVisualStyleBackColor = true;
            this.cbSve.CheckedChanged += new System.EventHandler(this.cbSve_CheckedChanged);
            // 
            // btnPretraga
            // 
            this.btnPretraga.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPretraga.Location = new System.Drawing.Point(220, 118);
            this.btnPretraga.Name = "btnPretraga";
            this.btnPretraga.Size = new System.Drawing.Size(76, 26);
            this.btnPretraga.TabIndex = 74;
            this.btnPretraga.Text = "Pretrazi";
            this.btnPretraga.UseVisualStyleBackColor = true;
            this.btnPretraga.Click += new System.EventHandler(this.btnPretraga_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(131, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 31);
            this.label10.TabIndex = 73;
            this.label10.Text = "Pretraga";
            // 
            // tbPretraga
            // 
            this.tbPretraga.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPretraga.Location = new System.Drawing.Point(47, 118);
            this.tbPretraga.Name = "tbPretraga";
            this.tbPretraga.Size = new System.Drawing.Size(158, 26);
            this.tbPretraga.TabIndex = 72;
            this.tbPretraga.TextChanged += new System.EventHandler(this.tbPretraga_TextChanged);
            // 
            // formaMenadzerNovaNabavka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(1109, 605);
            this.Controls.Add(this.chbKategorija);
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
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbKolicina);
            this.Controls.Add(this.dgvProizvodi);
            this.Controls.Add(this.dgvNabavka);
            this.Controls.Add(this.btnUkloniProizvod);
            this.Controls.Add(this.btnDodajProizvod);
            this.Controls.Add(this.btnOtkazi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDodajNovuNabavku);
            this.Controls.Add(this.label1);
            this.Name = "formaMenadzerNovaNabavka";
            this.Text = "Menadzer - Nova nabavka";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formaMenadzerNovaNabavka_FormClosed);
            this.Load += new System.EventHandler(this.formaMenadzerNovaNabavka_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNabavka)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProizvodi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUkloniProizvod;
        private System.Windows.Forms.Button btnDodajProizvod;
        private System.Windows.Forms.Button btnOtkazi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDodajNovuNabavku;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvNabavka;
        private System.Windows.Forms.DataGridView dgvProizvodi;
        private System.Windows.Forms.TextBox tbKolicina;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbSortiraj;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox chbKategorija;
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