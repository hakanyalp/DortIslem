using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dort_Islem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Islem islem = new Islem();
        virgulIslem vIslem = new virgulIslem();
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            if (txtSayi1.Text != "" && txtSayi2.Text != "")
            {
                label3.Visible = true;
                txtSonuc.Visible = true;
                txtSonuc.Text = "";

                bool sayi1_eksi = false;
                bool sayi2_eksi = false;
                if (txtSayi1.Text.StartsWith("-"))
                    sayi1_eksi = true;
                if (txtSayi2.Text.StartsWith("-"))
                    sayi2_eksi = true;

                if (sayi1_eksi == true && sayi2_eksi == false)
                    txtSayi1.Text = txtSayi1.Text.Remove(0, 1); // - ifadesi siliniyor
                else if (sayi1_eksi == false && sayi2_eksi == true)
                    txtSayi2.Text = txtSayi2.Text.Remove(0, 1); // - ifadesi siliniyor
                else if (sayi1_eksi == true && sayi2_eksi == true)
                {
                    txtSayi1.Text = txtSayi1.Text.Remove(0, 1); // - ifadesi siliniyor
                    txtSayi2.Text = txtSayi2.Text.Remove(0, 1); // - ifadesi siliniyor
                }

                virgulKontrol();

                if (rdTopla.Checked == true)
                {
                    if (sayi1_eksi == false && sayi2_eksi == false)
                    {
                        if (!virgul_geldi_mi)
                            txtSonuc.Text = islem.topla(txtSayi1.Text, txtSayi2.Text, false); // 3. parametre virgulden sonraki toplamada elde kalırsa eklemek için
                        else
                        {
                            string virgul_sonuc = vIslem.topla(v1, v2);  // virgülden gelebilecek eldenin hesaplanabilmesi için normal işlemden önce hesaplanması gerekiyor
                            txtSonuc.Text = islem.topla(v1.sayi, v2.sayi, v1.elde) + "," + virgul_sonuc;
                        }
                    }
                    else if (sayi1_eksi == true && sayi2_eksi == false)
                    {
                        if (sayi1_buyuk_mu(txtSayi1.Text, txtSayi2.Text))   // sayi1 - & sayi1 > sayi sonuç -
                        {
                            txtSonuc.Text = "- ";
                            if (!virgul_geldi_mi)
                                txtSonuc.Text += islem.SadeceCikar(txtSayi1.Text, txtSayi2.Text, false); // 3. parametre virgulden sonraki toplamada elde kalırsa eklemek için
                            else
                            {
                                string virgul_sonuc = vIslem.topla(v1, v2);  // virgülden gelebilecek eldenin hesaplanabilmesi için normal işlemden önce hesaplanması gerekiyor
                                txtSonuc.Text += islem.topla(v1.sayi, v2.sayi, v1.elde) + "," + virgul_sonuc;
                            }
                        }
                        else   // sayi1 - & sayi2 > sayi1  yani sonuç +
                        {
                            txtSonuc.Text = "-";
                            if (!virgul_geldi_mi)
                                txtSonuc.Text = islem.SadeceCikar(txtSayi2.Text, txtSayi1.Text, false); // 3. parametre virgulden sonraki toplamada elde kalırsa eklemek için
                            else
                            {
                                string virgul_sonuc = vIslem.cikar(v2, v1);  // virgülden gelebilecek eldenin hesaplanabilmesi için normal işlemden önce hesaplanması gerekiyor
                                txtSonuc.Text = islem.SadeceCikar(v2.sayi, v1.sayi, v1.elde) + "," + virgul_sonuc;
                            }
                        }
                        txtSayi1.Text = txtSayi1.Text.Insert(0, "-");
                    }
                    else if (sayi1_eksi == false && sayi2_eksi == true)
                    {
                        if (!sayi1_buyuk_mu(txtSayi1.Text, txtSayi2.Text))  // sayi2 -  & sayi2 > sayi1 sonuç - 
                        {
                            txtSonuc.Text = "- ";
                            if (!virgul_geldi_mi)
                                txtSonuc.Text += islem.SadeceCikar(txtSayi2.Text, txtSayi1.Text, false); // 3. parametre virgulden sonraki toplamada elde kalırsa eklemek için
                            else
                            {
                                string virgul_sonuc = vIslem.cikar(v2, v1);  // virgülden gelebilecek eldenin hesaplanabilmesi için normal işlemden önce hesaplanması gerekiyor
                                txtSonuc.Text += islem.SadeceCikar(v2.sayi, v1.sayi, v1.elde) + "," + virgul_sonuc;
                            }
                        }
                        else  // sayi2 - & sayi1 > sayi2 yani sonuc + 
                        {
                            if (!virgul_geldi_mi)
                                txtSonuc.Text = islem.SadeceCikar(txtSayi1.Text, txtSayi2.Text, false); // 3. parametre virgulden sonraki toplamada elde kalırsa eklemek için
                            else
                            {
                                string virgul_sonuc = vIslem.topla(v1, v2);  // virgülden gelebilecek eldenin hesaplanabilmesi için normal işlemden önce hesaplanması gerekiyor
                                txtSonuc.Text = islem.topla(v1.sayi, v2.sayi, v1.elde) + "," + virgul_sonuc;
                            }
                        }
                        txtSayi2.Text = txtSayi2.Text.Insert(0, "-");
                    }
                    else if (sayi1_eksi == true && sayi2_eksi == true)
                    {
                        txtSonuc.Text = "- ";
                        if (!virgul_geldi_mi)
                            txtSonuc.Text += islem.topla(txtSayi1.Text, txtSayi2.Text, false); // 3. parametre virgulden sonraki toplamada elde kalırsa eklemek için
                        else
                        {
                            string virgul_sonuc = vIslem.topla(v1, v2);  // virgülden gelebilecek eldenin hesaplanabilmesi için normal işlemden önce hesaplanması gerekiyor
                            txtSonuc.Text += islem.topla(v1.sayi, v2.sayi, v1.elde) + "," + virgul_sonuc;
                        }
                        txtSayi1.Text = txtSayi1.Text.Insert(0, "-");
                        txtSayi2.Text = txtSayi2.Text.Insert(0, "-");
                    }
                    else
                    {
                        MessageBox.Show("Toplama eksi kontrolde sorun var!!");
                    }
                }
                else if (rdCikar.Checked == true)
                {
                    if (sayi1_eksi == false && sayi2_eksi == false)
                    {
                        if (!virgul_geldi_mi)
                            txtSonuc.Text = islem.cikar(txtSayi1.Text, txtSayi2.Text, false);
                        else
                        {
                            string virgul_sonuc = vIslem.cikar(v1, v2);  // virgülden gelebilecek eldenin hesaplanabilmesi için normal işlemden önce hesaplanması gerekiyor
                            txtSonuc.Text = islem.cikar(v1.sayi, v2.sayi, v1.elde) + "," + virgul_sonuc;
                        }
                    }
                    else if (sayi1_eksi == true && sayi2_eksi == false) // -sayi1 -sayi2 sonuç kesin -
                    {
                        txtSonuc.Text = "- ";
                        if (!virgul_geldi_mi)
                            txtSonuc.Text += islem.topla(txtSayi1.Text, txtSayi2.Text, false);
                        else
                        {
                            string virgul_sonuc = vIslem.topla(v1, v2);  // virgülden gelebilecek eldenin hesaplanabilmesi için normal işlemden önce hesaplanması gerekiyor
                            txtSonuc.Text += islem.topla(v1.sayi, v2.sayi, v1.elde) + "," + virgul_sonuc;
                        }
                        txtSayi1.Text = txtSayi1.Text.Insert(0, "-");
                    }
                    else if (sayi1_eksi == false && sayi2_eksi == true) // sayi1 - (-sayi2) sonuç kesin +
                    {
                        if (!virgul_geldi_mi)
                            txtSonuc.Text = islem.topla(txtSayi1.Text, txtSayi2.Text, false);
                        else
                        {
                            string virgul_sonuc = vIslem.topla(v1, v2);
                            txtSonuc.Text = islem.topla(v1.sayi, v2.sayi, v1.elde) + "," + virgul_sonuc;
                        }
                        txtSayi2.Text = txtSayi2.Text.Insert(0, "-");
                    }
                    else if (sayi1_eksi == true && sayi2_eksi == true)
                    {
                        txtSonuc.Text = "-";
                        if (!virgul_geldi_mi)
                            txtSonuc.Text += islem.topla(txtSayi1.Text, txtSayi2.Text, false);
                        else
                        {
                            string virgul_sonuc = vIslem.topla(v1, v2);
                            txtSonuc.Text += islem.topla(v1.sayi, v2.sayi, v1.elde) + "," + virgul_sonuc;
                        }

                        txtSayi1.Text = txtSayi1.Text.Insert(0, "-");
                        txtSayi2.Text = txtSayi2.Text.Insert(0, "-");
                    }
                    else
                    {
                        MessageBox.Show("Çıkar eksi kontrolde sorun var!!");
                    }
                }
                else if (rdCarp.Checked == true)
                {
                    if ((sayi1_eksi == true && sayi2_eksi == false) || (sayi1_eksi == false && sayi2_eksi == true))
                        txtSonuc.Text = "-";

                    if (!virgul_geldi_mi)
                        txtSonuc.Text += islem.carp(txtSayi1.Text, txtSayi2.Text);
                    else
                    {
                        string sonuc = islem.carp(v1.sayi + v1.sayi_virgul, v2.sayi + v2.sayi_virgul);
                        int virgulBasamak = v1.sayi_virgul.Length + v2.sayi_virgul.Length;
                        sonuc = sonuc.Insert(sonuc.Length - virgulBasamak, ",");
                        txtSonuc.Text += sonuc;
                    }
                    if (sayi1_eksi == true)
                        txtSayi1.Text = txtSayi1.Text.Insert(0, "-");
                    if (sayi2_eksi == true)
                        txtSayi2.Text = txtSayi2.Text.Insert(0, "-");
                }
                else if (rdBol.Checked == true)
                {
                    if ((sayi1_eksi == true && sayi2_eksi == false) || (sayi1_eksi == false && sayi2_eksi == true))
                        txtSonuc.Text = "-";

                    if (!virgul_geldi_mi)
                    {
                        if (txtHassasiyet.Text == "")
                            txtHassasiyet.Text = "20";  // eğer kullanıcı girmezse otomatik 20 atıyor
                        txtSonuc.Text += islem.bol(txtSayi1.Text, txtSayi2.Text, Convert.ToInt32(txtHassasiyet.Text), false);
                    }
                    else
                    {
                        if (txtHassasiyet.Text == "")
                            txtHassasiyet.Text = "20";
                        int virgulBasamak = 0;  // virgülden sonra kaç basamak olduğu bilgisi
                        if (v1.sayi_virgul != "0")
                            virgulBasamak += v1.sayi_virgul.Length;
                        if (v2.sayi_virgul != "0")
                            virgulBasamak -= v2.sayi_virgul.Length;
                        int index = 0;
                        string sayi1_uzun = v1.sayi + v1.sayi_virgul;
                        for (int i = 0; i < txtSayi1.Text.Length; i++)
                        {
                            if (txtSayi1.Text.Substring(i, 1) == ",")
                            {
                                index = i;
                            }
                        }
                        v1.sayi = sayi1_uzun.Substring(0, index + virgulBasamak);
                        v1.sayi_virgul = sayi1_uzun.Substring(index + virgulBasamak, sayi1_uzun.Length - (index + virgulBasamak));
                        string sayi1 = v1.sayi;
                        if (v1.sayi_virgul != "0")
                            sayi1 += v1.sayi_virgul;
                        string sayi2 = v2.sayi;
                        if (v2.sayi_virgul != "0")
                            sayi2 += v2.sayi_virgul;
                        string sonuc = islem.bol(sayi1, sayi2, Convert.ToInt32(txtHassasiyet.Text), true);
                        sonuc = sonuc.Insert(sonuc.Length - virgulBasamak, ",");
                        txtSonuc.Text += sonuc;
                    }
                    if (sayi1_eksi == true)
                        txtSayi1.Text = txtSayi1.Text.Insert(0, "-");
                    if (sayi2_eksi == true)
                        txtSayi2.Text = txtSayi2.Text.Insert(0, "-");
                }
                else
                {
                    label3.Visible = false;
                    txtSonuc.Visible = false;
                    MessageBox.Show("Hata! İşlem Seçiniz");
                }
            }
            else
                MessageBox.Show("İşlem yapabilmek için 2 sayıyı da girmelisiniz!");
        }
        private void rdBol_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBol.Checked == true)
            {
                lblVirgulSor.Visible = true;
                txtHassasiyet.Visible = true;
            }
            else
            {
                lblVirgulSor.Visible = false;
                txtHassasiyet.Visible = false;
                txtHassasiyet.Text = "";
            }
        }
        bool virgul_geldi_mi = false;
        virgulluSayi v1;
        virgulluSayi v2;
        private void virgulKontrol()
        {
            if (v1 != null)
                v1 = null;
            if (v2 != null)
                v2 = null;
            virgul_geldi_mi = false;
            string sayi1 = txtSayi1.Text.ToString();
            string sayi2 = txtSayi2.Text.ToString();
            for (int i = 0; i < sayi1.Length; i++)
            {
                if (sayi1.Substring(i, 1) == ",")
                {
                    v1 = new virgulluSayi(sayi1, i);
                    if (v2 == null)
                        v2 = new virgulluSayi(sayi2);   // virgülden sonrası 0 olan sayı oluşturduk
                    virgul_geldi_mi = true;
                    break;
                }
            }
            for (int i = 0; i < sayi2.Length; i++)
            {
                if (sayi2.Substring(i, 1) == ",")
                {
                    v2 = new virgulluSayi(sayi2, i);
                    if (v1 == null)
                        v1 = new virgulluSayi(sayi1);
                    virgul_geldi_mi = true;
                    break;
                }
            }
        }

        public bool sayi1_buyuk_mu(string sayi1, string sayi2)     // sayi1'in sayi2'den büyük mü olduğunu kontrol eden fonksiyon
        {
            if (sayi1.Length > sayi2.Length)
                return true;
            else if (sayi2.Length > sayi1.Length)
                return false;

            if (sayi1 == sayi2)
                return true;
            else    // if (sayi1.Length == sayi2.Length)
            {
                int kontrol1 = 0, kontrol2 = 0;
                for (int i = 0; i < sayi1.Length; i++)
                {
                    try
                    {
                        kontrol1 = Convert.ToInt32(sayi1.Substring(i, 1));
                    }
                    catch (Exception hata)
                    {
                        // bişey yapma
                    }
                    try
                    {
                        kontrol2 = Convert.ToInt32(sayi2.Substring(i, 1));
                    }
                    catch (Exception hata)
                    {
                        // bişey yapma
                    }
                    if (kontrol1 > kontrol2)
                        return true;
                    else if (kontrol1 < kontrol2)
                        return false;
                }
                return false;
            }
        }
        string sayi1Text;
        private void txtSayi1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled != char.IsDigit(e.KeyChar) || e.Handled != char.IsControl(e.KeyChar) || e.KeyChar == ',')
            {
                e.Handled = false;
                errorProvider1.Clear();
            }
            else if ((int)e.KeyChar == 43)  // topla
            {
                txtSayi2.Focus();
                rdTopla.Checked = true;
                e.Handled = true;
            }
            else if ((int)e.KeyChar == 45)  // çıkar
            {
                if (txtSayi1.Text == "")
                {
                    e.Handled = false;
                }
                else
                {
                    txtSayi2.Focus();
                    rdCikar.Checked = true;
                    e.Handled = true;
                }
            }
            else if ((int)e.KeyChar == 42)   // çarp
            {
                txtSayi2.Focus();
                rdCarp.Checked = true;
                e.Handled = true;
            }
            else if ((int)e.KeyChar == 47)  // böl
            {
                txtSayi2.Focus();
                rdBol.Checked = true;
                e.Handled = true;
            }
            else
            {
                e.Handled = true;
                errorProvider1.SetError(txtSayi1, "Lütfen sayısal ifadeler girin!");
            }
        }
        private void txtSayi2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled != char.IsDigit(e.KeyChar) || e.Handled != char.IsControl(e.KeyChar) || e.KeyChar == ',')
            {
                e.Handled = false;
                errorProvider1.Clear();
            }
            else if ((int)e.KeyChar == 45)
            {
                if (txtSayi2.Text == "")
                    e.Handled = false;
                else
                {
                    e.Handled = true;
                    errorProvider1.SetError(txtSayi2, "- ifadesini sadece en başta kullanabilirsiniz!");
                }
            }
            else
            {
                e.Handled = true;
                errorProvider1.SetError(txtSayi2, "Lütfen sayısal ifadeler girin!");
            }
        }

        private void txtSayi1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                btnHesapla_Click(btnHesapla, new EventArgs());
                txtSayi1.Focus();
            }
        }

        private void txtSayi2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                btnHesapla_Click(btnHesapla, new EventArgs());
                txtSayi1.Focus();
            }
        }

        private void txtSayi1_Enter(object sender, EventArgs e)
        {
            txtSayi1.Text = txtSayi1.Text;  // hepsini seçmek için
        }

        private void txtSayi2_Enter(object sender, EventArgs e)
        {
            txtSayi2.Text = txtSayi2.Text;
        }
    }
}
