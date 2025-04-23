using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama
{
    public class Hali
    {
        public double Metrekare { get; set; }
        public DateTime AlimTarihi { get; set; }
        public DateTime TahminiTeslimTarihi { get; set; }
        public bool TeslimEdildi { get; set; }

        public double Ucret => Metrekare * 20;

        public string Durum => TeslimEdildi ? "Teslim Edildi" : "Yıkamada";

        public override string ToString()
        {
            return $"Halı - {Metrekare} m² - {Durum} - Ücret: {Ucret} TL";
        }
    }

}
