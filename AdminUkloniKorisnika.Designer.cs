namespace Diplomski
{
    partial class formaAdminUkloniKorisnika
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnUkloniKorisnika = new System.Windows.Forms.Button();
            this.btnOtkazi = new System.Windows.Forms.Button();
            this.dgvKorisnici = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbId = new System.Windows.Forms.CheckBox();
            this.chbPosao = new System.Windows.Forms.CheckBox();
            this.dtpDatumIstekaUgovora = new System.Windows.Forms.DateTimePicker();
            this.dtpDatumZaposljavanja = new System.Windows.Forms.DateTimePicker();
            this.cbPlata = new System.Windows.Forms.CheckBox();
            this.cbDatumIstekaUgovora = new System.Windows.Forms.CheckBox();
            this.cbDatumZaposljenja = new System.Windows.Forms.CheckBox();
            this.cbLozinka = new System.Windows.Forms.CheckBox();
            this.cbKorisnickoIme = new System.Windows.Forms.CheckBox();
            this.cbPrezime = new System.Windows.Forms.CheckBox();
            this.cbIme = new System.Windows.Forms.CheckBox();
            this.cbSve = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPretraga = new System.Windows.Forms.TextBox();
            this.cbSortiraj = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisnici)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(561, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 31);
            this.label1.TabIndex = 21;
            this.label1.Text = "Ukloni korisnika";
            // 
            // btnUkloniKorisnika
            // 
            this.btnUkloniKorisnika.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUkloniKorisnika.Location = new System.Drawing.Point(499, 520);
            this.btnUkloniKorisnika.Name = "btnUkloniKorisnika";
            this.btnUkloniKorisnika.Size = new System.Drawing.Size(169, 32);
            this.btnUkloniKorisnika.TabIndex = 30;
            this.btnUkloniKorisnika.Text = "Ukloni korisnika";
            this.btnUkloniKorisnika.UseVisualStyleBackColor = true;
            this.btnUkloniKorisnika.Click += new System.EventHandler(this.btnUkloniKorisnika_Click);
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOtkazi.Location = new System.Drawing.Point(714, 520);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(169, 32);
            this.btnOtkazi.TabIndex = 31;
            this.btnOtkazi.Text = "Otkaži";
            this.btnOtkazi.UseVisualStyleBackColor = true;
            this.btnOtkazi.Click += new System.EventHandler(this.btnOtkazi_Click);
            // 
            // dgvKorisnici
            // 
            this.dgvKorisnici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKorisnici.Location = new System.Drawing.Point(308, 64);
            this.dgvKorisnici.Name = "dgvKorisnici";
            this.dgvKorisnici.Size = new System.Drawing.Size(774, 432);
            this.dgvKorisnici.TabIndex = 58;
            this.dgvKorisnici.SelectionChanged += new System.EventHandler(this.dgvKorisnici_SelectionChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(53, 439);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 20);
            this.label3.TabIndex = 91;
            this.label3.Text = "Pretraga po datumu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(83, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 20);
            this.label4.TabIndex = 90;
            this.label4.Text = "Pretraga po kljucnoj reci";
            // 
            // cbId
            // 
            this.cbId.AutoSize = true;
            this.cbId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbId.ForeColor = System.Drawing.Color.White;
            this.cbId.Location = new System.Drawing.Point(30, 167);
            this.cbId.Name = "cbId";
            this.cbId.Size = new System.Drawing.Size(42, 24);
            this.cbId.TabIndex = 89;
            this.cbId.Text = "Id";
            this.cbId.UseVisualStyleBackColor = true;
            this.cbId.CheckedChanged += new System.EventHandler(this.cbId_CheckedChanged);
            // 
            // chbPosao
            // 
            this.chbPosao.AutoSize = true;
            this.chbPosao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbPosao.ForeColor = System.Drawing.Color.White;
            this.chbPosao.Location = new System.Drawing.Point(30, 364);
            this.chbPosao.Name = "chbPosao";
            this.chbPosao.Size = new System.Drawing.Size(73, 24);
            this.chbPosao.TabIndex = 88;
            this.chbPosao.Text = "Posao";
            this.chbPosao.UseVisualStyleBackColor = true;
            this.chbPosao.CheckedChanged += new System.EventHandler(this.cbId_CheckedChanged);
            // 
            // dtpDatumIstekaUgovora
            // 
            this.dtpDatumIstekaUgovora.Enabled = false;
            this.dtpDatumIstekaUgovora.Location = new System.Drawing.Point(30, 564);
            this.dtpDatumIstekaUgovora.Name = "dtpDatumIstekaUgovora";
            this.dtpDatumIstekaUgovora.Size = new System.Drawing.Size(200, 20);
            this.dtpDatumIstekaUgovora.TabIndex = 87;
            // 
            // dtpDatumZaposljavanja
            // 
            this.dtpDatumZaposljavanja.Enabled = false;
            this.dtpDatumZaposljavanja.Location = new System.Drawing.Point(30, 502);
            this.dtpDatumZaposljavanja.Name = "dtpDatumZaposljavanja";
            this.dtpDatumZaposljavanja.Size = new System.Drawing.Size(200, 20);
            this.dtpDatumZaposljavanja.TabIndex = 86;
            // 
            // cbPlata
            // 
            this.cbPlata.AutoSize = true;
            this.cbPlata.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPlata.ForeColor = System.Drawing.Color.White;
            this.cbPlata.Location = new System.Drawing.Point(30, 403);
            this.cbPlata.Name = "cbPlata";
            this.cbPlata.Size = new System.Drawing.Size(64, 24);
            this.cbPlata.TabIndex = 85;
            this.cbPlata.Text = "Plata";
            this.cbPlata.UseVisualStyleBackColor = true;
            this.cbPlata.CheckedChanged += new System.EventHandler(this.cbId_CheckedChanged);
            // 
            // cbDatumIstekaUgovora
            // 
            this.cbDatumIstekaUgovora.AutoSize = true;
            this.cbDatumIstekaUgovora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDatumIstekaUgovora.ForeColor = System.Drawing.Color.White;
            this.cbDatumIstekaUgovora.Location = new System.Drawing.Point(30, 533);
            this.cbDatumIstekaUgovora.Name = "cbDatumIstekaUgovora";
            this.cbDatumIstekaUgovora.Size = new System.Drawing.Size(183, 24);
            this.cbDatumIstekaUgovora.TabIndex = 84;
            this.cbDatumIstekaUgovora.Text = "Datum isteka ugovora";
            this.cbDatumIstekaUgovora.UseVisualStyleBackColor = true;
            this.cbDatumIstekaUgovora.CheckedChanged += new System.EventHandler(this.cbDatumIstekaUgovora_CheckedChanged);
            // 
            // cbDatumZaposljenja
            // 
            this.cbDatumZaposljenja.AutoSize = true;
            this.cbDatumZaposljenja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDatumZaposljenja.ForeColor = System.Drawing.Color.White;
            this.cbDatumZaposljenja.Location = new System.Drawing.Point(30, 472);
            this.cbDatumZaposljenja.Name = "cbDatumZaposljenja";
            this.cbDatumZaposljenja.Size = new System.Drawing.Size(159, 24);
            this.cbDatumZaposljenja.TabIndex = 83;
            this.cbDatumZaposljenja.Text = "Datum zaposljenja";
            this.cbDatumZaposljenja.UseVisualStyleBackColor = true;
            this.cbDatumZaposljenja.CheckedChanged += new System.EventHandler(this.cbDatumZaposljenja_CheckedChanged);
            // 
            // cbLozinka
            // 
            this.cbLozinka.AutoSize = true;
            this.cbLozinka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLozinka.ForeColor = System.Drawing.Color.White;
            this.cbLozinka.Location = new System.Drawing.Point(30, 325);
            this.cbLozinka.Name = "cbLozinka";
            this.cbLozinka.Size = new System.Drawing.Size(83, 24);
            this.cbLozinka.TabIndex = 82;
            this.cbLozinka.Text = "Lozinka";
            this.cbLozinka.UseVisualStyleBackColor = true;
            this.cbLozinka.CheckedChanged += new System.EventHandler(this.cbId_CheckedChanged);
            // 
            // cbKorisnickoIme
            // 
            this.cbKorisnickoIme.AutoSize = true;
            this.cbKorisnickoIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKorisnickoIme.ForeColor = System.Drawing.Color.White;
            this.cbKorisnickoIme.Location = new System.Drawing.Point(30, 286);
            this.cbKorisnickoIme.Name = "cbKorisnickoIme";
            this.cbKorisnickoIme.Size = new System.Drawing.Size(129, 24);
            this.cbKorisnickoIme.TabIndex = 81;
            this.cbKorisnickoIme.Text = "Korisnicko ime";
            this.cbKorisnickoIme.UseVisualStyleBackColor = true;
            this.cbKorisnickoIme.CheckedChanged += new System.EventHandler(this.cbId_CheckedChanged);
            // 
            // cbPrezime
            // 
            this.cbPrezime.AutoSize = true;
            this.cbPrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPrezime.ForeColor = System.Drawing.Color.White;
            this.cbPrezime.Location = new System.Drawing.Point(30, 247);
            this.cbPrezime.Name = "cbPrezime";
            this.cbPrezime.Size = new System.Drawing.Size(85, 24);
            this.cbPrezime.TabIndex = 80;
            this.cbPrezime.Text = "Prezime";
            this.cbPrezime.UseVisualStyleBackColor = true;
            this.cbPrezime.CheckedChanged += new System.EventHandler(this.cbId_CheckedChanged);
            // 
            // cbIme
            // 
            this.cbIme.AutoSize = true;
            this.cbIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIme.ForeColor = System.Drawing.Color.White;
            this.cbIme.Location = new System.Drawing.Point(30, 207);
            this.cbIme.Name = "cbIme";
            this.cbIme.Size = new System.Drawing.Size(55, 24);
            this.cbIme.TabIndex = 79;
            this.cbIme.Text = "Ime";
            this.cbIme.UseVisualStyleBackColor = true;
            this.cbIme.CheckedChanged += new System.EventHandler(this.cbId_CheckedChanged);
            // 
            // cbSve
            // 
            this.cbSve.AutoSize = true;
            this.cbSve.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSve.ForeColor = System.Drawing.Color.White;
            this.cbSve.Location = new System.Drawing.Point(30, 137);
            this.cbSve.Name = "cbSve";
            this.cbSve.Size = new System.Drawing.Size(55, 24);
            this.cbSve.TabIndex = 78;
            this.cbSve.Text = "Sve";
            this.cbSve.UseVisualStyleBackColor = true;
            this.cbSve.CheckedChanged += new System.EventHandler(this.cbSve_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(203, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 26);
            this.button1.TabIndex = 77;
            this.button1.Text = "Pretrazi";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(114, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 31);
            this.label5.TabIndex = 76;
            this.label5.Text = "Pretraga";
            // 
            // tbPretraga
            // 
            this.tbPretraga.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPretraga.Location = new System.Drawing.Point(30, 96);
            this.tbPretraga.Name = "tbPretraga";
            this.tbPretraga.Size = new System.Drawing.Size(158, 26);
            this.tbPretraga.TabIndex = 75;
            this.tbPretraga.TextChanged += new System.EventHandler(this.tbPretraga_TextChanged);
            // 
            // cbSortiraj
            // 
            this.cbSortiraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSortiraj.FormattingEnabled = true;
            this.cbSortiraj.Items.AddRange(new object[] {
            "Uobicajeno",
            "Ime rastuce (A-Z)",
            "Ime opadajuce (Z-A)",
            "Prezime rastuce (A-Z)",
            "Prezime opadajuce (Z-A)",
            "Korisnicko ime rastuce (A-Z)",
            "Korisnicko ime opadajuce (Z-A)",
            "Plata rastuce",
            "Plata opadajuce",
            "Najranije zaposljen",
            "Najkasnije zaposljen",
            "Najranije istice ugovor",
            "Najkasnije istice ugovor"});
            this.cbSortiraj.Location = new System.Drawing.Point(869, 35);
            this.cbSortiraj.Name = "cbSortiraj";
            this.cbSortiraj.Size = new System.Drawing.Size(213, 23);
            this.cbSortiraj.TabIndex = 93;
            this.cbSortiraj.SelectedIndexChanged += new System.EventHandler(this.cbSortiraj_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(774, 35);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 20);
            this.label13.TabIndex = 92;
            this.label13.Text = "Sortiraj po: ";
            // 
            // formaAdminUkloniKorisnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(1109, 605);
            this.Controls.Add(this.cbSortiraj);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbId);
            this.Controls.Add(this.chbPosao);
            this.Controls.Add(this.dtpDatumIstekaUgovora);
            this.Controls.Add(this.dtpDatumZaposljavanja);
            this.Controls.Add(this.cbPlata);
            this.Controls.Add(this.cbDatumIstekaUgovora);
            this.Controls.Add(this.cbDatumZaposljenja);
            this.Controls.Add(this.cbLozinka);
            this.Controls.Add(this.cbKorisnickoIme);
            this.Controls.Add(this.cbPrezime);
            this.Controls.Add(this.cbIme);
            this.Controls.Add(this.cbSve);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbPretraga);
            this.Controls.Add(this.dgvKorisnici);
            this.Controls.Add(this.btnOtkazi);
            this.Controls.Add(this.btnUkloniKorisnika);
            this.Controls.Add(this.label1);
            this.Name = "formaAdminUkloniKorisnika";
            this.Text = "Admin - Ukloni korisnika";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formaAdminUkloniKorisnika_FormClosed);
            this.Load += new System.EventHandler(this.formaAdminUkloniKorisnika_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisnici)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUkloniKorisnika;
        private System.Windows.Forms.Button btnOtkazi;
        private System.Windows.Forms.DataGridView dgvKorisnici;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbId;
        private System.Windows.Forms.CheckBox chbPosao;
        private System.Windows.Forms.DateTimePicker dtpDatumIstekaUgovora;
        private System.Windows.Forms.DateTimePicker dtpDatumZaposljavanja;
        private System.Windows.Forms.CheckBox cbPlata;
        private System.Windows.Forms.CheckBox cbDatumIstekaUgovora;
        private System.Windows.Forms.CheckBox cbDatumZaposljenja;
        private System.Windows.Forms.CheckBox cbLozinka;
        private System.Windows.Forms.CheckBox cbKorisnickoIme;
        private System.Windows.Forms.CheckBox cbPrezime;
        private System.Windows.Forms.CheckBox cbIme;
        private System.Windows.Forms.CheckBox cbSve;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPretraga;
        private System.Windows.Forms.ComboBox cbSortiraj;
        private System.Windows.Forms.Label label13;
    }
}