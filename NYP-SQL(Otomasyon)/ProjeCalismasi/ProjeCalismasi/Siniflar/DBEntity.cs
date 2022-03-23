using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeCalismasi.Siniflar
{
    public class DBEntity
    {
        public string connStr { get; private set; }
        public DBEntity()
        {
            connStr = @"Data Source=.\; Initial Catalog= Proje; Integrated Security= True";
        }
    }
}
