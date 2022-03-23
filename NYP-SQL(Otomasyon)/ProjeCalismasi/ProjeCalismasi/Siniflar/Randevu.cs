using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeCalismasi.Siniflar
{
    public class Randevu
    {
        public int RandevuID { get; set; }
        public int IsyeriID { get; set; }
        public string RandevuTarihi { get; set; }
        public int RandevuSaati { get; set; }
        public int OnayDurum { get; set; }
        public int RandevuAlanID { get; set; }
    }
}
