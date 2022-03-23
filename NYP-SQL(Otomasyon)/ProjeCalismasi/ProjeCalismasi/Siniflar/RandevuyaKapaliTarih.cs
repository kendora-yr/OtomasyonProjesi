using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeCalismasi.Siniflar
{
    public class RandevuyaKapaliTarih
    {
        public int KapaliTarihID { get; set; }
        public int IsyeriID { get; set; }
        public int BaslangicSaat { get; set; }
        public int BitisSaat { get; set; }
        public string Gun { get; set; }
    }
}
