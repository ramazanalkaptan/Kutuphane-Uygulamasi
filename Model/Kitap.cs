using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kutuphaneOtomasyon.Model
{
    public class Kitap
    {
        public int kitapid { get; set; }
        public string kitapisim { get; set; }
        public string kitapYazar { get; set; }
        public string kitapdili { get; set; }
        public string yayinevi { get; set; }
        public string tur { get; set; }
        public int adet { get; set; }
        public int sayfasayisi { get; set; }
        public int basimyili { get; set; }

        public Kitap()
        {

        }

        public Kitap(int kitapid, string kitapisim, string kitapYazar, string kitapdili, string yayinevi, string tur, int adet, int sayfasayisi, int basimyili)
        {
            this.kitapid = kitapid;
            this.kitapisim = kitapisim;
            this.kitapYazar = kitapYazar;
            this.kitapdili = kitapdili;
            this.yayinevi = yayinevi;
            this.tur = tur;
            this.adet = adet;
            this.sayfasayisi = sayfasayisi;
            this.basimyili = basimyili;
        }
        public int getkitapid() { return this.kitapid; }
        public string getkitapisim() { return this.kitapisim; }
        public string getkitapYazar() { return this.kitapYazar; }
        public string getkitapdili() { return this.kitapdili; }
        public string getyayinevi() { return this.yayinevi; }
        public string gettur() { return this.tur; }
        public int getadet() { return this.adet; }
        public int getsayfasayisi() { return this.sayfasayisi; }
        public int getbasimyili() { return this.basimyili; }
    }
}
