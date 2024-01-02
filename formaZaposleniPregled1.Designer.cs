
namespace Diplomski
{
    partial class formaZaposleniPregled1
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
            this.dgvTrenutniRacun = new System.Windows.Forms.DataGridView();
            this.dgvAktivniRacuni = new System.Windows.Forms.DataGridView();
            this.lblPovracaj = new System.Windows.Forms.Label();
            this.lblNaplata = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOdjava = new System.Windows.Forms.Button();
            this.btnSviRac = new System.Windows.Forms.Button();
            this.btnNaplati = new System.Windows.Forms.Button();
            this.btnUrediRac = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNovRac = new System.Windows.Forms.Button();
            this.btnVidiRacun = new System.Windows.Forms.Button();
            this.tbUplaceno = new System.Windows.Forms.TextBox();
            this.btnStorniraj = new System.Windows.Forms.Button();
            this.btnIzvestaji = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrenutniRacun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAktivniRacuni)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTrenutniRacun
            // 
            this.dgvTrenutniRacun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrenutniRacun.Location = new System.Drawing.Point(701, 57);
            this.dgvTrenutniRacun.Name = "dgvTrenutniRacun";
            this.dgvTrenutniRacun.Size = new System.Drawing.Size(349, 475);
            this.dgvTrenutniRacun.TabIndex = 32;
            // 
            // dgvAktivniRacuni
            // 
            this.dgvAktivniRacuni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAktivniRacuni.Location = new System.Drawing.Point(329, 57);
            this.dgvAktivniRacuni.Name = "dgvAktivniRacuni";
            this.dgvAktivniRacuni.Size = new System.Drawing.Size(349, 475);
            this.dgvAktivniRacuni.TabIndex = 31;
            this.dgvAktivniRacuni.SelectionChanged += new System.EventHandler(this.dgvAktivniRacuni_SelectionChanged);
            // 
            // lblPovracaj
            // 
            this.lblPovracaj.AutoSize = true;
            this.lblPovracaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPovracaj.ForeColor = System.Drawing.Color.White;
            this.lblPovracaj.Location = new System.Drawing.Point(174, 300);
            this.lblPovracaj.Name = "lblPovracaj";
            this.lblPovracaj.Size = new System.Drawing.Size(60, 25);
            this.lblPovracaj.TabIndex = 30;
            this.lblPovracaj.Text = "0 rsd";
            // 
            // lblNaplata
            // 
            this.lblNaplata.AutoSize = true;
            this.lblNaplata.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaplata.ForeColor = System.Drawing.Color.White;
            this.lblNaplata.Location = new System.Drawing.Point(174, 205);
            this.lblNaplata.Name = "lblNaplata";
            this.lblNaplata.Size = new System.Drawing.Size(60, 25);
            this.lblNaplata.TabIndex = 28;
            this.lblNaplata.Text = "0 rsd";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(34, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 25);
            this.label5.TabIndex = 27;
            this.label5.Text = "Povraćaj:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(34, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 25);
            this.label4.TabIndex = 26;
            this.label4.Text = "Plaćeno:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(34, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 25);
            this.label3.TabIndex = 25;
            this.label3.Text = "Za naplatu:";
            // 
            // btnOdjava
            // 
            this.btnOdjava.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdjava.Location = new System.Drawing.Point(932, 548);
            this.btnOdjava.Name = "btnOdjava";
            this.btnOdjava.Size = new System.Drawing.Size(131, 40);
            this.btnOdjava.TabIndex = 24;
            this.btnOdjava.Text = "Odjavi se";
            this.btnOdjava.UseVisualStyleBackColor = true;
            this.btnOdjava.Click += new System.EventHandler(this.btnOdjava_Click);
            // 
            // btnSviRac
            // 
            this.btnSviRac.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSviRac.Location = new System.Drawing.Point(70, 503);
            this.btnSviRac.Name = "btnSviRac";
            this.btnSviRac.Size = new System.Drawing.Size(131, 40);
            this.btnSviRac.TabIndex = 23;
            this.btnSviRac.Text = "Svi računi";
            this.btnSviRac.UseVisualStyleBackColor = true;
            this.btnSviRac.Click += new System.EventHandler(this.btnSviRac_Click);
            // 
            // btnNaplati
            // 
            this.btnNaplati.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNaplati.Location = new System.Drawing.Point(70, 362);
            this.btnNaplati.Name = "btnNaplati";
            this.btnNaplati.Size = new System.Drawing.Size(131, 40);
            this.btnNaplati.TabIndex = 22;
            this.btnNaplati.Text = "Naplati";
            this.btnNaplati.UseVisualStyleBackColor = true;
            this.btnNaplati.Click += new System.EventHandler(this.btnNaplati_Click);
            // 
            // btnUrediRac
            // 
            this.btnUrediRac.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUrediRac.Location = new System.Drawing.Point(60, 80);
            this.btnUrediRac.Name = "btnUrediRac";
            this.btnUrediRac.Size = new System.Drawing.Size(151, 40);
            this.btnUrediRac.TabIndex = 21;
            this.btnUrediRac.Text = "Dodaj na račun";
            this.btnUrediRac.UseVisualStyleBackColor = true;
            this.btnUrediRac.Click += new System.EventHandler(this.btnUrediRac_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(438, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "Aktivni računi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(806, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Trenutni račun";
            // 
            // btnNovRac
            // 
            this.btnNovRac.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovRac.Location = new System.Drawing.Point(70, 17);
            this.btnNovRac.Name = "btnNovRac";
            this.btnNovRac.Size = new System.Drawing.Size(131, 40);
            this.btnNovRac.TabIndex = 18;
            this.btnNovRac.Text = "Nov račun";
            this.btnNovRac.UseVisualStyleBackColor = true;
            this.btnNovRac.Click += new System.EventHandler(this.btnNovRac_Click);
            // 
            // btnVidiRacun
            // 
            this.btnVidiRacun.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVidiRacun.Location = new System.Drawing.Point(70, 423);
            this.btnVidiRacun.Name = "btnVidiRacun";
            this.btnVidiRacun.Size = new System.Drawing.Size(131, 60);
            this.btnVidiRacun.TabIndex = 33;
            this.btnVidiRacun.Text = "Pregledaj racun";
            this.btnVidiRacun.UseVisualStyleBackColor = true;
            this.btnVidiRacun.Click += new System.EventHandler(this.btnVidiRacun_Click);
            // 
            // tbUplaceno
            // 
            this.tbUplaceno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUplaceno.Location = new System.Drawing.Point(154, 252);
            this.tbUplaceno.Name = "tbUplaceno";
            this.tbUplaceno.Size = new System.Drawing.Size(100, 26);
            this.tbUplaceno.TabIndex = 34;
            this.tbUplaceno.TextChanged += new System.EventHandler(this.tbUplaceno_TextChanged);
            // 
            // btnStorniraj
            // 
            this.btnStorniraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStorniraj.Location = new System.Drawing.Point(60, 138);
            this.btnStorniraj.Name = "btnStorniraj";
            this.btnStorniraj.Size = new System.Drawing.Size(151, 40);
            this.btnStorniraj.TabIndex = 35;
            this.btnStorniraj.Text = "Storniraj";
            this.btnStorniraj.UseVisualStyleBackColor = true;
            this.btnStorniraj.Click += new System.EventHandler(this.btnStorniraj_Click);
            // 
            // btnIzvestaji
            // 
            this.btnIzvestaji.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzvestaji.Location = new System.Drawing.Point(70, 553);
            this.btnIzvestaji.Name = "btnIzvestaji";
            this.btnIzvestaji.Size = new System.Drawing.Size(131, 40);
            this.btnIzvestaji.TabIndex = 36;
            this.btnIzvestaji.Text = "Izvestaji";
            this.btnIzvestaji.UseVisualStyleBackColor = true;
            this.btnIzvestaji.Click += new System.EventHandler(this.btnIzvestaji_Click);
            // 
            // formaZaposleniPregled1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(1109, 605);
            this.Controls.Add(this.btnIzvestaji);
            this.Controls.Add(this.btnStorniraj);
            this.Controls.Add(this.tbUplaceno);
            this.Controls.Add(this.btnVidiRacun);
            this.Controls.Add(this.dgvTrenutniRacun);
            this.Controls.Add(this.dgvAktivniRacuni);
            this.Controls.Add(this.lblPovracaj);
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
            this.Name = "formaZaposleniPregled1";
            this.Text = "formaZaposleniPregled1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formaZaposleniPregled1_FormClosed);
            this.Load += new System.EventHandler(this.formaZaposleniPregled1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrenutniRacun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAktivniRacuni)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTrenutniRacun;
        private System.Windows.Forms.DataGridView dgvAktivniRacuni;
        private System.Windows.Forms.Label lblPovracaj;
        private System.Windows.Forms.Label lblNaplata;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOdjava;
        private System.Windows.Forms.Button btnSviRac;
        private System.Windows.Forms.Button btnNaplati;
        private System.Windows.Forms.Button btnUrediRac;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNovRac;
        private System.Windows.Forms.Button btnVidiRacun;
        private System.Windows.Forms.TextBox tbUplaceno;
        private System.Windows.Forms.Button btnStorniraj;
        private System.Windows.Forms.Button btnIzvestaji;
    }
}