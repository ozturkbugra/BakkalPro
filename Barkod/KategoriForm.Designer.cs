namespace Barkod
{
    partial class KategoriForm
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
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelListe = new System.Windows.Forms.Panel();
            this.gridKategoriler = new System.Windows.Forms.DataGridView();
            this.panelGiris.SuspendLayout();
            this.panelListe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridKategoriler)).BeginInit();
            this.SuspendLayout();
            // 
            // panelGiris
            // 
            this.panelGiris.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelGiris.Controls.Add(this.btnTemizle);
            this.panelGiris.Controls.Add(this.btnSil);
            this.panelGiris.Controls.Add(this.btnGuncelle);
            this.panelGiris.Controls.Add(this.btnEkle);
            this.panelGiris.Controls.Add(this.txtAd);
            this.panelGiris.Controls.Add(this.label1);
            this.panelGiris.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelGiris.Location = new System.Drawing.Point(0, 0);
            this.panelGiris.Name = "panelGiris";
            this.panelGiris.Size = new System.Drawing.Size(400, 160);
            this.panelGiris.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(20, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategori Adı:";
            // 
            // txtAd
            // 
            this.txtAd.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtAd.Location = new System.Drawing.Point(120, 22);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(200, 25);
            this.txtAd.TabIndex = 1;
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.SeaGreen;
            this.btnEkle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEkle.ForeColor = System.Drawing.Color.White;
            this.btnEkle.Location = new System.Drawing.Point(24, 70);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(80, 35);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnGuncelle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnGuncelle.ForeColor = System.Drawing.Color.White;
            this.btnGuncelle.Location = new System.Drawing.Point(110, 70);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(80, 35);
            this.btnGuncelle.TabIndex = 3;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Crimson;
            this.btnSil.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSil.ForeColor = System.Drawing.Color.White;
            this.btnSil.Location = new System.Drawing.Point(196, 70);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(80, 35);
            this.btnSil.TabIndex = 4;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.Gray;
            this.btnTemizle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnTemizle.ForeColor = System.Drawing.Color.White;
            this.btnTemizle.Location = new System.Drawing.Point(282, 70);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(80, 35);
            this.btnTemizle.TabIndex = 5;
            this.btnTemizle.Text = "TEMİZLE";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // panelListe
            // 
            this.panelListe.Controls.Add(this.gridKategoriler);
            this.panelListe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelListe.Location = new System.Drawing.Point(0, 160);
            this.panelListe.Name = "panelListe";
            this.panelListe.Size = new System.Drawing.Size(400, 340);
            this.panelListe.TabIndex = 1;
            // 
            // gridKategoriler
            // 
            this.gridKategoriler.AllowUserToAddRows = false;
            this.gridKategoriler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridKategoriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridKategoriler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridKategoriler.Location = new System.Drawing.Point(0, 0);
            this.gridKategoriler.Name = "gridKategoriler";
            this.gridKategoriler.ReadOnly = true;
            this.gridKategoriler.RowHeadersVisible = false;
            this.gridKategoriler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridKategoriler.Size = new System.Drawing.Size(400, 340);
            this.gridKategoriler.TabIndex = 0;
            this.gridKategoriler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridKategoriler_CellClick);
            // 
            // KategoriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 500);
            this.Controls.Add(this.panelListe);
            this.Controls.Add(this.panelGiris);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "KategoriForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kategori Yönetimi";
            this.Load += new System.EventHandler(this.KategoriForm_Load);
            this.panelGiris.ResumeLayout(false);
            this.panelGiris.PerformLayout();
            this.panelListe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridKategoriler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelGiris;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelListe;
        private System.Windows.Forms.DataGridView gridKategoriler;
    }
}