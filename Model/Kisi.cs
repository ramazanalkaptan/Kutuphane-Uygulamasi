using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kutuphaneOtomasyon.Model
{
    public class Kisi
    {
        public int id { get; set; }
        public string name { get; set; }
        public string lastname { get; set; }
        public string kullaniciAdi { get; set; }
        public string sifre { get; set; }
        public string yetki { get; set; }
        public DateTime olusturmaTarih { get; set; }

        public Kisi()
        {
            
        }
        public Kisi(int id,string name,string lastname,string kullaniciAdi,string sifre,string yetki,DateTime olusturmaTarih)
        {
            this.id = id;
            this.name = name;
            this.lastname = lastname;
            this.kullaniciAdi = kullaniciAdi;
            this.sifre = sifre;
            this.yetki = yetki;
            this.olusturmaTarih = olusturmaTarih;
        }

        public void setId(int id)
        {
            this.id =id;
        }
        public int getId()
        {
            return this.id;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public string getName()
        {
            return this.name;
        }
        public void setLastname(string lastname)
        {
            this.lastname = lastname;
        }
        public string getLastname()
        {
            return this.lastname;
        }
        public void setKullaniciAdi(string kullaniciAdi)
        {
            this.kullaniciAdi= kullaniciAdi;
        }
        public string getKullaniciAdi()
        {
            return this.kullaniciAdi;
        }
        public void setSifre(string sifre)
        {
            this.sifre = sifre;
        }
        public string getSifre()
        {
            return this.sifre;
        }
        public void setYetki(string yetki)
        {
            this.yetki = yetki;
        }
        public string getYetki()
        {
            return this.yetki;
        }
        public void setOlusturmaTarih(DateTime olusturmaTarih)
        {
            this.olusturmaTarih = olusturmaTarih;
        }
        public DateTime getOlusturmaTarih()
        {
            return this.olusturmaTarih;
        }
    }
}
