
namespace Diplomski
{
    partial class formaIzvestaj
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
            this.dgvIzvestaj = new System.Windows.Forms.DataGridView();
            this.btnDnevni = new System.Windows.Forms.Button();
            this.btnNedeljni = new System.Windows.Forms.Button();
            this.btnMesecni = new System.Windows.Forms.Button();
            this.btnGodisnji = new System.Windows.Forms.Button();
            this.btnOtkazi = new System.Windows.Forms.Button();
            this.btnIzvezi = new System.Windows.Forms.Button();
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
            this.cbSortiraj = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDanasnji = new System.Windows.Forms.Button();
            this.cbKategorija = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUkupno = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIzvestaj)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvIzvestaj
            // 
            this.dgvIzvestaj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIzvestaj.Location = new System.Drawing.Point(278, 75);
            this.dgvIzvestaj.Name = "dgvIzvestaj";
            this.dgvIzvestaj.Size = new System.Drawing.Size(794, 384);
            this.dgvIzvestaj.TabIndex = 0;
            // 
            // btnDnevni
            // 
            this.btnDnevni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDnevni.Location = new System.Drawing.Point(416, 500);
            this.btnDnevni.Name = "btnDnevni";
            this.btnDnevni.Size = new System.Drawing.Size(108, 52);
            this.btnDnevni.TabIndex = 1;
            this.btnDnevni.Text = "Dnevni izvestaj";
            this.btnDnevni.UseVisualStyleBackColor = true;
            this.btnDnevni.Click += new System.EventHandler(this.btnDnevni_Click);
            // 
            // btnNedeljni
            // 
            this.btnNedeljni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNedeljni.Location = new System.Drawing.Point(835, 500);
            this.btnNedeljni.Name = "btnNedeljni";
            this.btnNedeljni.Size = new System.Drawing.Size(108, 52);
            this.btnNedeljni.TabIndex = 2;
            this.btnNedeljni.Text = "Proizvoljni izvestaj";
            this.btnNedeljni.UseVisualStyleBackColor = true;
            this.btnNedeljni.Click += new System.EventHandler(this.btnNedeljni_Click);
            // 
            // btnMesecni
            // 
            this.btnMesecni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMesecni.Location = new System.Drawing.Point(564, 500);
            this.btnMesecni.Name = "btnMesecni";
            this.btnMesecni.Size = new System.Drawing.Size(108, 52);
            this.btnMesecni.TabIndex = 4;
            this.btnMesecni.Text = "Mesecni izvestaj";
            this.btnMesecni.UseVisualStyleBackColor = true;
            this.btnMesecni.Click += new System.EventHandler(this.btnMesecni_Click);
            // 
            // btnGodisnji
            // 
            this.btnGodisnji.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGodisnji.Location = new System.Drawing.Point(700, 500);
            this.btnGodisnji.Name = "btnGodisnji";
            this.btnGodisnji.Size = new System.Drawing.Size(108, 52);
            this.btnGodisnji.TabIndex = 5;
            this.btnGodisnji.Text = "Godisnji izvestaj";
            this.btnGodisnji.UseVisualStyleBackColor = true;
            this.btnGodisnji.Click += new System.EventHandler(this.btnGodisnji_Click);
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOtkazi.Location = new System.Drawing.Point(989, 558);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(108, 35);
            this.btnOtkazi.TabIndex = 7;
            this.btnOtkazi.Text = "Otkazi";
            this.btnOtkazi.UseVisualStyleBackColor = true;
            this.btnOtkazi.Click += new System.EventHandler(this.btnOtkazi_Click);
            // 
            // btnIzvezi
            // 
            this.btnIzvezi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzvezi.Location = new System.Drawing.Point(964, 498);
            this.btnIzvezi.Name = "btnIzvezi";
            this.btnIzvezi.Size = new System.Drawing.Size(108, 54);
            this.btnIzvezi.TabIndex = 6;
            this.btnIzvezi.Text = "Izvezi u Excel";
            this.btnIzvezi.UseVisualStyleBackColor = true;
            this.btnIzvezi.Click += new System.EventHandler(this.btnIzvezi_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(71, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(177, 20);
            this.label9.TabIndex = 77;
            this.label9.Text = "Pretraga po kljucnoj reci";
            // 
            // cbId
            // 
            this.cbId.AutoSize = true;
            this.cbId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbId.ForeColor = System.Drawing.Color.White;
            this.cbId.Location = new System.Drawing.Point(18, 219);
            this.cbId.Name = "cbId";
            this.cbId.Size = new System.Drawing.Size(42, 24);
            this.cbId.TabIndex = 76;
            this.cbId.Text = "Id";
            this.cbId.UseVisualStyleBackColor = true;
            this.cbId.CheckedChanged += new System.EventHandler(this.cbKategorija_CheckedChanged);
            // 
            // cbBarkod
            // 
            this.cbBarkod.AutoSize = true;
            this.cbBarkod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBarkod.ForeColor = System.Drawing.Color.White;
            this.cbBarkod.Location = new System.Drawing.Point(18, 416);
            this.cbBarkod.Name = "cbBarkod";
            this.cbBarkod.Size = new System.Drawing.Size(79, 24);
            this.cbBarkod.TabIndex = 75;
            this.cbBarkod.Text = "Barkod";
            this.cbBarkod.UseVisualStyleBackColor = true;
            this.cbBarkod.CheckedChanged += new System.EventHandler(this.cbKategorija_CheckedChanged);
            // 
            // cbJedinica
            // 
            this.cbJedinica.AutoSize = true;
            this.cbJedinica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbJedinica.ForeColor = System.Drawing.Color.White;
            this.cbJedinica.Location = new System.Drawing.Point(18, 455);
            this.cbJedinica.Name = "cbJedinica";
            this.cbJedinica.Size = new System.Drawing.Size(143, 24);
            this.cbJedinica.TabIndex = 74;
            this.cbJedinica.Text = "Jedinica prodaje";
            this.cbJedinica.UseVisualStyleBackColor = true;
            this.cbJedinica.CheckedChanged += new System.EventHandler(this.cbKategorija_CheckedChanged);
            // 
            // cbCena
            // 
            this.cbCena.AutoSize = true;
            this.cbCena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCena.ForeColor = System.Drawing.Color.White;
            this.cbCena.Location = new System.Drawing.Point(18, 377);
            this.cbCena.Name = "cbCena";
            this.cbCena.Size = new System.Drawing.Size(66, 24);
            this.cbCena.TabIndex = 73;
            this.cbCena.Text = "Cena";
            this.cbCena.UseVisualStyleBackColor = true;
            this.cbCena.CheckedChanged += new System.EventHandler(this.cbKategorija_CheckedChanged);
            // 
            // cbMinimalnaKolicina
            // 
            this.cbMinimalnaKolicina.AutoSize = true;
            this.cbMinimalnaKolicina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMinimalnaKolicina.ForeColor = System.Drawing.Color.White;
            this.cbMinimalnaKolicina.Location = new System.Drawing.Point(18, 338);
            this.cbMinimalnaKolicina.Name = "cbMinimalnaKolicina";
            this.cbMinimalnaKolicina.Size = new System.Drawing.Size(155, 24);
            this.cbMinimalnaKolicina.TabIndex = 72;
            this.cbMinimalnaKolicina.Text = "Minimalna kolicina";
            this.cbMinimalnaKolicina.UseVisualStyleBackColor = true;
            this.cbMinimalnaKolicina.CheckedChanged += new System.EventHandler(this.cbKategorija_CheckedChanged);
            // 
            // cbKolicina
            // 
            this.cbKolicina.AutoSize = true;
            this.cbKolicina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKolicina.ForeColor = System.Drawing.Color.White;
            this.cbKolicina.Location = new System.Drawing.Point(18, 299);
            this.cbKolicina.Name = "cbKolicina";
            this.cbKolicina.Size = new System.Drawing.Size(82, 24);
            this.cbKolicina.TabIndex = 71;
            this.cbKolicina.Text = "Kolicina";
            this.cbKolicina.UseVisualStyleBackColor = true;
            this.cbKolicina.CheckedChanged += new System.EventHandler(this.cbKategorija_CheckedChanged);
            // 
            // cbNaziv
            // 
            this.cbNaziv.AutoSize = true;
            this.cbNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNaziv.ForeColor = System.Drawing.Color.White;
            this.cbNaziv.Location = new System.Drawing.Point(18, 259);
            this.cbNaziv.Name = "cbNaziv";
            this.cbNaziv.Size = new System.Drawing.Size(66, 24);
            this.cbNaziv.TabIndex = 70;
            this.cbNaziv.Text = "Naziv";
            this.cbNaziv.UseVisualStyleBackColor = true;
            this.cbNaziv.CheckedChanged += new System.EventHandler(this.cbKategorija_CheckedChanged);
            // 
            // cbSve
            // 
            this.cbSve.AutoSize = true;
            this.cbSve.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSve.ForeColor = System.Drawing.Color.White;
            this.cbSve.Location = new System.Drawing.Point(18, 180);
            this.cbSve.Name = "cbSve";
            this.cbSve.Size = new System.Drawing.Size(55, 24);
            this.cbSve.TabIndex = 69;
            this.cbSve.Text = "Sve";
            this.cbSve.UseVisualStyleBackColor = true;
            this.cbSve.CheckedChanged += new System.EventHandler(this.cbSve_CheckedChanged);
            // 
            // btnPretraga
            // 
            this.btnPretraga.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPretraga.Location = new System.Drawing.Point(191, 139);
            this.btnPretraga.Name = "btnPretraga";
            this.btnPretraga.Size = new System.Drawing.Size(76, 26);
            this.btnPretraga.TabIndex = 68;
            this.btnPretraga.Text = "Pretrazi";
            this.btnPretraga.UseVisualStyleBackColor = true;
            this.btnPretraga.Click += new System.EventHandler(this.btnPretraga_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(102, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 31);
            this.label10.TabIndex = 67;
            this.label10.Text = "Pretraga";
            // 
            // tbPretraga
            // 
            this.tbPretraga.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPretraga.Location = new System.Drawing.Point(18, 139);
            this.tbPretraga.Name = "tbPretraga";
            this.tbPretraga.Size = new System.Drawing.Size(158, 26);
            this.tbPretraga.TabIndex = 66;
            this.tbPretraga.TextChanged += new System.EventHandler(this.tbPretraga_TextChanged);
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
            this.cbSortiraj.Location = new System.Drawing.Point(858, 43);
            this.cbSortiraj.Name = "cbSortiraj";
            this.cbSortiraj.Size = new System.Drawing.Size(213, 23);
            this.cbSortiraj.TabIndex = 79;
            this.cbSortiraj.SelectedIndexChanged += new System.EventHandler(this.cbSortiraj_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(763, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 20);
            this.label11.TabIndex = 78;
            this.label11.Text = "Sortiraj po: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(487, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 31);
            this.label1.TabIndex = 80;
            this.label1.Text = "Izvestaj";
            // 
            // btnDanasnji
            // 
            this.btnDanasnji.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDanasnji.Location = new System.Drawing.Point(278, 500);
            this.btnDanasnji.Name = "btnDanasnji";
            this.btnDanasnji.Size = new System.Drawing.Size(108, 52);
            this.btnDanasnji.TabIndex = 81;
            this.btnDanasnji.Text = "Danasnji izvestaj";
            this.btnDanasnji.UseVisualStyleBackColor = true;
            this.btnDanasnji.Click += new System.EventHandler(this.btnDanasnji_Click);
            // 
            // cbKategorija
            // 
            this.cbKategorija.AutoSize = true;
            this.cbKategorija.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKategorija.ForeColor = System.Drawing.Color.White;
            this.cbKategorija.Location = new System.Drawing.Point(18, 492);
            this.cbKategorija.Name = "cbKategorija";
            this.cbKategorija.Size = new System.Drawing.Size(99, 24);
            this.cbKategorija.TabIndex = 82;
            this.cbKategorija.Text = "Kategorija";
            this.cbKategorija.UseVisualStyleBackColor = true;
            this.cbKategorija.CheckedChanged += new System.EventHandler(this.cbKategorija_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(897, 466);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 83;
            this.label2.Text = "label2";
            // 
            // lblUkupno
            // 
            this.lblUkupno.AutoSize = true;
            this.lblUkupno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUkupno.ForeColor = System.Drawing.Color.White;
            this.lblUkupno.Location = new System.Drawing.Point(918, 466);
            this.lblUkupno.Name = "lblUkupno";
            this.lblUkupno.Size = new System.Drawing.Size(69, 20);
            this.lblUkupno.TabIndex = 84;
            this.lblUkupno.Text = "Ukupno:";
            // 
            // formaIzvestaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(1109, 605);
            this.Controls.Add(this.lblUkupno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbKategorija);
            this.Controls.Add(this.btnDanasnji);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbSortiraj);
            this.Controls.Add(this.label11);
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
            this.Controls.Add(this.btnOtkazi);
            this.Controls.Add(this.btnIzvezi);
            this.Controls.Add(this.btnGodisnji);
            this.Controls.Add(this.btnMesecni);
            this.Controls.Add(this.btnNedeljni);
            this.Controls.Add(this.btnDnevni);
            this.Controls.Add(this.dgvIzvestaj);
            this.Name = "formaIzvestaj";
            this.Text = "Izvestaj";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formaIzvestaj_FormClosed);
            this.Load += new System.EventHandler(this.formaIzvestaj_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIzvestaj)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvIzvestaj;
        private System.Windows.Forms.Button btnDnevni;
        private System.Windows.Forms.Button btnNedeljni;
        private System.Windows.Forms.Button btnMesecni;
        private System.Windows.Forms.Button btnGodisnji;
        private System.Windows.Forms.Button btnOtkazi;
        private System.Windows.Forms.Button btnIzvezi;
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
        private System.Windows.Forms.ComboBox cbSortiraj;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDanasnji;
        private System.Windows.Forms.CheckBox cbKategorija;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUkupno;
    }
}