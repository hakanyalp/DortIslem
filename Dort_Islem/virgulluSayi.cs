using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dort_Islem
{
    class virgulluSayi
    {
        public string sayi;
        public string sayi_virgul;
        public bool elde;
        public virgulluSayi(string sayi)
        {
            this.sayi = sayi;
            this.sayi_virgul = "0";
        }
        public virgulluSayi(string gelen_sayi, int sayi_index)
        {
                this.sayi = gelen_sayi.Substring(0, sayi_index);
                this.sayi_virgul = gelen_sayi.Substring(sayi_index + 1, gelen_sayi.Length - (sayi_index + 1));
        }
    }
}
