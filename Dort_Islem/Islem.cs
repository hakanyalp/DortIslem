using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dort_Islem
{
    class Islem
    {
        public string topla(string sayi1, string sayi2, bool elde_geldi_mi)
        {
            string sonuc = "";
            sayi1 = sayi1.Trim();
            sayi2 = sayi2.Trim();
            if (sayi2.Length > sayi1.Length)     // sayi1'in uzunluğu sayi2'den küçükse yer değiştir
            {
                string temp = sayi1;
                sayi1 = sayi2;
                sayi2 = temp;
            }   

            bool elde = false;

            if (elde_geldi_mi)  // virgülden gelen elde
                elde = true;

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
                if (topla1 > 9)     // satırı topladığımızda 9'dan büyükse elde var demektir
                {
                    elde = true;
                    topla1 -= 10;
                }
                sonuc += topla1.ToString();
            }
            if (elde)
                sonuc += "1";
            char[] sonucu_duzelt = sonuc.ToCharArray();
            Array.Reverse(sonucu_duzelt);
            sonuc = new string(sonucu_duzelt);
            return sifirlariTemizle(sonuc);
        }

        public string cikar(string sayi1, string sayi2, bool elde_geldi_mi)
        {
            string sonuc = "";
            sayi1 = sayi1.Trim();
            sayi2 = sayi2.Trim();
            bool sayi1_buyuk = true;   // sadece sonda - işaretini koymak için kullanılacak

            if (!sayi1_buyuk_mu(sayi1, sayi2))
            {
                sayi1_buyuk = false;
                string temp = sayi1;
                sayi1 = sayi2;
                sayi2 = temp;
            }

            bool komsudan_aldik_mi = false;

            if (elde_geldi_mi)  // virgülden gelen elde
                komsudan_aldik_mi = true;

            for (int i = 0; i < sayi1.Length; i++)
            {
                int cikar1 = Convert.ToInt32(sayi1.Substring(sayi1.Length - 1 - i, 1));
                int cikar2;
                if (sayi2.Length - i > 0)
                    cikar2 = Convert.ToInt32(sayi2.Substring(sayi2.Length - 1 - i, 1));
                else
                    cikar2 = 0;
                if (komsudan_aldik_mi)
                {
                    cikar1 -= 1;
                    komsudan_aldik_mi = false;
                }
                if (cikar1 > cikar2 || cikar1 == cikar2)
                    cikar1 = cikar1 - cikar2;
                else
                {
                    komsudan_aldik_mi = true;
                    cikar1 = cikar1 - cikar2 + 10;  // 10 komşudan geldi;
                }
                sonuc += cikar1.ToString();
            }
            char[] sonucu_duzelt = sonuc.ToCharArray();
            Array.Reverse(sonucu_duzelt);
            sonuc = new string(sonucu_duzelt);
            if (!sayi1_buyuk)
                sonuc = sonuc.Insert(0, "- ");
            return sifirlariTemizle(sonuc);
        }
        public string SadeceCikar(string sayi1, string sayi2, bool elde_geldi_mi)
        {
            string sonuc = "";
            sayi1 = sayi1.Trim();
            sayi2 = sayi2.Trim();
            //bool sayi1_buyuk = true;   // sadece sonda - işaretini koymak için kullanılacak

            if (!sayi1_buyuk_mu(sayi1, sayi2))
            {
                //sayi1_buyuk = false;
                string temp = sayi1;
                sayi1 = sayi2;
                sayi2 = temp;
            }

            bool komsudan_aldik_mi = false;

            if (elde_geldi_mi)  // virgülden gelen elde
                komsudan_aldik_mi = true;

            for (int i = 0; i < sayi1.Length; i++)
            {
                int cikar1 = Convert.ToInt32(sayi1.Substring(sayi1.Length - 1 - i, 1));
                int cikar2;
                if (sayi2.Length - i > 0)
                    cikar2 = Convert.ToInt32(sayi2.Substring(sayi2.Length - 1 - i, 1));
                else
                    cikar2 = 0;
                if (komsudan_aldik_mi)
                {
                    cikar1 -= 1;
                    komsudan_aldik_mi = false;
                }
                if (cikar1 > cikar2 || cikar1 == cikar2)
                    cikar1 = cikar1 - cikar2;
                else
                {
                    komsudan_aldik_mi = true;
                    cikar1 = cikar1 - cikar2 + 10;  // 10 komşudan geldi;
                }
                sonuc += cikar1.ToString();
            }
            char[] sonucu_duzelt = sonuc.ToCharArray();
            Array.Reverse(sonucu_duzelt);
            sonuc = new string(sonucu_duzelt);
            /*if (!sayi1_buyuk)
                sonuc = sonuc.Insert(0, "- ");*/
            return sifirlariTemizle(sonuc);
        }
        public string carp(string sayi1, string sayi2)
        {
            string sonuc = "";
            sayi1 = sayi1.Trim();
            sayi2 = sayi2.Trim();
            if (sayi2.Length > sayi1.Length)
            {
                string temp = sayi1;
                sayi1 = sayi2;
                sayi2 = temp;
            }
            int elde = 0;
            int carp1;
            int carp2;
            string[] toplamlar = new string[sayi2.Length];  // bu dizide her satırdaki toplama değerlerini tutacağız
            for (int i = 0; i < sayi2.Length; i++)
            {
                carp2 = Convert.ToInt32(sayi2.Substring(sayi2.Length - 1 - i, 1));
                string geciciSonuc = "";
                for (int j = 0; j < sayi1.Length; j++)
                {
                    carp1 = Convert.ToInt32(sayi1.Substring(sayi1.Length - 1 - j, 1));
                    carp1 = carp1 * carp2;
                    if (elde > 0)
                    {
                        carp1 += elde;
                        elde = 0;
                    }
                    elde = carp1 / 10;
                    carp1 = carp1 - elde * 10;
                    geciciSonuc += carp1.ToString();
                }
                if (elde > 0)
                {
                    geciciSonuc += elde;
                    elde = 0;
                }
                char[] sonucu_duzelt = geciciSonuc.ToCharArray();
                Array.Reverse(sonucu_duzelt);
                toplamlar[i] = new string(sonucu_duzelt);
            }

            int araToplam = 0;
            elde = 0;
            // for döngüsünü en uzun eleman kadar döndüreceğiz, bunun için dizideki en uzun elemanı bulmalıyız
            int uzunluk = 0;
            for (int i = 0; i < toplamlar.Length; i++)
            {
                if (toplamlar[i].Length > uzunluk)
                    uzunluk = toplamlar[i].Length;
            }
            for (int i = 0; i < uzunluk + toplamlar.Count() - 1; i++)   // ilk sayının uzunluğu ve toplamlar dizisinde kaç eleman varsa o kadar ek dönmesi gerekecek
            {
                for (int j = 0; j < toplamlar.Count(); j++)
                {
                    try
                    {
                        araToplam += Convert.ToInt32(toplamlar[j].Substring(toplamlar[j].Length - 1 - i + j, 1));
                    }
                    catch (ArgumentOutOfRangeException hata) { }
                }
                if (elde > 0)
                {
                    araToplam += elde;
                    elde = 0;
                }
                if (araToplam > 9)
                {
                    elde = araToplam / 10;
                    araToplam = araToplam % 10;     // elde'yi aldıktan sonra araSayı'nın son basamağını alıyoruz
                }
                sonuc += araToplam.ToString();
                araToplam = 0;
            }
            char[] sonucu_duzelt2 = sonuc.ToCharArray();
            Array.Reverse(sonucu_duzelt2);
            sonuc = new string(sonucu_duzelt2);
            return sifirlariTemizle(sonuc);
        }
        public string bol(string sayi1, string sayi2, int virgulHassasiyeti, bool virgul_geldi)
        {
            string sonuc = "";
            sayi1 = sayi1.Trim();
            sayi2 = sayi2.Trim();
            int sayac = 0;      // sayi1'in kaçıncı basamağında olduğumuzu sayıyor
            bool virgulKontrol = virgul_geldi;
            string cikar1 = "";     // sayi1'den sayi2'yi kacKati ile çarptıktan sonra çıkardığımız sonucu cikar1'e atıyoruz. Yani en sonda kalan değerini veriyor.
            sifirlariTemizle(cikar1);

            if (sayi2 == "0")
                return "HATA!";
            else if (sayi1 == "0")
                return "0";

            // buraya sayi1 == sayi2 durumu için if yazılabilir. sonuc 1 olur.  bunun için sayi1_buyuk_mu değişkeni farklı değerler döndürebilmeli
            else if (!sayi1_buyuk_mu(sayi1, sayi2))     // 10 / 100 gibi bir durum için koyduk
            {
                cikar1 = sayi1 + "0";
                sayac = sayi1.Length;   // ileride döngünün dönmemesi için
                sonuc += "0,";
                virgulKontrol = true;
                while (!sayi1_buyuk_mu(cikar1, sayi2))      // 0 yeterli olana kadar koyması için koyduk
                {
                    cikar1 += "0";
                    sonuc += "0";
                }
            }
            else
            {
                cikar1 = sayi1.Substring(0, sayi2.Length);
                sayac += sayi2.Length;  // 14016 / 210 işleminde cikar1 sayi2'den büyük olmayabilir. Bu yüzden if ile tekrar kontrol etmeliyiz
                if (!sayi1_buyuk_mu(cikar1, sayi2))
                {
                    cikar1 += sayi1.Substring(sayi2.Length, 1);     // sayı2.Length - 1 OLABİLİR. KONTROL ET
                    sayac++;
                }
            }
            bool birKereAldikMi;
            int virgulHassasiyetKontrol = 0;  // virgülden sonra kaç basamak olacağını belirlemek için
            while (true)    // bölünenin altındaki çıkarma işlemleri için döngü
            {
                birKereAldikMi = false;
                while(!sayi1_buyuk_mu(cikar1, sayi2))
                {
                    if (sayac < sayi1.Length)
                    {
                        if (cikar1 == "0")
                            cikar1 = sayi1.Substring(sayac, 1);
                        else
                            cikar1 += sayi1.Substring(sayac, 1);
                        sayac++;
                        if (!sayi1_buyuk_mu(cikar1, sayi2))
                            sonuc += "0";
                    }
                    else
                    {
                        cikar1 += "0";
                        if (virgulKontrol)
                        {
                            if (!birKereAldikMi)
                                birKereAldikMi = true;
                            else
                            {
                                sonuc += 0;
                                virgulHassasiyetKontrol++;
                            }
                        }
                        else
                        {
                            sonuc += ",";
                            virgulKontrol = true;
                            birKereAldikMi = true;
                        }
                    }
                }
                int carpim = kacKati(cikar1, sayi2);        // kacKati fonksiyonundan string döndür, aynı çarpmayı 2 kere yapmaya gerek kalmasın.
                cikar1 = cikar(cikar1, carp(sayi2, carpim.ToString()), false);
                sonuc += carpim.ToString();

                if (cikar1 == "0" && sayac == sayi1.Length)     // işlemin bitmesi durumunda çıkış
                    return sonuc;

                if (virgulKontrol)  // kullanıcı isteği ile çıkış
                {
                    virgulHassasiyetKontrol++;
                    if (virgulHassasiyetKontrol >= virgulHassasiyeti)
                    {
                        sonuc += "...";
                        return sonuc;
                    }
                }
            }
        }
         
        private int kacKati(string sayi1, string sayi2)  // sayi2'yi en fazla kaç ile çarptığımızda sayi1'i geçmeyeceğini bulan fonksiyon
        {
            string kontrol;
            int i;
            for (i = 1; ; i++)
            {
                kontrol = cikar(sayi1, carp(sayi2, i.ToString()), false);
                if (kontrol.StartsWith("-"))
                    return (i - 1);
            }
        }

        public bool sayi1_buyuk_mu(string sayi1, string sayi2)     // sayi1'in sayi2'den büyük mü olduğunu kontrol eden fonksiyon
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
        private string sifirlariTemizle(string sayi)    // Eksi sayılar dahil, gönderilen sayının başındaki sıfırları siliyor.
        {
            bool eksiliSayi = false;
            if (sayi.StartsWith("-"))
            {
                sayi = sayi.Remove(0, 2);
                eksiliSayi = true;
            }
            while (sayi.StartsWith("0"))
                sayi = sayi.Remove(0, 1);
            if (sayi.Length == 0)
                sayi = "0";

            if (eksiliSayi)
                sayi = sayi.Insert(0, "- ");

            return sayi;
        }
    }
}
