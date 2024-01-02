namespace Diplomski
{
    partial class formaZaposleniPregled
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
            this.btnNovRac = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUrediRac = new System.Windows.Forms.Button();
            this.btnNaplati = new System.Windows.Forms.Button();
            this.btnSviRac = new System.Windows.Forms.Button();
            this.btnOdjava = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblNaplata = new System.Windows.Forms.Label();
            this.lblPlaceno = new System.Windows.Forms.Label();
            this.lblPovracaj = new System.Windows.Forms.Label();
            this.dgvAktivniRacuni = new System.Windows.Forms.DataGridView();
            this.dgvTrenutniRacun = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAktivniRacuni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrenutniRacun)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNovRac
            // 
            this.btnNovRac.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovRac.Location = new System.Drawing.Point(116, 50);
            this.btnNovRac.Name = "btnNovRac";
            this.btnNovRac.Size = new System.Drawing.Size(131, 40);
            this.btnNovRac.TabIndex = 0;
            this.btnNovRac.Text = "Nov račun";
            this.btnNovRac.UseVisualStyleBackColor = true;
            this.btnNovRac.Click += new System.EventHandler(this.btnNovRac_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(485, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Trenutni račun";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(880, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Svi računi";
            // 
            // btnUrediRac
            // 
            this.btnUrediRac.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUrediRac.Location = new System.Drawing.Point(116, 121);
            this.btnUrediRac.Name = "btnUrediRac";
            this.btnUrediRac.Size = new System.Drawing.Size(131, 40);
            this.btnUrediRac.TabIndex = 5;
            this.btnUrediRac.Text = "Uredi račun";
            this.btnUrediRac.UseVisualStyleBackColor = true;
            this.btnUrediRac.Click += new System.EventHandler(this.btnUrediRac_Click);
            // 
            // btnNaplati
            // 
            this.btnNaplati.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNaplati.Location = new System.Drawing.Point(116, 356);
            this.btnNaplati.Name = "btnNaplati";
            this.btnNaplati.Size = new System.Drawing.Size(131, 40);
            this.btnNaplati.TabIndex = 6;
            this.btnNaplati.Text = "Naplati";
            this.btnNaplati.UseVisualStyleBackColor = true;
            // 
            // btnSviRac
            // 
            this.btnSviRac.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSviRac.Location = new System.Drawing.Point(116, 469);
            this.btnSviRac.Name = "btnSviRac";
            this.btnSviRac.Size = new System.Drawing.Size(131, 40);
            this.btnSviRac.TabIndex = 7;
            this.btnSviRac.Text = "Svi računi";
            this.btnSviRac.UseVisualStyleBackColor = true;
            this.btnSviRac.Click += new System.EventHandler(this.btnSviRac_Click);
            // 
            // btnOdjava
            // 
            this.btnOdjava.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdjava.Location = new System.Drawing.Point(966, 553);
            this.btnOdjava.Name = "btnOdjava";
            this.btnOdjava.Size = new System.Drawing.Size(131, 40);
            this.btnOdjava.TabIndex = 8;
            this.btnOdjava.Text = "Odjavi se";
            this.btnOdjava.UseVisualStyleBackColor = true;
            this.btnOdjava.Click += new System.EventHandler(this.btnOdjava_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(80, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Za naplatu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(80, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Plaćeno:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(80, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Povraćaj:";
            // 
            // lblNaplata
            // 
            this.lblNaplata.AutoSize = true;
            this.lblNaplata.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaplata.ForeColor = System.Drawing.Color.White;
            this.lblNaplata.Location = new System.Drawing.Point(220, 199);
            this.lblNaplata.Name = "lblNaplata";
            this.lblNaplata.Size = new System.Drawing.Size(60, 25);
            this.lblNaplata.TabIndex = 12;
            this.lblNaplata.Text = "0 rsd";
            // 
            // lblPlaceno
            // 
            this.lblPlaceno.AutoSize = true;
            this.lblPlaceno.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaceno.ForeColor = System.Drawing.Color.White;
            this.lblPlaceno.Location = new System.Drawing.Point(220, 246);
            this.lblPlaceno.Name = "lblPlaceno";
            this.lblPlaceno.Size = new System.Drawing.Size(60, 25);
            this.lblPlaceno.TabIndex = 13;
            this.lblPlaceno.Text = "0 rsd";
            // 
            // lblPovracaj
            // 
            this.lblPovracaj.AutoSize = true;
            this.lblPovracaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPovracaj.ForeColor = System.Drawing.Color.White;
            this.lblPovracaj.Location = new System.Drawing.Point(220, 294);
            this.lblPovracaj.Name = "lblPovracaj";
            this.lblPovracaj.Size = new System.Drawing.Size(60, 25);
            this.lblPovracaj.TabIndex = 14;
            this.lblPovracaj.Text = "0 rsd";
            // 
            // dgvAktivniRacuni
            // 
            this.dgvAktivniRacuni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAktivniRacuni.Location = new System.Drawing.Point(748, 62);
            this.dgvAktivniRacuni.Name = "dgvAktivniRacuni";
            this.dgvAktivniRacuni.Size = new System.Drawing.Size(349, 475);
            this.dgvAktivniRacuni.TabIndex = 16;
            // 
            // dgvTrenutniRacun
            // 
            this.dgvTrenutniRacun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrenutniRacun.Location = new System.Drawing.Point(380, 65);
            this.dgvTrenutniRacun.Name = "dgvTrenutniRacun";
            this.dgvTrenutniRacun.Size = new System.Drawing.Size(349, 475);
            this.dgvTrenutniRacun.TabIndex = 17;
            // 
            // formaZaposleniPregled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(1109, 605);
            this.Controls.Add(this.dgvTrenutniRacun);
            this.Controls.Add(this.dgvAktivniRacuni);
            this.Controls.Add(this.lblPovracaj);
            this.Controls.Add(this.lblPlaceno);
            this.Controls.Add(this.lblNaplata);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnOdjava);
            this.Controls.Add(this.btnSviRac);
            this.Controls.Add(this.btnNaplati);
            this.Controls.Add(this.btnUrediRac);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNovRac);
            this.Name = "formaZaposleniPregled";
            this.Text = "Zaposleni - Pregled";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAktivniRacuni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrenutniRacun)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNovRac;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUrediRac;
        private System.Windows.Forms.Button btnNaplati;
        private System.Windows.Forms.Button btnSviRac;
        private System.Windows.Forms.Button btnOdjava;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblNaplata;
        private System.Windows.Forms.Label lblPlaceno;
        private System.Windows.Forms.Label lblPovracaj;
        private System.Windows.Forms.DataGridView dgvAktivniRacuni;
        private System.Windows.Forms.DataGridView dgvTrenutniRacun;
    }
}