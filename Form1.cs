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
    public partial class Form1 : Form
    {
        List<Kisi> kisilerim = new List<Kisi>();
        List<Kitap> kitaplarim = new List<Kitap>();


        public Form1()
        {
            InitializeComponent();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            kisilerim.Add(new Kisi(1,"ramazan","alkaptan","ramazan","1","admin",DateTime.Now));
            kisilerim.Add(new Kisi(2, "begüm", "alkaptan", "begüm", "2", "uye", DateTime.Now));
            kisilerim.Add(new Kisi(3, "hülya", "alkaptan", "hülya", "3", "uye", DateTime.Now));
            kisilerim.Add(new Kisi(4, "recep", "alkaptan", "recep", "4", "uye", DateTime.Now));

            kitaplarim.Add(new Kitap(1, "İçimizdeki şeytan", "Bahattin Ali", "Türkçe", "Yapı Kredi Yayınları", "roman", 1200, 150, 2016));
            kitaplarim.Add(new Kitap(2, "Tutunamayanlar", "Oğuz Atay", "Türkçe", "İletişim Yayıncılık", "roman", 350, 760, 2015));
            kitaplarim.Add(new Kitap(3, "Uçurtma Avcısı", "Khaled husseini", "İngilizce", "everest yayıncılık", "roman", 100, 350, 2010));
            kitaplarim.Add(new Kitap(4, "Küçük prens","Antonie de Saint","İngilizce","everest yayıncılık","roman",50,60,2018));

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string kullaniciAdi, sifre = "";
            kullaniciAdi = text_kadi.Text;
            sifre = text_sifre.Text;
            bool control = false;
            
            foreach (Kisi kisi in kisilerim)
            {
                if (kullaniciAdi == kisi.getKullaniciAdi() && sifre == kisi.getSifre() && kisi.getYetki() == "admin")
                {
                    //admin sayfasına git
                    AdminPage adminPage = new AdminPage(kisilerim,kitaplarim);
                    adminPage.Show();
                    this.Hide();
                    control = true;
                    break;
                }
                else if (kullaniciAdi == kisi.getKullaniciAdi() && sifre == kisi.getSifre() && kisi.getYetki() == "uye")
                {
                    //Üye sayfasına git
                    UyePage uyePage = new UyePage(kitaplarim);
                    uyePage.Show();
                    this.Hide();
                    control = true;
                    break;
                }
               
            }
            if (!control)
            {
                MessageBox.Show("Hatalı kullanıcı adı ve ya şifre!");
            }
        }
    }
}
