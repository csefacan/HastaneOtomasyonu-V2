using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyonu
{
    internal class Sekreter : Person
    {



    }
    class SekreterGiris : Kullanıcı
    {
        public override void Bilgiler()
        {

        }
    }
    class Sekreteril : Il
    {
        string hastatc;
        string iller;

        public string Hastatc { get => hastatc; set => hastatc = value; }
        public string Iller { get => iller; set => iller = value; }
    }

}
