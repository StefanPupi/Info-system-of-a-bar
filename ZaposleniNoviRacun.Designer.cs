namespace Diplomski
{
    partial class formaZaposleniNoviRacun
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
            this.btnDodajNovRacun = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOtkazi = new System.Windows.Forms.Button();
            this.btnDodajProizvod = new System.Windows.Forms.Button();
            this.btnUkloniProizvod = new System.Windows.Forms.Button();
            this.dgvRacun = new System.Windows.Forms.DataGridView();
            this.dgvArtikli = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRacun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtikli)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(669, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 31);
            this.label1.TabIndex = 33;
            this.label1.Text = "Svi proizvodi";
            // 
            // btnDodajNovRacun
            // 
            this.btnDodajNovRacun.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajNovRacun.Location = new System.Drawing.Point(102, 457);
            this.btnDodajNovRacun.Name = "btnDodajNovRacun";
            this.btnDodajNovRacun.Size = new System.Drawing.Size(169, 32);
            this.btnDodajNovRacun.TabIndex = 34;
            this.btnDodajNovRacun.Text = "Dodaj novi racun";
            this.btnDodajNovRacun.UseVisualStyleBackColor = true;
            this.btnDodajNovRacun.Click += new System.EventHandler(this.btnDodajNovRacun_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(117, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 31);
            this.label2.TabIndex = 35;
            this.label2.Text = "Nov račun";
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOtkazi.Location = new System.Drawing.Point(102, 551);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(169, 32);
            this.btnOtkazi.TabIndex = 37;
            this.btnOtkazi.Text = "Otkaži";
            this.btnOtkazi.UseVisualStyleBackColor = true;
            this.btnOtkazi.Click += new System.EventHandler(this.btnOtkazi_Click);
            // 
            // btnDodajProizvod
            // 
            this.btnDodajProizvod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajProizvod.Location = new System.Drawing.Point(659, 498);
            this.btnDodajProizvod.Name = "btnDodajProizvod";
            this.btnDodajProizvod.Size = new System.Drawing.Size(169, 32);
            this.btnDodajProizvod.TabIndex = 38;
            this.btnDodajProizvod.Text = "Dodaj proizvod";
            this.btnDodajProizvod.UseVisualStyleBackColor = true;
            this.btnDodajProizvod.Click += new System.EventHandler(this.btnDodajProizvod_Click);
            // 
            // btnUkloniProizvod
            // 
            this.btnUkloniProizvod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUkloniProizvod.Location = new System.Drawing.Point(102, 504);
            this.btnUkloniProizvod.Name = "btnUkloniProizvod";
            this.btnUkloniProizvod.Size = new System.Drawing.Size(169, 32);
            this.btnUkloniProizvod.TabIndex = 39;
            this.btnUkloniProizvod.Text = "Ukloni proizvod";
            this.btnUkloniProizvod.UseVisualStyleBackColor = true;
            // 
            // dgvRacun
            // 
            this.dgvRacun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRacun.Location = new System.Drawing.Point(30, 50);
            this.dgvRacun.Name = "dgvRacun";
            this.dgvRacun.Size = new System.Drawing.Size(313, 391);
            this.dgvRacun.TabIndex = 40;
            // 
            // dgvArtikli
            // 
            this.dgvArtikli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArtikli.Location = new System.Drawing.Point(428, 91);
            this.dgvArtikli.Name = "dgvArtikli";
            this.dgvArtikli.Size = new System.Drawing.Size(644, 391);
            this.dgvArtikli.TabIndex = 41;
            this.dgvArtikli.SelectionChanged += new System.EventHandler(this.dgvArtikli_SelectionChanged);
            // 
            // formaZaposleniNoviRacun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(1109, 605);
            this.Controls.Add(this.dgvArtikli);
            this.Controls.Add(this.dgvRacun);
            this.Controls.Add(this.btnUkloniProizvod);
            this.Controls.Add(this.btnDodajProizvod);
            this.Controls.Add(this.btnOtkazi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDodajNovRacun);
            this.Controls.Add(this.label1);
            this.Name = "formaZaposleniNoviRacun";
            this.Text = "Zaposleni - Novi racun";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formaZaposleniNoviRacun_FormClosed);
            this.Load += new System.EventHandler(this.formaZaposleniNoviRacun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRacun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtikli)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDodajNovRacun;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOtkazi;
        private System.Windows.Forms.Button btnDodajProizvod;
        private System.Windows.Forms.Button btnUkloniProizvod;
        private System.Windows.Forms.DataGridView dgvRacun;
        private System.Windows.Forms.DataGridView dgvArtikli;
    }
}