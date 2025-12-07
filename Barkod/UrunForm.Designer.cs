namespace Barkod
{
    partial class UrunForm
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
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtStok = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSatisFiyat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAlisFiyat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBarkod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelListe = new System.Windows.Forms.Panel();
            this.gridUrunler = new System.Windows.Forms.DataGridView();
            this.panelArama = new System.Windows.Forms.Panel();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.lblAra = new System.Windows.Forms.Label();
            this.panelGiris.SuspendLayout();
            this.panelListe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridUrunler)).BeginInit();
            this.panelArama.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelGiris (Veri Giriş Alanı)
            // 
            this.panelGiris.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelGiris.Controls.Add(this.cmbKategori);
            this.panelGiris.Controls.Add(this.btnTemizle);
            this.panelGiris.Controls.Add(this.btnSil);
            this.panelGiris.Controls.Add(this.btnGuncelle);
            this.panelGiris.Controls.Add(this.btnEkle);
            this.panelGiris.Controls.Add(this.txtStok);
            this.panelGiris.Controls.Add(this.label6);
            this.panelGiris.Controls.Add(this.txtSatisFiyat);
            this.panelGiris.Controls.Add(this.label5);
            this.panelGiris.Controls.Add(this.txtAlisFiyat);
            this.panelGiris.Controls.Add(this.label4);
            this.panelGiris.Controls.Add(this.label3);
            this.panelGiris.Controls.Add(this.txtUrunAdi);
            this.panelGiris.Controls.Add(this.label2);
            this.panelGiris.Controls.Add(this.txtBarkod);
            this.panelGiris.Controls.Add(this.label1);
            this.panelGiris.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelGiris.Location = new System.Drawing.Point(0, 0);
            this.panelGiris.Name = "panelGiris";
            this.panelGiris.Size = new System.Drawing.Size(1000, 220);
            this.panelGiris.TabIndex = 0;
            // 
            // label1..6 ve Textboxlar
            // 
            this.label1.AutoSize = true; this.label1.Location = new System.Drawing.Point(30, 20); this.label1.Text = "Barkod:";
            this.txtBarkod.Location = new System.Drawing.Point(100, 17); this.txtBarkod.Size = new System.Drawing.Size(150, 20);

            this.label2.AutoSize = true; this.label2.Location = new System.Drawing.Point(30, 50); this.label2.Text = "Ürün Adı:";
            this.txtUrunAdi.Location = new System.Drawing.Point(100, 47); this.txtUrunAdi.Size = new System.Drawing.Size(250, 20);

            this.label3.AutoSize = true; this.label3.Location = new System.Drawing.Point(30, 80); this.label3.Text = "Kategori:";
            this.cmbKategori.Location = new System.Drawing.Point(100, 77); this.cmbKategori.Size = new System.Drawing.Size(150, 21);
            this.cmbKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.label4.AutoSize = true; this.label4.Location = new System.Drawing.Point(400, 20); this.label4.Text = "Alış Fiyatı:";
            this.txtAlisFiyat.Location = new System.Drawing.Point(470, 17); this.txtAlisFiyat.Size = new System.Drawing.Size(100, 20);

            this.label5.AutoSize = true; this.label5.Location = new System.Drawing.Point(400, 50); this.label5.Text = "Satış Fiyatı:";
            this.txtSatisFiyat.Location = new System.Drawing.Point(470, 47); this.txtSatisFiyat.Size = new System.Drawing.Size(100, 20);

            this.label6.AutoSize = true; this.label6.Location = new System.Drawing.Point(400, 80); this.label6.Text = "Stok Adeti:";
            this.txtStok.Location = new System.Drawing.Point(470, 77); this.txtStok.Size = new System.Drawing.Size(100, 20);

            // 
            // BUTONLAR
            // 
            this.btnEkle.BackColor = System.Drawing.Color.SeaGreen;
            this.btnEkle.ForeColor = System.Drawing.Color.White;
            this.btnEkle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEkle.Location = new System.Drawing.Point(100, 130);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(100, 40);
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);

            this.btnGuncelle.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnGuncelle.ForeColor = System.Drawing.Color.White;
            this.btnGuncelle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnGuncelle.Location = new System.Drawing.Point(210, 130);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(100, 40);
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);

            this.btnSil.BackColor = System.Drawing.Color.Crimson;
            this.btnSil.ForeColor = System.Drawing.Color.White;
            this.btnSil.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSil.Location = new System.Drawing.Point(320, 130);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(100, 40);
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);

            this.btnTemizle.BackColor = System.Drawing.Color.Gray;
            this.btnTemizle.ForeColor = System.Drawing.Color.White;
            this.btnTemizle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTemizle.Location = new System.Drawing.Point(470, 130);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(100, 40);
            this.btnTemizle.Text = "TEMİZLE";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);

            // 
            // panelListe
            // 
            this.panelListe.Controls.Add(this.gridUrunler);
            this.panelListe.Controls.Add(this.panelArama);
            this.panelListe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelListe.Location = new System.Drawing.Point(0, 220);
            this.panelListe.Name = "panelListe";
            this.panelListe.Size = new System.Drawing.Size(1000, 380);
            this.panelListe.TabIndex = 1;

            // Arama Paneli
            this.panelArama.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelArama.Height = 40;
            this.panelArama.Controls.Add(this.txtAra);
            this.panelArama.Controls.Add(this.lblAra);

            this.lblAra.Text = "Ürün Ara:"; this.lblAra.Location = new System.Drawing.Point(10, 12); this.lblAra.AutoSize = true;
            this.txtAra.Location = new System.Drawing.Point(70, 10); this.txtAra.Size = new System.Drawing.Size(300, 20);
            this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged);

            // Grid
            this.gridUrunler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridUrunler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridUrunler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridUrunler.ReadOnly = true;
            this.gridUrunler.RowHeadersVisible = false;
            this.gridUrunler.AllowUserToAddRows = false;
            this.gridUrunler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridUrunler_CellClick);

            // Form
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.panelListe);
            this.Controls.Add(this.panelGiris);
            this.Name = "UrunForm";
            this.Text = "Ürün Yönetimi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.UrunForm_Load);

            this.panelGiris.ResumeLayout(false);
            this.panelGiris.PerformLayout();
            this.panelListe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridUrunler)).EndInit();
            this.panelArama.ResumeLayout(false);
            this.panelArama.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelGiris;
        private System.Windows.Forms.Label label1, label2, label3, label4, label5, label6;
        private System.Windows.Forms.TextBox txtBarkod, txtUrunAdi, txtAlisFiyat, txtSatisFiyat, txtStok;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.Button btnEkle, btnGuncelle, btnSil, btnTemizle;
        private System.Windows.Forms.Panel panelListe;
        private System.Windows.Forms.DataGridView gridUrunler;
        private System.Windows.Forms.Panel panelArama;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Label lblAra;
    }
}