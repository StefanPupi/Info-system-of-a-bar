namespace Diplomski
{
    partial class formaAdminUrediKorisnika
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
            this.btnOtkazi = new System.Windows.Forms.Button();
            this.btnUrediKorisnika = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbPosao = new System.Windows.Forms.ComboBox();
            this.btnGenerisi = new System.Windows.Forms.Button();
            this.dtpDatumIstekaUgovora = new System.Windows.Forms.DateTimePicker();
            this.dtpDatumZaposlenja = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbPlata = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbPrezime = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbIme = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tbLozinka = new System.Windows.Forms.TextBox();
            this.tbKorIme = new System.Windows.Forms.TextBox();
            this.dgvKorisnici = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbId = new System.Windows.Forms.CheckBox();
            this.chbPosao = new System.Windows.Forms.CheckBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dtpDatumZaposljavanja = new System.Windows.Forms.DateTimePicker();
            this.cbPlata = new System.Windows.Forms.CheckBox();
            this.cbDatumIstekaUgovora = new System.Windows.Forms.CheckBox();
            this.cbDatumZaposljenja = new System.Windows.Forms.CheckBox();
            this.cbLozinka = new System.Windows.Forms.CheckBox();
            this.cbKorisnickoIme = new System.Windows.Forms.CheckBox();
            this.cbPrezime = new System.Windows.Forms.CheckBox();
            this.cbIme = new System.Windows.Forms.CheckBox();
            this.cbSve = new System.Windows.Forms.CheckBox();
            this.btnPretraga = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPretraga = new System.Windows.Forms.TextBox();
            this.cbSortiraj = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisnici)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOtkazi.Location = new System.Drawing.Point(760, 561);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(75, 32);
            this.btnOtkazi.TabIndex = 19;
            this.btnOtkazi.Text = "Otkaži";
            this.btnOtkazi.UseVisualStyleBackColor = true;
            this.btnOtkazi.Click += new System.EventHandler(this.btnOtkazi_Click);
            // 
            // btnUrediKorisnika
            // 
            this.btnUrediKorisnika.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUrediKorisnika.Location = new System.Drawing.Point(575, 561);
            this.btnUrediKorisnika.Name = "btnUrediKorisnika";
            this.btnUrediKorisnika.Size = new System.Drawing.Size(169, 32);
            this.btnUrediKorisnika.TabIndex = 18;
            this.btnUrediKorisnika.Text = "Uredi korisnika";
            this.btnUrediKorisnika.UseVisualStyleBackColor = true;
            this.btnUrediKorisnika.Click += new System.EventHandler(this.btnUrediKorisnika_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(591, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "Uredi korisnika";
            // 
            // cbPosao
            // 
            this.cbPosao.FormattingEnabled = true;
            this.cbPosao.Items.AddRange(new object[] {
            "Administrator",
            "Menadzer",
            "Zaposleni"});
            this.cbPosao.Location = new System.Drawing.Point(798, 330);
            this.cbPosao.Name = "cbPosao";
            this.cbPosao.Size = new System.Drawing.Size(247, 21);
            this.cbPosao.TabIndex = 56;
            // 
            // btnGenerisi
            // 
            this.btnGenerisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerisi.Location = new System.Drawing.Point(530, 517);
            this.btnGenerisi.Name = "btnGenerisi";
            this.btnGenerisi.Size = new System.Drawing.Size(81, 33);
            this.btnGenerisi.TabIndex = 55;
            this.btnGenerisi.Text = "Generiši";
            this.btnGenerisi.UseVisualStyleBackColor = true;
            // 
            // dtpDatumIstekaUgovora
            // 
            this.dtpDatumIstekaUgovora.Location = new System.Drawing.Point(821, 518);
            this.dtpDatumIstekaUgovora.Name = "dtpDatumIstekaUgovora";
            this.dtpDatumIstekaUgovora.Size = new System.Drawing.Size(200, 20);
            this.dtpDatumIstekaUgovora.TabIndex = 54;
            // 
            // dtpDatumZaposlenja
            // 
            this.dtpDatumZaposlenja.Location = new System.Drawing.Point(821, 455);
            this.dtpDatumZaposlenja.Name = "dtpDatumZaposlenja";
            this.dtpDatumZaposlenja.Size = new System.Drawing.Size(200, 20);
            this.dtpDatumZaposlenja.TabIndex = 53;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(890, 300);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 24);
            this.label10.TabIndex = 52;
            this.label10.Text = "Posao";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(826, 491);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(190, 24);
            this.label9.TabIndex = 51;
            this.label9.Text = "Datum isteka ugovora";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(842, 428);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 24);
            this.label8.TabIndex = 50;
            this.label8.Text = "Datum zaposlenja";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(896, 365);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 24);
            this.label7.TabIndex = 49;
            this.label7.Text = "Plata";
            // 
            // tbPlata
            // 
            this.tbPlata.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPlata.Location = new System.Drawing.Point(798, 392);
            this.tbPlata.Name = "tbPlata";
            this.tbPlata.Size = new System.Drawing.Size(247, 32);
            this.tbPlata.TabIndex = 48;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(467, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 24);
            this.label6.TabIndex = 47;
            this.label6.Text = "Ime";
            // 
            // tbPrezime
            // 
            this.tbPrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrezime.Location = new System.Drawing.Point(361, 392);
            this.tbPrezime.Name = "tbPrezime";
            this.tbPrezime.Size = new System.Drawing.Size(247, 32);
            this.tbPrezime.TabIndex = 46;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(445, 365);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 24);
            this.label5.TabIndex = 45;
            this.label5.Text = "Prezime";
            // 
            // tbIme
            // 
            this.tbIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIme.Location = new System.Drawing.Point(364, 330);
            this.tbIme.Name = "tbIme";
            this.tbIme.Size = new System.Drawing.Size(247, 32);
            this.tbIme.TabIndex = 44;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(409, 491);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 24);
            this.label11.TabIndex = 43;
            this.label11.Text = "Lozinka";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(421, 428);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(133, 24);
            this.label12.TabIndex = 42;
            this.label12.Text = "Korisničko ime";
            // 
            // tbLozinka
            // 
            this.tbLozinka.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLozinka.Location = new System.Drawing.Point(364, 518);
            this.tbLozinka.Name = "tbLozinka";
            this.tbLozinka.Size = new System.Drawing.Size(160, 32);
            this.tbLozinka.TabIndex = 41;
            // 
            // tbKorIme
            // 
            this.tbKorIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbKorIme.Location = new System.Drawing.Point(364, 455);
            this.tbKorIme.Name = "tbKorIme";
            this.tbKorIme.Size = new System.Drawing.Size(247, 32);
            this.tbKorIme.TabIndex = 40;
            // 
            // dgvKorisnici
            // 
            this.dgvKorisnici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKorisnici.Location = new System.Drawing.Point(324, 45);
            this.dgvKorisnici.Name = "dgvKorisnici";
            this.dgvKorisnici.Size = new System.Drawing.Size(773, 250);
            this.dgvKorisnici.TabIndex = 57;
            this.dgvKorisnici.SelectionChanged += new System.EventHandler(this.dgvKorisnici_SelectionChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(52, 429);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 20);
            this.label2.TabIndex = 74;
            this.label2.Text = "Pretraga po datumu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(82, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 20);
            this.label4.TabIndex = 73;
            this.label4.Text = "Pretraga po kljucnoj reci";
            // 
            // cbId
            // 
            this.cbId.AutoSize = true;
            this.cbId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbId.ForeColor = System.Drawing.Color.White;
            this.cbId.Location = new System.Drawing.Point(29, 157);
            this.cbId.Name = "cbId";
            this.cbId.Size = new System.Drawing.Size(42, 24);
            this.cbId.TabIndex = 72;
            this.cbId.Text = "Id";
            this.cbId.UseVisualStyleBackColor = true;
            this.cbId.CheckedChanged += new System.EventHandler(this.cbId_CheckedChanged);
            // 
            // chbPosao
            // 
            this.chbPosao.AutoSize = true;
            this.chbPosao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbPosao.ForeColor = System.Drawing.Color.White;
            this.chbPosao.Location = new System.Drawing.Point(29, 354);
            this.chbPosao.Name = "chbPosao";
            this.chbPosao.Size = new System.Drawing.Size(73, 24);
            this.chbPosao.TabIndex = 71;
            this.chbPosao.Text = "Posao";
            this.chbPosao.UseVisualStyleBackColor = true;
            this.chbPosao.CheckedChanged += new System.EventHandler(this.cbId_CheckedChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(29, 554);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 70;
            // 
            // dtpDatumZaposljavanja
            // 
            this.dtpDatumZaposljavanja.Enabled = false;
            this.dtpDatumZaposljavanja.Location = new System.Drawing.Point(29, 492);
            this.dtpDatumZaposljavanja.Name = "dtpDatumZaposljavanja";
            this.dtpDatumZaposljavanja.Size = new System.Drawing.Size(200, 20);
            this.dtpDatumZaposljavanja.TabIndex = 69;
            // 
            // cbPlata
            // 
            this.cbPlata.AutoSize = true;
            this.cbPlata.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPlata.ForeColor = System.Drawing.Color.White;
            this.cbPlata.Location = new System.Drawing.Point(29, 393);
            this.cbPlata.Name = "cbPlata";
            this.cbPlata.Size = new System.Drawing.Size(64, 24);
            this.cbPlata.TabIndex = 68;
            this.cbPlata.Text = "Plata";
            this.cbPlata.UseVisualStyleBackColor = true;
            this.cbPlata.CheckedChanged += new System.EventHandler(this.cbId_CheckedChanged);
            // 
            // cbDatumIstekaUgovora
            // 
            this.cbDatumIstekaUgovora.AutoSize = true;
            this.cbDatumIstekaUgovora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDatumIstekaUgovora.ForeColor = System.Drawing.Color.White;
            this.cbDatumIstekaUgovora.Location = new System.Drawing.Point(29, 523);
            this.cbDatumIstekaUgovora.Name = "cbDatumIstekaUgovora";
            this.cbDatumIstekaUgovora.Size = new System.Drawing.Size(183, 24);
            this.cbDatumIstekaUgovora.TabIndex = 67;
            this.cbDatumIstekaUgovora.Text = "Datum isteka ugovora";
            this.cbDatumIstekaUgovora.UseVisualStyleBackColor = true;
            this.cbDatumIstekaUgovora.CheckedChanged += new System.EventHandler(this.cbDatumIstekaUgovora_CheckedChanged);
            // 
            // cbDatumZaposljenja
            // 
            this.cbDatumZaposljenja.AutoSize = true;
            this.cbDatumZaposljenja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDatumZaposljenja.ForeColor = System.Drawing.Color.White;
            this.cbDatumZaposljenja.Location = new System.Drawing.Point(29, 462);
            this.cbDatumZaposljenja.Name = "cbDatumZaposljenja";
            this.cbDatumZaposljenja.Size = new System.Drawing.Size(159, 24);
            this.cbDatumZaposljenja.TabIndex = 66;
            this.cbDatumZaposljenja.Text = "Datum zaposljenja";
            this.cbDatumZaposljenja.UseVisualStyleBackColor = true;
            this.cbDatumZaposljenja.CheckedChanged += new System.EventHandler(this.cbDatumZaposljenja_CheckedChanged);
            // 
            // cbLozinka
            // 
            this.cbLozinka.AutoSize = true;
            this.cbLozinka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLozinka.ForeColor = System.Drawing.Color.White;
            this.cbLozinka.Location = new System.Drawing.Point(29, 315);
            this.cbLozinka.Name = "cbLozinka";
            this.cbLozinka.Size = new System.Drawing.Size(83, 24);
            this.cbLozinka.TabIndex = 65;
            this.cbLozinka.Text = "Lozinka";
            this.cbLozinka.UseVisualStyleBackColor = true;
            this.cbLozinka.CheckedChanged += new System.EventHandler(this.cbId_CheckedChanged);
            // 
            // cbKorisnickoIme
            // 
            this.cbKorisnickoIme.AutoSize = true;
            this.cbKorisnickoIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKorisnickoIme.ForeColor = System.Drawing.Color.White;
            this.cbKorisnickoIme.Location = new System.Drawing.Point(29, 276);
            this.cbKorisnickoIme.Name = "cbKorisnickoIme";
            this.cbKorisnickoIme.Size = new System.Drawing.Size(129, 24);
            this.cbKorisnickoIme.TabIndex = 64;
            this.cbKorisnickoIme.Text = "Korisnicko ime";
            this.cbKorisnickoIme.UseVisualStyleBackColor = true;
            this.cbKorisnickoIme.CheckedChanged += new System.EventHandler(this.cbId_CheckedChanged);
            // 
            // cbPrezime
            // 
            this.cbPrezime.AutoSize = true;
            this.cbPrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPrezime.ForeColor = System.Drawing.Color.White;
            this.cbPrezime.Location = new System.Drawing.Point(29, 237);
            this.cbPrezime.Name = "cbPrezime";
            this.cbPrezime.Size = new System.Drawing.Size(85, 24);
            this.cbPrezime.TabIndex = 63;
            this.cbPrezime.Text = "Prezime";
            this.cbPrezime.UseVisualStyleBackColor = true;
            this.cbPrezime.CheckedChanged += new System.EventHandler(this.cbId_CheckedChanged);
            // 
            // cbIme
            // 
            this.cbIme.AutoSize = true;
            this.cbIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIme.ForeColor = System.Drawing.Color.White;
            this.cbIme.Location = new System.Drawing.Point(29, 197);
            this.cbIme.Name = "cbIme";
            this.cbIme.Size = new System.Drawing.Size(55, 24);
            this.cbIme.TabIndex = 62;
            this.cbIme.Text = "Ime";
            this.cbIme.UseVisualStyleBackColor = true;
            this.cbIme.CheckedChanged += new System.EventHandler(this.cbId_CheckedChanged);
            // 
            // cbSve
            // 
            this.cbSve.AutoSize = true;
            this.cbSve.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSve.ForeColor = System.Drawing.Color.White;
            this.cbSve.Location = new System.Drawing.Point(29, 127);
            this.cbSve.Name = "cbSve";
            this.cbSve.Size = new System.Drawing.Size(55, 24);
            this.cbSve.TabIndex = 61;
            this.cbSve.Text = "Sve";
            this.cbSve.UseVisualStyleBackColor = true;
            this.cbSve.CheckedChanged += new System.EventHandler(this.cbSve_CheckedChanged);
            // 
            // btnPretraga
            // 
            this.btnPretraga.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPretraga.Location = new System.Drawing.Point(202, 86);
            this.btnPretraga.Name = "btnPretraga";
            this.btnPretraga.Size = new System.Drawing.Size(76, 26);
            this.btnPretraga.TabIndex = 60;
            this.btnPretraga.Text = "Pretrazi";
            this.btnPretraga.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(113, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 31);
            this.label3.TabIndex = 59;
            this.label3.Text = "Pretraga";
            // 
            // tbPretraga
            // 
            this.tbPretraga.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPretraga.Location = new System.Drawing.Point(29, 86);
            this.tbPretraga.Name = "tbPretraga";
            this.tbPretraga.Size = new System.Drawing.Size(158, 26);
            this.tbPretraga.TabIndex = 58;
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
            this.cbSortiraj.Location = new System.Drawing.Point(884, 19);
            this.cbSortiraj.Name = "cbSortiraj";
            this.cbSortiraj.Size = new System.Drawing.Size(213, 23);
            this.cbSortiraj.TabIndex = 76;
            this.cbSortiraj.SelectedIndexChanged += new System.EventHandler(this.cbSortiraj_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(789, 19);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 20);
            this.label13.TabIndex = 75;
            this.label13.Text = "Sortiraj po: ";
            // 
            // formaAdminUrediKorisnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(1109, 605);
            this.Controls.Add(this.cbSortiraj);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbId);
            this.Controls.Add(this.chbPosao);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dtpDatumZaposljavanja);
            this.Controls.Add(this.cbPlata);
            this.Controls.Add(this.cbDatumIstekaUgovora);
            this.Controls.Add(this.cbDatumZaposljenja);
            this.Controls.Add(this.cbLozinka);
            this.Controls.Add(this.cbKorisnickoIme);
            this.Controls.Add(this.cbPrezime);
            this.Controls.Add(this.cbIme);
            this.Controls.Add(this.cbSve);
            this.Controls.Add(this.btnPretraga);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbPretraga);
            this.Controls.Add(this.dgvKorisnici);
            this.Controls.Add(this.cbPosao);
            this.Controls.Add(this.btnGenerisi);
            this.Controls.Add(this.dtpDatumIstekaUgovora);
            this.Controls.Add(this.dtpDatumZaposlenja);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbPlata);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbPrezime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbIme);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tbLozinka);
            this.Controls.Add(this.tbKorIme);
            this.Controls.Add(this.btnOtkazi);
            this.Controls.Add(this.btnUrediKorisnika);
            this.Controls.Add(this.label1);
            this.Name = "formaAdminUrediKorisnika";
            this.Text = "Admin - Uredi korisnika";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formaAdminUrediKorisnika_FormClosed);
            this.Load += new System.EventHandler(this.formaAdminUrediKorisnika_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisnici)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOtkazi;
        private System.Windows.Forms.Button btnUrediKorisnika;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbPosao;
        private System.Windows.Forms.Button btnGenerisi;
        private System.Windows.Forms.DateTimePicker dtpDatumIstekaUgovora;
        private System.Windows.Forms.DateTimePicker dtpDatumZaposlenja;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbPlata;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbPrezime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbIme;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbLozinka;
        private System.Windows.Forms.TextBox tbKorIme;
        private System.Windows.Forms.DataGridView dgvKorisnici;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbId;
        private System.Windows.Forms.CheckBox chbPosao;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dtpDatumZaposljavanja;
        private System.Windows.Forms.CheckBox cbPlata;
        private System.Windows.Forms.CheckBox cbDatumIstekaUgovora;
        private System.Windows.Forms.CheckBox cbDatumZaposljenja;
        private System.Windows.Forms.CheckBox cbLozinka;
        private System.Windows.Forms.CheckBox cbKorisnickoIme;
        private System.Windows.Forms.CheckBox cbPrezime;
        private System.Windows.Forms.CheckBox cbIme;
        private System.Windows.Forms.CheckBox cbSve;
        private System.Windows.Forms.Button btnPretraga;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPretraga;
        private System.Windows.Forms.ComboBox cbSortiraj;
        private System.Windows.Forms.Label label13;
    }
}