using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Barkod
{
    public partial class UrunForm : Form
    {
        // Bağlantı
        SqlConnection baglanti = new SqlConnection(@"Data Source=.;Initial Catalog=BakkalDB;Integrated Security=True");

        // Seçili ürünün ID'sini tutmak için (Güncelleme ve Silme için lazım)
        int secilenUrunId = 0;

        public UrunForm()
        {
            InitializeComponent();
        }

        private void UrunForm_Load(object sender, EventArgs e)
        {
            KategorileriYukle();
            UrunleriListele();
        }

        // --- VERİ ÇEKME İŞLEMLERİ ---

        void KategorileriYukle()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Kategoriler", baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbKategori.DataSource = dt;
                cmbKategori.DisplayMember = "Ad";
                cmbKategori.ValueMember = "Id";
                cmbKategori.SelectedIndex = -1; // Boş gelsin
            }
            catch { }
        }

        void UrunleriListele(string arama = "")
        {
            try
            {
                // Kategoriler tablosuyla birleştirip kategori adını da getiriyoruz
                string sorgu = @"SELECT u.Id, u.Barkod, u.UrunAdi, k.Ad AS Kategori, u.AlisFiyati, u.SatisFiyati, u.Stok 
                                FROM Urunler u 
                                LEFT JOIN Kategoriler k ON u.KategoriId = k.Id 
                                WHERE u.UrunAdi LIKE @ara OR u.Barkod LIKE @ara
                                ORDER BY u.Id DESC"; // En son eklenen en üstte

                SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                da.SelectCommand.Parameters.AddWithValue("@ara", "%" + arama + "%");

                DataTable dt = new DataTable();
                da.Fill(dt);
                gridUrunler.DataSource = dt;

                // ID kolonunu gizleyelim, kafaları karıştırmasın
                gridUrunler.Columns["Id"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Listeleme Hatası: " + ex.Message);
            }
        }

        // --- CRUD İŞLEMLERİ (EKLE - GÜNCELLE - SİL) ---

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBarkod.Text) || string.IsNullOrEmpty(txtUrunAdi.Text))
            {
                MessageBox.Show("Barkod ve Ürün Adı zorunludur!");
                return;
            }

            try
            {
                if (baglanti.State == ConnectionState.Closed) baglanti.Open();

                // Barkod kontrolü (Aynı barkoddan var mı?)
                SqlCommand kontrol = new SqlCommand("SELECT COUNT(*) FROM Urunler WHERE Barkod=@bar", baglanti);
                kontrol.Parameters.AddWithValue("@bar", txtBarkod.Text);
                int varMi = Convert.ToInt32(kontrol.ExecuteScalar());

                if (varMi > 0)
                {
                    MessageBox.Show("Bu barkod zaten kayıtlı!");
                    return;
                }

                string sql = @"INSERT INTO Urunler (Barkod, UrunAdi, KategoriId, AlisFiyati, SatisFiyati, Stok) 
                               VALUES (@bar, @ad, @kat, @alis, @satis, @stok)";

                SqlCommand cmd = new SqlCommand(sql, baglanti);
                cmd.Parameters.AddWithValue("@bar", txtBarkod.Text);
                cmd.Parameters.AddWithValue("@ad", txtUrunAdi.Text);
                // Eğer kategori seçilmediyse varsayılan 1 (Gıda) olsun
                cmd.Parameters.AddWithValue("@kat", cmbKategori.SelectedValue ?? 1);
                cmd.Parameters.AddWithValue("@alis", decimal.Parse(txtAlisFiyat.Text == "" ? "0" : txtAlisFiyat.Text));
                cmd.Parameters.AddWithValue("@satis", decimal.Parse(txtSatisFiyat.Text == "" ? "0" : txtSatisFiyat.Text));
                cmd.Parameters.AddWithValue("@stok", int.Parse(txtStok.Text == "" ? "0" : txtStok.Text));

                cmd.ExecuteNonQuery();

                MessageBox.Show("Ürün Eklendi!");
                Temizle();
                UrunleriListele();
            }
            catch (Exception ex) { MessageBox.Show("Ekleme Hatası: " + ex.Message); }
            finally { baglanti.Close(); }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (secilenUrunId == 0)
            {
                MessageBox.Show("Lütfen listeden güncellenecek ürünü seçin!");
                return;
            }

            try
            {
                if (baglanti.State == ConnectionState.Closed) baglanti.Open();

                string sql = @"UPDATE Urunler SET 
                               Barkod=@bar, UrunAdi=@ad, KategoriId=@kat, AlisFiyati=@alis, SatisFiyati=@satis, Stok=@stok
                               WHERE Id=@id";

                SqlCommand cmd = new SqlCommand(sql, baglanti);
                cmd.Parameters.AddWithValue("@id", secilenUrunId);
                cmd.Parameters.AddWithValue("@bar", txtBarkod.Text);
                cmd.Parameters.AddWithValue("@ad", txtUrunAdi.Text);
                cmd.Parameters.AddWithValue("@kat", cmbKategori.SelectedValue ?? 1);
                cmd.Parameters.AddWithValue("@alis", decimal.Parse(txtAlisFiyat.Text));
                cmd.Parameters.AddWithValue("@satis", decimal.Parse(txtSatisFiyat.Text));
                cmd.Parameters.AddWithValue("@stok", int.Parse(txtStok.Text));

                cmd.ExecuteNonQuery();

                MessageBox.Show("Ürün Güncellendi!");
                Temizle();
                UrunleriListele();
            }
            catch (Exception ex) { MessageBox.Show("Güncelleme Hatası: " + ex.Message); }
            finally { baglanti.Close(); }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (secilenUrunId == 0)
            {
                MessageBox.Show("Lütfen silinecek ürünü seçin!");
                return;
            }

            DialogResult onay = MessageBox.Show("Bu ürünü kalıcı olarak silmek istiyor musunuz?", "Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (onay == DialogResult.No) return;

            try
            {
                if (baglanti.State == ConnectionState.Closed) baglanti.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Urunler WHERE Id=@id", baglanti);
                cmd.Parameters.AddWithValue("@id", secilenUrunId);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Ürün Silindi.");
                Temizle();
                UrunleriListele();
            }
            catch (Exception ex) { MessageBox.Show("Silme Hatası: " + ex.Message); }
            finally { baglanti.Close(); }
        }

        // --- YARDIMCI METODLAR ---

        // Listeden bir satıra tıklayınca verileri kutulara doldur
        private void gridUrunler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Tıklanan satırı al
                DataGridViewRow row = gridUrunler.Rows[e.RowIndex];

                // ID'yi değişkene al
                secilenUrunId = Convert.ToInt32(row.Cells["Id"].Value);

                // Kutuları doldur
                txtBarkod.Text = row.Cells["Barkod"].Value.ToString();
                txtUrunAdi.Text = row.Cells["UrunAdi"].Value.ToString();
                txtAlisFiyat.Text = row.Cells["AlisFiyati"].Value.ToString();
                txtSatisFiyat.Text = row.Cells["SatisFiyati"].Value.ToString();
                txtStok.Text = row.Cells["Stok"].Value.ToString();

                // Kategoriyi seç (Combo box'ta text olarak aratıp seçiyoruz)
                cmbKategori.Text = row.Cells["Kategori"].Value.ToString();
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        void Temizle()
        {
            secilenUrunId = 0;
            txtBarkod.Clear();
            txtUrunAdi.Clear();
            txtAlisFiyat.Clear();
            txtSatisFiyat.Clear();
            txtStok.Clear();
            cmbKategori.SelectedIndex = -1;
            txtBarkod.Focus();
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            UrunleriListele(txtAra.Text);
        }
    }
}