using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyonu
{
    internal class Person
    {
        string isim;
        string soyisim;


        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }

    }

    abstract class Kullanıcı
    {
        public abstract void Bilgiler();
        string tckimlik;
        string sifre;

        public string Tckimlik { get => tckimlik; set => tckimlik = value; }
        public string Sifre { get => sifre; set => sifre = value; }
    }
    class Il
    {

        string klinik;
        DateTime tarih;
        string saat;

        public string Klinik { get => klinik; set => klinik = value; }
        public DateTime Tarih { get => tarih; set => tarih = value; }
        public string Saat { get => saat; set => saat = value; }

    }

}
