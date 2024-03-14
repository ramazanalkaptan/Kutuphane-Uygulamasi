using kutuphaneOtomasyon.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kutuphaneOtomasyon
{
    public partial class AdminPage : Form
    {
        List<Kisi> kisilerim;
        List<Kitap> kitaplarim;
        public AdminPage(List<Kisi> kisilerim, List<Kitap> kitaplarim)
        {
            InitializeComponent();
            this.kisilerim = kisilerim;
            this.kitaplarim = kitaplarim;
        }

        private void AdminPage_Load(object sender, EventArgs e)
        {
            foreach (Kisi kisi in kisilerim)
            {
                dataGridView1.Rows.Add
                    (
                        kisi.getId(),
                        kisi.getName(), 
                        kisi.getLastname(), 
                        kisi.getKullaniciAdi(), 
                        kisi.getSifre(), 
                        kisi.getYetki(), 
                        kisi.getOlusturmaTarih()
                    );
            }

            foreach (Kitap kitap in kitaplarim)
            {
                dataGrid_kitap.Rows.Add
                    (
                        kitap.getkitapid(),
                        kitap.getkitapisim(),
                        kitap.getkitapYazar(),
                        kitap.getkitapdili(),
                        kitap.getyayinevi(),
                        kitap.gettur(),
                        kitap.getadet(),
                        kitap.getsayfasayisi(),
                        kitap.getbasimyili()
                    );
            }
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(Convert.ToInt32(text_id.Text), text_isim.Text, text_soyad.Text, text_kadi.Text, text_sifre.Text, text_yetki.Text, maskedTextBox1.Text);
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            guncelleBilgi();
        }
        public void guncelleBilgi()
        {
            text_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            text_isim.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            text_soyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            text_kadi.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            text_sifre.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            text_yetki.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            maskedTextBox1.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            string id = text_id.Text;
            string isim = text_isim.Text;
            string soyad = text_soyad.Text;
            string kadi = text_kadi.Text;
            string sifre = text_sifre.Text;
            string yetki = text_yetki.Text;
            DateTime dateTime = DateTime.Now;
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            dataGridView1.Rows.Add(id,isim,soyad,kadi,sifre,yetki,dateTime);
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < groupBox_uyeislemleri.Controls.Count; i++)
            {
                if (groupBox_uyeislemleri.Controls[i] is TextBox || groupBox_uyeislemleri.Controls[i] is MaskedTextBox)
                {
                    groupBox_uyeislemleri.Controls[i].Text = string.Empty;
                }
            }
        }

        private void btn_kitapekle_Click(object sender, EventArgs e)
        {
            dataGrid_kitap.Rows.Add(Convert.ToInt32(text_kitapid.Text), text_kitapisim.Text, text_kitapyazar.Text, text_kitapdili.Text, text_kitapyayinevi.Text, text_kitaptur.Text,Convert.ToInt32(text_kitapadet.Text) ,Convert.ToInt32(text_kitapsayfasayisi.Text) ,Convert.ToInt32(text_kitapbasimyili.Text));
        }

        private void btn_kitapsil_Click(object sender, EventArgs e)
        {
            dataGrid_kitap.Rows.Remove(dataGrid_kitap.CurrentRow);
        }

        public void kitapGuncelle()
        {
            text_kitapid.Text = dataGrid_kitap.CurrentRow.Cells[0].Value.ToString();
            text_kitapisim.Text = dataGrid_kitap.CurrentRow.Cells[1].Value.ToString();
            text_kitapyazar.Text = dataGrid_kitap.CurrentRow.Cells[2].Value.ToString();
            text_kitapdili.Text = dataGrid_kitap.CurrentRow.Cells[3].Value.ToString();
            text_kitapyayinevi.Text = dataGrid_kitap.CurrentRow.Cells[4].Value.ToString();
            text_kitaptur.Text = dataGrid_kitap.CurrentRow.Cells[5].Value.ToString();
            text_kitapadet.Text = dataGrid_kitap.CurrentRow.Cells[6].Value.ToString();
            text_kitapsayfasayisi.Text = dataGrid_kitap.CurrentRow.Cells[7].Value.ToString();
            text_kitapbasimyili.Text = dataGrid_kitap.CurrentRow.Cells[8].Value.ToString();

        }

        private void dataGrid_kitap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            kitapGuncelle();
        }

        private void btn_kitapguncelle_Click(object sender, EventArgs e)
        {
            string id =text_kitapid.Text;
            string isim =text_kitapisim.Text;
            string yazar =text_kitapyazar.Text;
            string dili =text_kitapdili.Text;
            string yayinevi =text_kitapyayinevi.Text;
            string tur =text_kitaptur.Text;
            string adet =text_kitapadet.Text;
            string sayfasayisi =text_kitapsayfasayisi.Text;
            string basimyili =text_kitapbasimyili.Text;

            dataGrid_kitap.Rows.Remove(dataGrid_kitap.CurrentRow);
            dataGrid_kitap.Rows.Add(id,isim,yazar,dili,yayinevi,tur,adet,sayfasayisi,basimyili);
        }

        private void btn_kitaptemizle_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < groupBox_kitap.Controls.Count; i++)
            {
                if (groupBox_kitap.Controls[i] is TextBox)
                {
                    groupBox_kitap.Controls[i].Text = string.Empty;
                }
            }
        }

        private void btn_uyeAra_Click(object sender, EventArgs e)
        {
            int arananID = Convert.ToInt32(text_uyeAra.Text);

            // DataGridView içinde döngü başlat
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                // Satırın ID'sini al, hücrenin 0. sütununda saklanıyor varsayalım
                int rowID = Convert.ToInt32(row.Cells[0].Value);

                // Eğer aranan ID ile satırın ID'si eşleşirse
                if (rowID == arananID)
                {
                    // İlgili satırın tüm bilgilerine erişebilirsiniz.
                    string bilgi1 = row.Cells[0].Value.ToString(); // İlgili sütun indeksini ayarlayın
                    string bilgi2 = row.Cells[1].Value.ToString(); // İlgili sütun indeksini ayarlayın
                    string bilgi3 = row.Cells[2].Value.ToString();
                    string bilgi4 = row.Cells[3].Value.ToString();
                    string bilgi5 = row.Cells[4].Value.ToString();
                    string bilgi6 = row.Cells[5].Value.ToString();
                    string bilgi7 = row.Cells[6].Value.ToString(); // vb.
                    dataGridView1.Rows.Clear();
                    dataGridView1.Rows.Add(bilgi1, bilgi2, bilgi3, bilgi4, bilgi5, bilgi6, bilgi7);
                    break;
                }
            }
        }

        private void btn_uyeYenile_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            foreach (Kisi kisi in kisilerim)
            {
                dataGridView1.Rows.Add
                    (
                        kisi.getId(),
                        kisi.getName(),
                        kisi.getLastname(),
                        kisi.getKullaniciAdi(),
                        kisi.getSifre(),
                        kisi.getYetki(),
                        kisi.getOlusturmaTarih()
                    );
            }
        }

        private void btn_kitapara_Click(object sender, EventArgs e)
        {
            int arananID = Convert.ToInt32(text_kitapara.Text);

            // DataGridView içinde döngü başlat
            foreach (DataGridViewRow row in dataGrid_kitap.Rows)
            {
                // Satırın ID'sini al, hücrenin 0. sütununda saklanıyor varsayalım
                int rowID = Convert.ToInt32(row.Cells[0].Value);

                // Eğer aranan ID ile satırın ID'si eşleşirse
                if (rowID == arananID)
                {
                    // İlgili satırın tüm bilgilerine erişebilirsiniz.
                    string bilgi1 = row.Cells[0].Value.ToString(); // İlgili sütun indeksini ayarlayın
                    string bilgi2 = row.Cells[1].Value.ToString(); // İlgili sütun indeksini ayarlayın
                    string bilgi3 = row.Cells[2].Value.ToString();
                    string bilgi4 = row.Cells[3].Value.ToString();
                    string bilgi5 = row.Cells[4].Value.ToString();
                    string bilgi6 = row.Cells[5].Value.ToString();
                    string bilgi7 = row.Cells[6].Value.ToString();
                    string bilgi8 = row.Cells[7].Value.ToString(); // vb.
                    string bilgi9 = row.Cells[8].Value.ToString(); // vb.
                   
                    dataGrid_kitap.Rows.Clear();
                    dataGrid_kitap.Rows.Add(bilgi1, bilgi2, bilgi3, bilgi4, bilgi5, bilgi6, bilgi7,bilgi8,bilgi9);
                    break;
                }
            }
        }

        private void btn_kitapyenile_Click(object sender, EventArgs e)
        {
            dataGrid_kitap.Rows.Clear();
            foreach (Kitap kitap in kitaplarim)
            {
                dataGrid_kitap.Rows.Add
                    (
                        kitap.getkitapid(),
                        kitap.getkitapisim(),
                        kitap.getkitapYazar(),
                        kitap.getkitapdili(),
                        kitap.getyayinevi(),
                        kitap.gettur(),
                        kitap.getadet(),
                        kitap.getsayfasayisi(),
                        kitap.getbasimyili()
                    );
            }
        }
    }
}
