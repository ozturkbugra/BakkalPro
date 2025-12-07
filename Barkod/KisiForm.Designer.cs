namespace Barkod
{
    partial class KisiForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.panelGiris = new System.Windows.Forms.Panel();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelListe = new System.Windows.Forms.Panel();
            this.gridKisiler = new System.Windows.Forms.DataGridView();
            this.panelArama = new System.Windows.Forms.Panel();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.lblAra = new System.Windows.Forms.Label();
            this.panelGiris.SuspendLayout();
            this.panelListe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridKisiler)).BeginInit();
            this.panelArama.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelGiris
            // 
            this.panelGiris.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelGiris.Controls.Add(this.btnTemizle);
            this.panelGiris.Controls.Add(this.btnSil);
            this.panelGiris.Controls.Add(this.btnGuncelle);
            this.panelGiris.Controls.Add(this.btnEkle);
            this.panelGiris.Controls.Add(this.txtAdres);
            this.panelGiris.Controls.Add(this.label4);
            this.panelGiris.Controls.Add(this.txtTelefon);
            this.panelGiris.Controls.Add(this.label3);
            this.panelGiris.Controls.Add(this.txtTc);
            this.panelGiris.Controls.Add(this.label2);
            this.panelGiris.Controls.Add(this.txtAdSoyad);
            this.panelGiris.Controls.Add(this.label1);
            this.panelGiris.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelGiris.Location = new System.Drawing.Point(0, 0);
            this.panelGiris.Name = "panelGiris";
            this.panelGiris.Size = new System.Drawing.Size(900, 200);
            this.panelGiris.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad Soyad:";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(100, 22);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(200, 20);
            this.txtAdSoyad.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "TC No:";
            // 
            // txtTc
            // 
            this.txtTc.Location = new System.Drawing.Point(100, 57);
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(200, 20);
            this.txtTc.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(350, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Telefon:";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(410, 22);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(150, 20);
            this.txtTelefon.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(350, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Adres:";
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(410, 57);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(300, 50);
            this.txtAdres.TabIndex = 4;
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.SeaGreen;
            this.btnEkle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEkle.ForeColor = System.Drawing.Color.White;
            this.btnEkle.Location = new System.Drawing.Point(100, 130);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(100, 40);
            this.btnEkle.TabIndex = 5;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnGuncelle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnGuncelle.ForeColor = System.Drawing.Color.White;
            this.btnGuncelle.Location = new System.Drawing.Point(210, 130);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(100, 40);
            this.btnGuncelle.TabIndex = 6;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Crimson;
            this.btnSil.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSil.ForeColor = System.Drawing.Color.White;
            this.btnSil.Location = new System.Drawing.Point(320, 130);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(100, 40);
            this.btnSil.TabIndex = 7;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.Gray;
            this.btnTemizle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTemizle.ForeColor = System.Drawing.Color.White;
            this.btnTemizle.Location = new System.Drawing.Point(450, 130);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(100, 40);
            this.btnTemizle.TabIndex = 8;
            this.btnTemizle.Text = "TEMİZLE";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // panelListe
            // 
            this.panelListe.Controls.Add(this.gridKisiler);
            this.panelListe.Controls.Add(this.panelArama);
            this.panelListe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelListe.Location = new System.Drawing.Point(0, 200);
            this.panelListe.Name = "panelListe";
            this.panelListe.Size = new System.Drawing.Size(900, 400);
            this.panelListe.TabIndex = 1;
            // 
            // panelArama
            // 
            this.panelArama.Controls.Add(this.txtAra);
            this.panelArama.Controls.Add(this.lblAra);
            this.panelArama.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelArama.Height = 50;
            this.panelArama.Location = new System.Drawing.Point(0, 0);
            this.panelArama.Name = "panelArama";
            this.panelArama.Size = new System.Drawing.Size(900, 50);
            this.panelArama.TabIndex = 0;
            // 
            // lblAra
            // 
            this.lblAra.AutoSize = true;
            this.lblAra.Location = new System.Drawing.Point(12, 18);
            this.lblAra.Name = "lblAra";
            this.lblAra.Size = new System.Drawing.Size(65, 13);
            this.lblAra.TabIndex = 0;
            this.lblAra.Text = "Müşteri Ara:";
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(83, 15);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(300, 20);
            this.txtAra.TabIndex = 1;
            this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
            // 
            // gridKisiler
            // 
            this.gridKisiler.AllowUserToAddRows = false;
            this.gridKisiler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridKisiler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridKisiler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridKisiler.Location = new System.Drawing.Point(0, 50);
            this.gridKisiler.Name = "gridKisiler";
            this.gridKisiler.ReadOnly = true;
            this.gridKisiler.RowHeadersVisible = false;
            this.gridKisiler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridKisiler.Size = new System.Drawing.Size(900, 350);
            this.gridKisiler.TabIndex = 1;
            this.gridKisiler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridKisiler_CellClick);
            // 
            // KisiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.panelListe);
            this.Controls.Add(this.panelGiris);
            this.Name = "KisiForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kişi Yönetimi";
            this.Load += new System.EventHandler(this.KisiForm_Load);
            this.panelGiris.ResumeLayout(false);
            this.panelGiris.PerformLayout();
            this.panelListe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridKisiler)).EndInit();
            this.panelArama.ResumeLayout(false);
            this.panelArama.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelGiris;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Panel panelListe;
        private System.Windows.Forms.DataGridView gridKisiler;
        private System.Windows.Forms.Panel panelArama;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Label lblAra;
    }
}