using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyonu
{
    internal class Hasta : Person
    {
        string dt;
        string dy;
        string cinsiyet;
        string telefon;

        public string Dt { get => dt; set => dt = value; }
        public string Dy { get => dy; set => dy = value; }
        public string Cinsiyet { get => cinsiyet; set => cinsiyet = value; }
        public string Telefon { get => telefon; set => telefon = value; }
    }
    class HastaGiris : Kullanıcı
    {
        public override void Bilgiler()
        {

        }
    }
    class Hastail : Il
    {
        int iller;
        string ıll;

        public int Iller { get => iller; set => iller = value; }
        public string Ill { get => ıll; set => ıll = value; }
    }

}
