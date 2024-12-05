using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyonu
{
    internal class Doktor : Person
    {
        string brans;


        public string Brans { get => brans; set => brans = value; }
    }
    class DoktorGiris : Kullanıcı
    {
        public override void Bilgiler()
        {

        }
    }
    class Doktoril : Il
    {
        string iller;

        public string Iller { get => iller; set => iller = value; }
    }

}
