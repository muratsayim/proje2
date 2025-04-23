using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama
{
    public class Musteri
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Telefon { get; set; }
        public string Adres { get; set; }
        public List<Hali> Halilar { get; set; }

        public Musteri()
        {
            Halilar = new List<Hali>();
        }

        public override string ToString()
        {
            return $"{Ad} {Soyad} - {Telefon}";
        }
    }

}
