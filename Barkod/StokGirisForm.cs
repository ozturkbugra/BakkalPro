using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Barkod
{
    public partial class StokGirisForm : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=.;Initial Catalog=BakkalDB;Integrated Security=True");
        DataTable dtSepet = new DataTable();
        decimal genelToplam = 0;
        bool hesaplaniyor = false;

        public StokGirisForm()
        {
            InitializeComponent();
        }

        private void StokGirisForm_Load(object sender, EventArgs e)
        {
            GridTasarim();
            TedarikcileriYukle();
            cmbOdemeTipi.SelectedIndex = 2; // Varsayılan Veresiye olsun (Mal alımı genelde böyledir)
            txtBarkod.Focus();
        }

        void GridTasarim()
        {
            if (dtSepet.Columns.Count == 0)
            {
                dtSepet.Columns.Add("Barkod");
                dtSepet.Columns.Add("UrunAdi");
                dtSepet.Columns.Add("Miktar", typeof(decimal));
                dtSepet.Columns.Add("AlisFiyati", typeof(decimal));
                dtSepet.Columns.Add("Tutar", typeof(decimal));
                dtSepet.Columns.Add("UrunId", typeof(int));
                dtSepet.Columns.Add("SatisFiyati", typeof(decimal));
            }

            gridStok.DataSource = dtSepet;
            gridStok.Columns["UrunId"].Visible = false;
            gridStok.Columns["SatisFiyati"].Visible = false;

            gridStok.Columns["UrunAdi"].HeaderText = "Ürün Adı";
            gridStok.Columns["Miktar"].HeaderText = "Giriş Miktarı";
            gridStok.Columns["AlisFiyati"].HeaderText = "Alış Fiyatı";
            gridStok.Columns["Tutar"].HeaderText = "Toplam Tutar";

            gridStok.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridStok.RowHeadersVisible = false;
            gridStok.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridStok.RowTemplate.Height = 35;
            gridStok.DefaultCellStyle.Font = new Font("Segoe UI", 11F);

            gridStok.ReadOnly = false;
            gridStok.Columns["Barkod"].ReadOnly = true;
            gridStok.Columns["UrunAdi"].ReadOnly = true;
            gridStok.Columns["Tutar"].ReadOnly = true;

            if (!gridStok.Columns.Contains("btnSil"))
            {
                DataGridViewButtonColumn btnSil = new DataGridViewButtonColumn();
                btnSil.Text = "SİL";
                btnSil.Name = "btnSil";
                btnSil.UseColumnTextForButtonValue = true;
                btnSil.FlatStyle = FlatStyle.Flat;
                btnSil.DefaultCellStyle.BackColor = Color.Crimson;
                btnSil.DefaultCellStyle.ForeColor = Color.White;
                gridStok.Columns.Add(btnSil);
            }
        }

        void TedarikcileriYukle()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT Id, AdSoyad FROM Kisiler ORDER BY AdSoyad", baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbTedarikci.DataSource = dt;
                cmbTedarikci.DisplayMember = "AdSoyad";
                cmbTedarikci.ValueMember = "Id";
                cmbTedarikci.DropDownStyle = ComboBoxStyle.DropDown;
                cmbTedarikci.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cmbTedarikci.AutoCompleteSource = AutoCompleteSource.ListItems;
            }
            catch { }
        }

        private void txtBarkod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !string.IsNullOrEmpty(txtBarkod.Text))
            {
                UrunEkle(txtBarkod.Text.Trim());
                txtBarkod.Clear();
                e.SuppressKeyPress = true;
            }
        }

        void UrunEkle(string barkod)
        {
            foreach (DataRow row in dtSepet.Rows)
            {
                if (row["Barkod"].ToString() == barkod)
                {
                    row["Miktar"] = Convert.ToDecimal(row["Miktar"]) + 1;
                    row["Tutar"] = Convert.ToDecimal(row["Miktar"]) * Convert.ToDecimal(row["AlisFiyati"]);
                    ToplamHesapla();
                    return;
                }
            }

            try
            {
                if (baglanti.State == ConnectionState.Closed) baglanti.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Urunler WHERE Barkod=@b", baglanti);
                cmd.Parameters.AddWithValue("@b", barkod);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    decimal alisFiyati = Convert.ToDecimal(dr["AlisFiyati"]);
                    decimal satisFiyati = Convert.ToDecimal(dr["SatisFiyati"]);
                    dtSepet.Rows.Add(barkod, dr["UrunAdi"], 1, alisFiyati, alisFiyati, dr["Id"], satisFiyati);
                }
                else
                {
                    MessageBox.Show("Ürün Bulunamadı!");
                }
                dr.Close();
            }
            catch (Exception ex) { MessageBox.Show("Hata: " + ex.Message); }
            finally { baglanti.Close(); }

            ToplamHesapla();
        }

        private void gridStok_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (hesaplaniyor || e.RowIndex < 0) return;
            try
            {
                hesaplaniyor = true;
                DataGridViewRow row = gridStok.Rows[e.RowIndex];
                decimal miktar = row.Cells["Miktar"].Value != DBNull.Value ? Convert.ToDecimal(row.Cells["Miktar"].Value) : 0;
                decimal alisFiyat = row.Cells["AlisFiyati"].Value != DBNull.Value ? Convert.ToDecimal(row.Cells["AlisFiyati"].Value) : 0;
                row.Cells["Tutar"].Value = miktar * alisFiyat;
                hesaplaniyor = false;
                ToplamHesapla();
            }
            catch { hesaplaniyor = false; }
        }

        void ToplamHesapla()
        {
            genelToplam = 0;
            foreach (DataRow row in dtSepet.Rows)
            {
                if (row.RowState != DataRowState.Deleted)
                    genelToplam += Convert.ToDecimal(row["Tutar"]);
            }
            lblToplam.Text = genelToplam.ToString("C2");
        }

        private void gridStok_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && gridStok.Columns[e.ColumnIndex].Name == "btnSil")
            {
                hesaplaniyor = true;
                dtSepet.Rows[e.RowIndex].Delete();
                hesaplaniyor = false;
                ToplamHesapla();
            }
        }

        private void gridStok_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
            MessageBox.Show("Lütfen geçerli bir sayı giriniz.");
        }

        // --- KAYIT İŞLEMİ (FATURA NO ve ÖDEME TİPİ DAHİL) ---
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (dtSepet.Rows.Count == 0) return;
            if (cmbTedarikci.SelectedValue == null) { MessageBox.Show("Tedarikçi Seçin!"); return; }
            if (string.IsNullOrEmpty(txtFaturaNo.Text)) { MessageBox.Show("Fatura No Giriniz!"); return; }

            int tedarikciId = Convert.ToInt32(cmbTedarikci.SelectedValue);
            string odemeTipi = cmbOdemeTipi.SelectedItem.ToString();

            // Fatura Numarasını (String de olabilir ama veritabanında INT tanımladık, o yüzden dönüştürüyoruz)
            // Eğer harfli fatura no olacaksa veritabanında FaturaNo tipini NVARCHAR yapmak gerekir.
            // Şimdilik sadece rakam varsayıyoruz.
            int faturaNo = 0;
            int.TryParse(txtFaturaNo.Text, out faturaNo);

            if (baglanti.State == ConnectionState.Closed) baglanti.Open();
            SqlTransaction islem = baglanti.BeginTransaction();

            try
            {
                // ÖDEME TİPİNE GÖRE SÜTUNLARI DOLDUR
                decimal tutarNakit = 0, tutarKart = 0, tutarVeresiye = 0;

                if (odemeTipi.Contains("Nakit")) tutarNakit = genelToplam;
                else if (odemeTipi.Contains("Kredi")) tutarKart = genelToplam;
                else tutarVeresiye = genelToplam; // Veresiye

                // 1. FATURA (ALIŞ FATURASI)
                string sqlFatura = @"INSERT INTO Faturalar 
                                     (KisiId, Tarih, GenelToplam, Aciklama, FaturaNo, TutarNakit, TutarKrediKarti, TutarVeresiye, OdemeTipi) 
                                     VALUES (@kisi, @tarih, @toplam, 'Stok Girişi', @fno, @nakit, @kart, @veresiye, @tip); 
                                     SELECT SCOPE_IDENTITY();";

                SqlCommand cmdFatura = new SqlCommand(sqlFatura, baglanti, islem);
                cmdFatura.Parameters.AddWithValue("@kisi", tedarikciId);
                cmdFatura.Parameters.AddWithValue("@tarih", dtTarih.Value);
                cmdFatura.Parameters.AddWithValue("@toplam", genelToplam);
                cmdFatura.Parameters.AddWithValue("@fno", faturaNo);
                cmdFatura.Parameters.AddWithValue("@nakit", tutarNakit);
                cmdFatura.Parameters.AddWithValue("@kart", tutarKart);
                cmdFatura.Parameters.AddWithValue("@veresiye", tutarVeresiye);
                cmdFatura.Parameters.AddWithValue("@tip", odemeTipi);

                int faturaId = Convert.ToInt32(cmdFatura.ExecuteScalar());

                // 2. DETAYLAR VE HAREKETLER
                foreach (DataRow row in dtSepet.Rows)
                {
                    if (row.RowState == DataRowState.Deleted) continue;

                    int urunId = Convert.ToInt32(row["UrunId"]);
                    decimal miktar = Convert.ToDecimal(row["Miktar"]);
                    decimal alisFiyati = Convert.ToDecimal(row["AlisFiyati"]);
                    decimal tutar = Convert.ToDecimal(row["Tutar"]);
                    decimal satisFiyati = Convert.ToDecimal(row["SatisFiyati"]);

                    // Fatura Satır
                    string sqlSatir = @"INSERT INTO FaturaSatirlar (FaturaId, UrunId, Miktar, AlisFiyati, SatisFiyati, Tutar) 
                                        VALUES (@fid, @uid, @mik, @alis, @satis, @tut)";
                    SqlCommand cmdSatir = new SqlCommand(sqlSatir, baglanti, islem);
                    cmdSatir.Parameters.AddWithValue("@fid", faturaId);
                    cmdSatir.Parameters.AddWithValue("@uid", urunId);
                    cmdSatir.Parameters.AddWithValue("@mik", miktar);
                    cmdSatir.Parameters.AddWithValue("@alis", alisFiyati);
                    cmdSatir.Parameters.AddWithValue("@satis", satisFiyati);
                    cmdSatir.Parameters.AddWithValue("@tut", tutar);
                    cmdSatir.ExecuteNonQuery();

                    // HAREKET TABLOSU (GİRİŞ)
                    string sqlHareket = @"INSERT INTO Hareketler 
                                          (urun_id, kisi_id, girismiktari, cikismiktari, birimfiyat, toplamtutar, kalanmiktar, tarih)
                                          VALUES 
                                          (@uid, @kid, @mik, 0, @fiyat, @tut, 
                                          (SELECT ISNULL(SUM(girismiktari - cikismiktari), 0) FROM Hareketler WHERE urun_id = @uid) + @mik,
                                          @tarih)";

                    SqlCommand cmdHareket = new SqlCommand(sqlHareket, baglanti, islem);
                    cmdHareket.Parameters.AddWithValue("@uid", urunId);
                    cmdHareket.Parameters.AddWithValue("@kid", tedarikciId);
                    cmdHareket.Parameters.AddWithValue("@mik", miktar);
                    cmdHareket.Parameters.AddWithValue("@fiyat", alisFiyati);
                    cmdHareket.Parameters.AddWithValue("@tut", tutar);
                    cmdHareket.Parameters.AddWithValue("@tarih", dtTarih.Value);
                    cmdHareket.ExecuteNonQuery();

                    // Fiyat Güncelle
                    SqlCommand cmdFiyat = new SqlCommand("UPDATE Urunler SET AlisFiyati = @alis WHERE Id = @uid", baglanti, islem);
                    cmdFiyat.Parameters.AddWithValue("@alis", alisFiyati);
                    cmdFiyat.Parameters.AddWithValue("@uid", urunId);
                    cmdFiyat.ExecuteNonQuery();
                }

                // 3. TEDARİKÇİ BAKİYESİ (VERESİYE İSE BORCUMUZU DÜŞ/ARTIR)
                // Tedarikçiye borçlandığımız için bakiyeyi EKSİ olarak artırıyoruz (veya nasıl takip ediyorsan)
                // Genelde: Müşteri Borcu (+), Tedarikçi Alacağı (-)
                if (tutarVeresiye > 0)
                {
                    // Burada "- @tutar" diyerek kişinin bakiyesini düşürüyoruz (Borçlu oluyoruz)
                    SqlCommand cmdBakiye = new SqlCommand("UPDATE Kisiler SET Bakiye = Bakiye - @tutar WHERE Id=@kisi", baglanti, islem);
                    cmdBakiye.Parameters.AddWithValue("@tutar", tutarVeresiye);
                    cmdBakiye.Parameters.AddWithValue("@kisi", tedarikciId);
                    cmdBakiye.ExecuteNonQuery();
                }

                islem.Commit();
                MessageBox.Show("Stok Girişi Başarıyla Kaydedildi.");
                dtSepet.Rows.Clear();
                lblToplam.Text = "0.00 ₺";
                txtFaturaNo.Clear();
                txtBarkod.Focus();
            }
            catch (Exception ex)
            {
                islem.Rollback();
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally { baglanti.Close(); }
        }
    }
}