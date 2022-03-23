using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeCalismasi.Siniflar
{
    public class SoruCevap
    {
        public int SoruCevapID { get; set; }
        public int IsyeriID { get; set; }
        public int SoranID { get; set; }
        public string Soru { get; set; }
        public int CevapID { get; set; }
        public string Cevap { get; set; }
        public byte Durum { get; set; }
    }
}
