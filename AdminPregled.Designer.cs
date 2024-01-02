namespace Diplomski
{
    partial class formaAdminPregled
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
            this.btnPregledKorisnika = new System.Windows.Forms.Button();
            this.btnDodajKorisnika = new System.Windows.Forms.Button();
            this.btnUrediKorisnika = new System.Windows.Forms.Button();
            this.btnUkloniKorisnika = new System.Windows.Forms.Button();
            this.btnBazaNabavke = new System.Windows.Forms.Button();
            this.btnBazaProizvodi = new System.Windows.Forms.Button();
            this.btnBazaRacuni = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOdjava = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(278, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Rad sa korisnicima";
            // 
            // btnPregledKorisnika
            // 
            this.btnPregledKorisnika.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPregledKorisnika.Location = new System.Drawing.Point(267, 214);
            this.btnPregledKorisnika.Name = "btnPregledKorisnika";
            this.btnPregledKorisnika.Size = new System.Drawing.Size(189, 37);
            this.btnPregledKorisnika.TabIndex = 12;
            this.btnPregledKorisnika.Text = "Pregled korisnika";
            this.btnPregledKorisnika.UseVisualStyleBackColor = true;
            this.btnPregledKorisnika.Click += new System.EventHandler(this.btnPregledKorisnika_Click);
            // 
            // btnDodajKorisnika
            // 
            this.btnDodajKorisnika.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajKorisnika.Location = new System.Drawing.Point(267, 281);
            this.btnDodajKorisnika.Name = "btnDodajKorisnika";
            this.btnDodajKorisnika.Size = new System.Drawing.Size(189, 37);
            this.btnDodajKorisnika.TabIndex = 13;
            this.btnDodajKorisnika.Text = "Dodaj korisnika";
            this.btnDodajKorisnika.UseVisualStyleBackColor = true;
            this.btnDodajKorisnika.Click += new System.EventHandler(this.btnDodajKorisnika_Click);
            // 
            // btnUrediKorisnika
            // 
            this.btnUrediKorisnika.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUrediKorisnika.Location = new System.Drawing.Point(267, 348);
            this.btnUrediKorisnika.Name = "btnUrediKorisnika";
            this.btnUrediKorisnika.Size = new System.Drawing.Size(189, 37);
            this.btnUrediKorisnika.TabIndex = 14;
            this.btnUrediKorisnika.Text = "Uredi korisnika";
            this.btnUrediKorisnika.UseVisualStyleBackColor = true;
            this.btnUrediKorisnika.Click += new System.EventHandler(this.btnUrediKorisnika_Click);
            // 
            // btnUkloniKorisnika
            // 
            this.btnUkloniKorisnika.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUkloniKorisnika.Location = new System.Drawing.Point(267, 415);
            this.btnUkloniKorisnika.Name = "btnUkloniKorisnika";
            this.btnUkloniKorisnika.Size = new System.Drawing.Size(189, 37);
            this.btnUkloniKorisnika.TabIndex = 15;
            this.btnUkloniKorisnika.Text = "Ukloni korisnika";
            this.btnUkloniKorisnika.UseVisualStyleBackColor = true;
            this.btnUkloniKorisnika.Click += new System.EventHandler(this.btnUkloniKorisnika_Click);
            // 
            // btnBazaNabavke
            // 
            this.btnBazaNabavke.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBazaNabavke.Location = new System.Drawing.Point(683, 348);
            this.btnBazaNabavke.Name = "btnBazaNabavke";
            this.btnBazaNabavke.Size = new System.Drawing.Size(189, 37);
            this.btnBazaNabavke.TabIndex = 19;
            this.btnBazaNabavke.Text = "Baza nabavke";
            this.btnBazaNabavke.UseVisualStyleBackColor = true;
            this.btnBazaNabavke.Click += new System.EventHandler(this.btnBazaNabavke_Click);
            // 
            // btnBazaProizvodi
            // 
            this.btnBazaProizvodi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBazaProizvodi.Location = new System.Drawing.Point(683, 281);
            this.btnBazaProizvodi.Name = "btnBazaProizvodi";
            this.btnBazaProizvodi.Size = new System.Drawing.Size(189, 37);
            this.btnBazaProizvodi.TabIndex = 18;
            this.btnBazaProizvodi.Text = "Baza proizvoda";
            this.btnBazaProizvodi.UseVisualStyleBackColor = true;
            this.btnBazaProizvodi.Click += new System.EventHandler(this.btnBazaProizvodi_Click);
            // 
            // btnBazaRacuni
            // 
            this.btnBazaRacuni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBazaRacuni.Location = new System.Drawing.Point(683, 214);
            this.btnBazaRacuni.Name = "btnBazaRacuni";
            this.btnBazaRacuni.Size = new System.Drawing.Size(189, 37);
            this.btnBazaRacuni.TabIndex = 17;
            this.btnBazaRacuni.Text = "Baza računi";
            this.btnBazaRacuni.UseVisualStyleBackColor = true;
            this.btnBazaRacuni.Click += new System.EventHandler(this.btnBazaRacuni_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(711, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "Rad sa bazama";
            // 
            // btnOdjava
            // 
            this.btnOdjava.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdjava.Location = new System.Drawing.Point(958, 556);
            this.btnOdjava.Name = "btnOdjava";
            this.btnOdjava.Size = new System.Drawing.Size(139, 37);
            this.btnOdjava.TabIndex = 20;
            this.btnOdjava.Text = "Odjavi se";
            this.btnOdjava.UseVisualStyleBackColor = true;
            this.btnOdjava.Click += new System.EventHandler(this.btnOdjava_Click);
            // 
            // formaAdminPregled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(1109, 605);
            this.Controls.Add(this.btnOdjava);
            this.Controls.Add(this.btnBazaNabavke);
            this.Controls.Add(this.btnBazaProizvodi);
            this.Controls.Add(this.btnBazaRacuni);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnUkloniKorisnika);
            this.Controls.Add(this.btnUrediKorisnika);
            this.Controls.Add(this.btnDodajKorisnika);
            this.Controls.Add(this.btnPregledKorisnika);
            this.Controls.Add(this.label1);
            this.Name = "formaAdminPregled";
            this.Text = "Admin - Pregled";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formaAdminPregled_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPregledKorisnika;
        private System.Windows.Forms.Button btnDodajKorisnika;
        private System.Windows.Forms.Button btnUrediKorisnika;
        private System.Windows.Forms.Button btnUkloniKorisnika;
        private System.Windows.Forms.Button btnBazaNabavke;
        private System.Windows.Forms.Button btnBazaProizvodi;
        private System.Windows.Forms.Button btnBazaRacuni;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOdjava;
    }
}