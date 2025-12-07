using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Barkod
{
    public partial class KisiForm : Form
    {
        // Bağlantı Cümlesi
        SqlConnection baglanti = new SqlConnection(@"Data Source=.;Initial Catalog=BakkalDB;Integrated Security=True");

        int secilenKisiId = 0; // Seçili kişi ID'si

        public KisiForm()
        {
            InitializeComponent();
        }

        private void KisiForm_Load(object sender, EventArgs e)
        {
            KisileriListele();
        }

        // --- LİSTELEME VE ARAMA ---
        void KisileriListele(string arama = "")
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed) baglanti.Open();

                string sql = "SELECT * FROM Kisiler WHERE AdSoyad LIKE @ara ORDER BY Id DESC";
                SqlDataAdapter da = new SqlDataAdapter(sql, baglanti);
                da.SelectCommand.Parameters.AddWithValue("@ara", "%" + arama + "%");

                DataTable dt = new DataTable();
                da.Fill(dt);
                gridKisiler.DataSource = dt;

                // ID gizle
                gridKisiler.Columns["Id"].Visible = false;

                // Bakiye renklendirme (Borçlular kırmızı görünsün diye grid ayarı)
                gridKisiler.Columns["Bakiye"].DefaultCellStyle.Format = "C2"; // Para birimi
                gridKisiler.Columns["Bakiye"].DefaultCellStyle.ForeColor = Color.Red;
                gridKisiler.Columns["Bakiye"].DefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Listeleme Hatası: " + ex.Message);
            }
            finally { baglanti.Close(); }
        }

        // --- EKLEME ---
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAdSoyad.Text))
            {
                MessageBox.Show("Ad Soyad girmek zorunludur!");
                return;
            }

            try
            {
                if (baglanti.State == ConnectionState.Closed) baglanti.Open();

                string sql = "INSERT INTO Kisiler (AdSoyad, TcKimlikNo, Telefon, Adres) VALUES (@ad, @tc, @tel, @adres)";
                SqlCommand cmd = new SqlCommand(sql, baglanti);
                cmd.Parameters.AddWithValue("@ad", txtAdSoyad.Text);
                cmd.Parameters.AddWithValue("@tc", txtTc.Text);
                cmd.Parameters.AddWithValue("@tel", txtTelefon.Text);
                cmd.Parameters.AddWithValue("@adres", txtAdres.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Kişi Kaydedildi.");
                Temizle();
                KisileriListele();
            }
            catch (Exception ex) { MessageBox.Show("Hata: " + ex.Message); }
            finally { baglanti.Close(); }
        }

        // --- GÜNCELLEME ---
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (secilenKisiId == 0)
            {
                MessageBox.Show("Lütfen listeden bir kişi seçin.");
                return;
            }

            try
            {
                if (baglanti.State == ConnectionState.Closed) baglanti.Open();

                string sql = "UPDATE Kisiler SET AdSoyad=@ad, TcKimlikNo=@tc, Telefon=@tel, Adres=@adres WHERE Id=@id";
                SqlCommand cmd = new SqlCommand(sql, baglanti);
                cmd.Parameters.AddWithValue("@id", secilenKisiId);
                cmd.Parameters.AddWithValue("@ad", txtAdSoyad.Text);
                cmd.Parameters.AddWithValue("@tc", txtTc.Text);
                cmd.Parameters.AddWithValue("@tel", txtTelefon.Text);
                cmd.Parameters.AddWithValue("@adres", txtAdres.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Kişi Güncellendi.");
                Temizle();
                KisileriListele();
            }
            catch (Exception ex) { MessageBox.Show("Hata: " + ex.Message); }
            finally { baglanti.Close(); }
        }

        // --- SİLME ---
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (secilenKisiId == 0) { MessageBox.Show("Seçim yapınız."); return; }

            // ÖNEMLİ KONTROL: Borcu olan adamı sildirmeyelim!
            decimal bakiye = Convert.ToDecimal(gridKisiler.SelectedRows[0].Cells["Bakiye"].Value);
            if (bakiye > 0)
            {
                MessageBox.Show($"Bu kişinin {bakiye:C2} borcu var! Önce borcu sıfırlayın.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult onay = MessageBox.Show("Bu kişiyi silmek istediğinize emin misiniz?", "Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (onay == DialogResult.Yes)
            {
                try
                {
                    if (baglanti.State == ConnectionState.Closed) baglanti.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Kisiler WHERE Id=@id", baglanti);
                    cmd.Parameters.AddWithValue("@id", secilenKisiId);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Kişi Silindi.");
                    Temizle();
                    KisileriListele();
                }
                catch (Exception ex) { MessageBox.Show("Hata: " + ex.Message); }
                finally { baglanti.Close(); }
            }
        }

        // --- YARDIMCI METODLAR ---
        private void gridKisiler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = gridKisiler.Rows[e.RowIndex];
                secilenKisiId = Convert.ToInt32(row.Cells["Id"].Value);

                txtAdSoyad.Text = row.Cells["AdSoyad"].Value.ToString();
                txtTc.Text = row.Cells["TcKimlikNo"].Value.ToString();
                txtTelefon.Text = row.Cells["Telefon"].Value.ToString();
                txtAdres.Text = row.Cells["Adres"].Value.ToString();
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        void Temizle()
        {
            secilenKisiId = 0;
            txtAdSoyad.Clear();
            txtTc.Clear();
            txtTelefon.Clear();
            txtAdres.Clear();
            txtAdSoyad.Focus();
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            KisileriListele(txtAra.Text);
        }
    }
}