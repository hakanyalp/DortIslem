using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dort_Islem
{
    class virgulIslem
    {
        public string topla(virgulluSayi v1, virgulluSayi v2)
        {
            v1.elde = false;
            string sayi1 = v1.sayi_virgul;
            string sayi2 = v2.sayi_virgul;
            string sonuc = "";
            sayi1 = sayi1.Trim();
            sayi2 = sayi2.Trim();
            if (sayi2.Length > sayi1.Length)     // sayıların uzunluklarını eşitliyoruz
            {
                int fark = sayi2.Length - sayi1.Length;
                for (int i = 0; i < fark; i++)
                {
                    sayi1 += "0";
                }
            }
            else if (sayi1.Length > sayi2.Length)
            {
                int fark = sayi1.Length - sayi2.Length;
                for (int i = 0; i < fark; i++)
                {
                    sayi2 += "0";
                }
            }

            bool elde = false;
            for (int i = 0; i < sayi1.Length; i++)
            {
                int topla1 = Convert.ToInt32(sayi1.Substring(sayi1.Length - 1 - i, 1));
                int topla2;
                try
                {
                    topla2 = Convert.ToInt32(sayi2.Substring(sayi2.Length - 1 - i, 1));
                }
                catch (ArgumentOutOfRangeException hata)
                {
                    topla2 = 0;
                }
                topla1 = topla1 + topla2;
                if (elde)
                {
                    topla1 += 1;    // elde varsa 1 topluyoruz;
                    elde = false;
                }
                if (topla1 > 9 && i == sayi1.Length - 1)
                {
                    v1.elde = true;
                    topla1 -= 10;
                }
                    
                else if (topla1 > 9)     // satırı topladığımızda 9'dan büyükse elde var demektir
                {
                    elde = true;
                    topla1 -= 10;
                }
                sonuc += topla1.ToString();
            }
            if (elde)
                v1.elde = true;
            char[] sonucu_duzelt = sonuc.ToCharArray();
            Array.Reverse(sonucu_duzelt);
            sonuc = new string(sonucu_duzelt);
            return sifirlariTemizle(sonuc);
        }
        public string cikar(virgulluSayi v1, virgulluSayi v2)
        {
            v1.elde = false;
            string sayi1 = v1.sayi_virgul;
            string sayi2 = v2.sayi_virgul;
            string sonuc = "";
            sayi1 = sayi1.Trim();
            sayi2 = sayi2.Trim();
            if (!sayi1_buyuk_mu(v1.sayi, v2.sayi))
            {
                string temp = sayi1;
                sayi1 = sayi2;
                sayi2 = temp;
            }
            else if (v1.sayi == v2.sayi)    // virgül öncesi eşitse virgül sonrasını karşılaştırıyoruz
            {
                if (!sayi1_buyuk_mu(sayi1, sayi2))
                {
                    string temp = sayi1;
                    sayi1 = sayi2;
                    sayi2 = temp;
                }
            }
            if (sayi2.Length > sayi1.Length)     // sayıların uzunluklarını eşitliyoruz
            {
                int fark = sayi2.Length - sayi1.Length;
                for (int i = 0; i < fark; i++)
                {
                    sayi1 += "0";
                }
            }
            else if (sayi1.Length > sayi2.Length)
            {
                int fark = sayi1.Length - sayi2.Length;
                for (int i = 0; i < fark; i++)
                {
                    sayi2 += "0";
                }
            }
            bool komsudan_aldik_mi = false;
            for (int i = 0; i < sayi1.Length; i++)
            {
                int cikar1 = Convert.ToInt32(sayi1.Substring(sayi1.Length - 1 - i, 1));
                int cikar2 = Convert.ToInt32(sayi2.Substring(sayi2.Length - 1 - i, 1));
                if (komsudan_aldik_mi)  // if (komsudan_aldik_mi && i != sayi1.Length - 1)
                {
                    cikar1 -= 1;
                    komsudan_aldik_mi = false;
                }
                if (cikar1 > cikar2 || cikar1 == cikar2)
                    cikar1 = cikar1 - cikar2;
                else
                {
                    cikar1 = cikar1 - cikar2 + 10;  // 10 komşudan geldi;
                    komsudan_aldik_mi = true;
                }
                sonuc += cikar1.ToString();
            }
            if (komsudan_aldik_mi)
                v1.elde = true;
            char[] sonucu_duzelt = sonuc.ToCharArray();
            Array.Reverse(sonucu_duzelt);
            sonuc = new string(sonucu_duzelt);
            return sifirlariTemizle(sonuc);
        }

        private string sifirlariTemizle(string sayi)    // Eksi sayılar dahil, gönderilen sayının başındaki sıfırları siliyor.
        {
            if (!sayi.StartsWith("-"))
            {
                while (sayi.StartsWith("0"))
                    sayi = sayi.Remove(0, 1);
                if (sayi.Length == 0)
                    sayi = "0";
                return sayi;
            }
            else
            {
                try
                {
                    while (sayi.Substring(2, 1) == "0")
                        sayi = sayi.Remove(2, 1);
                }
                catch (Exception hata)
                {
                    sayi = "0";     // - 000 gibi bir sayıda bütün sıfırlar silineceğinden sayıyı 0 yapıyoruz
                    return sayi;
                }
                return sayi;
            }
        }
        private bool sayi1_buyuk_mu(string sayi1, string sayi2)     // sayi1'in sayi2'den büyük mü olduğunu kontrol eden fonksiyon
        {
            sayi1 = sifirlariTemizle(sayi1);
            sayi2 = sifirlariTemizle(sayi2);

            if (sayi1.Length > sayi2.Length)
                return true;
            else if (sayi2.Length > sayi1.Length)
                return false;

            if (sayi1 == sayi2)
                return true;
            else    // if (sayi1.Length == sayi2.Length)
            {
                int kontrol1, kontrol2;
                for (int i = 0; i < sayi1.Length; i++)
                {
                    kontrol1 = Convert.ToInt32(sayi1.Substring(i, 1));
                    kontrol2 = Convert.ToInt32(sayi2.Substring(i, 1));
                    if (kontrol1 > kontrol2)
                        return true;
                    else if (kontrol1 < kontrol2)
                        return false;
                }
                return false;
            }
        }
    }
}
