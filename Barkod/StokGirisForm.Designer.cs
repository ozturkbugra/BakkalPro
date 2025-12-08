namespace Barkod
{
    partial class StokGirisForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelUst = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbOdemeTipi = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFaturaNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtTarih = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBarkod = new System.Windows.Forms.TextBox();
            this.cmbTedarikci = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelAlt = new System.Windows.Forms.Panel();
            this.lblToplam = new System.Windows.Forms.Label();
            this.lblGenelToplam = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.gridStok = new System.Windows.Forms.DataGridView();
            this.panelUst.SuspendLayout();
            this.panelAlt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridStok)).BeginInit();
            this.SuspendLayout();
            // 
            // panelUst
            // 
            this.panelUst.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelUst.Controls.Add(this.label5);
            this.panelUst.Controls.Add(this.cmbOdemeTipi);
            this.panelUst.Controls.Add(this.label4);
            this.panelUst.Controls.Add(this.txtFaturaNo);
            this.panelUst.Controls.Add(this.label3);
            this.panelUst.Controls.Add(this.dtTarih);
            this.panelUst.Controls.Add(this.label2);
            this.panelUst.Controls.Add(this.txtBarkod);
            this.panelUst.Controls.Add(this.cmbTedarikci);
            this.panelUst.Controls.Add(this.label1);
            this.panelUst.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUst.Location = new System.Drawing.Point(0, 0);
            this.panelUst.Name = "panelUst";
            this.panelUst.Size = new System.Drawing.Size(1000, 100);
            this.panelUst.TabIndex = 0;
            // 
            // label1 (Tedarikçi)
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tedarikçi Seçimi:";
            // 
            // cmbTedarikci
            // 
            this.cmbTedarikci.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbTedarikci.FormattingEnabled = true;
            this.cmbTedarikci.Location = new System.Drawing.Point(16, 37);
            this.cmbTedarikci.Name = "cmbTedarikci";
            this.cmbTedarikci.Size = new System.Drawing.Size(200, 25);
            this.cmbTedarikci.TabIndex = 1;
            // 
            // label4 (Fatura No)
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(230, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fatura No:";
            // 
            // txtFaturaNo
            // 
            this.txtFaturaNo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtFaturaNo.Location = new System.Drawing.Point(234, 37);
            this.txtFaturaNo.Name = "txtFaturaNo";
            this.txtFaturaNo.Size = new System.Drawing.Size(120, 25);
            this.txtFaturaNo.TabIndex = 2;
            // 
            // label3 (Tarih)
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(370, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Giriş Tarihi:";
            // 
            // dtTarih
            // 
            this.dtTarih.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtTarih.Location = new System.Drawing.Point(374, 37);
            this.dtTarih.Name = "dtTarih";
            this.dtTarih.Size = new System.Drawing.Size(150, 25);
            this.dtTarih.TabIndex = 3;
            // 
            // label5 (Ödeme Tipi)
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(540, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ödeme Tipi:";
            // 
            // cmbOdemeTipi
            // 
            this.cmbOdemeTipi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbOdemeTipi.FormattingEnabled = true;
            this.cmbOdemeTipi.Items.AddRange(new object[] {
            "Nakit (Kasa)",
            "Kredi Kartı",
            "Veresiye (Borçlanma)"});
            this.cmbOdemeTipi.Location = new System.Drawing.Point(544, 37);
            this.cmbOdemeTipi.Name = "cmbOdemeTipi";
            this.cmbOdemeTipi.Size = new System.Drawing.Size(150, 25);
            this.cmbOdemeTipi.TabIndex = 4;
            // 
            // label2 (Barkod)
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(710, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Barkod Okut (F1):";
            // 
            // txtBarkod
            // 
            this.txtBarkod.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtBarkod.Location = new System.Drawing.Point(714, 37);
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Size = new System.Drawing.Size(200, 25);
            this.txtBarkod.TabIndex = 0;
            this.txtBarkod.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBarkod_KeyDown);
            // 
            // panelAlt
            // 
            this.panelAlt.BackColor = System.Drawing.Color.Teal;
            this.panelAlt.Controls.Add(this.lblToplam);
            this.panelAlt.Controls.Add(this.lblGenelToplam);
            this.panelAlt.Controls.Add(this.btnKaydet);
            this.panelAlt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelAlt.Location = new System.Drawing.Point(0, 500);
            this.panelAlt.Name = "panelAlt";
            this.panelAlt.Size = new System.Drawing.Size(1000, 100);
            this.panelAlt.TabIndex = 1;
            // 
            // lblToplam
            // 
            this.lblToplam.AutoSize = true;
            this.lblToplam.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblToplam.ForeColor = System.Drawing.Color.White;
            this.lblToplam.Location = new System.Drawing.Point(150, 25);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(110, 45);
            this.lblToplam.TabIndex = 2;
            this.lblToplam.Text = "0.00 ₺";
            // 
            // lblGenelToplam
            // 
            this.lblGenelToplam.AutoSize = true;
            this.lblGenelToplam.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblGenelToplam.ForeColor = System.Drawing.Color.White;
            this.lblGenelToplam.Location = new System.Drawing.Point(20, 40);
            this.lblGenelToplam.Name = "lblGenelToplam";
            this.lblGenelToplam.Size = new System.Drawing.Size(130, 21);
            this.lblGenelToplam.TabIndex = 1;
            this.lblGenelToplam.Text = "GENEL TOPLAM:";
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.SeaGreen;
            this.btnKaydet.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnKaydet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnKaydet.ForeColor = System.Drawing.Color.White;
            this.btnKaydet.Location = new System.Drawing.Point(800, 0);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(200, 100);
            this.btnKaydet.TabIndex = 0;
            this.btnKaydet.Text = "STOK GİRİŞİNİ KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // gridStok
            // 
            this.gridStok.AllowUserToAddRows = false;
            this.gridStok.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridStok.BackgroundColor = System.Drawing.Color.White;
            this.gridStok.ColumnHeadersHeight = 40;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridStok.DefaultCellStyle = dataGridViewCellStyle1;
            this.gridStok.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridStok.Location = new System.Drawing.Point(0, 100);
            this.gridStok.Name = "gridStok";
            this.gridStok.RowHeadersVisible = false;
            this.gridStok.RowTemplate.Height = 35;
            this.gridStok.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridStok.Size = new System.Drawing.Size(1000, 400);
            this.gridStok.TabIndex = 2;
            this.gridStok.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridStok_CellValueChanged);
            this.gridStok.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridStok_CellContentClick);
            this.gridStok.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.gridStok_DataError);
            // 
            // StokGirisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.gridStok);
            this.Controls.Add(this.panelAlt);
            this.Controls.Add(this.panelUst);
            this.Name = "StokGirisForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stok Giriş / Mal Kabul";
            this.Load += new System.EventHandler(this.StokGirisForm_Load);
            this.panelUst.ResumeLayout(false);
            this.panelUst.PerformLayout();
            this.panelAlt.ResumeLayout(false);
            this.panelAlt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridStok)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUst;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtTarih;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBarkod;
        private System.Windows.Forms.ComboBox cmbTedarikci;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelAlt;
        private System.Windows.Forms.DataGridView gridStok;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label lblToplam;
        private System.Windows.Forms.Label lblGenelToplam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFaturaNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbOdemeTipi;
    }
}