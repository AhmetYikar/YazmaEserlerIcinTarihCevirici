using OndalıkTarihBulucu.Methods;
using OndalıkTarihBulucu.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OndalıkTarihBulucu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }







        private void button1_Click(object sender, EventArgs e)
        {
            string tarihSonuc = "";
            string tarihG = "";
            string tarihA = "";
            string tarihY = "";


            if (txtGun.Text.Length > 0 && txtYil.Text.Length > 0 && cmbAy.SelectedIndex > -1)
            {
                #region YilYazi

                int sene = 0;

                int birler, onlar, yuzler, binler;
                sene = Convert.ToInt32(txtYil.Text);
                if (sene == 0)
                {
                    sene = 1;
                }
                int seneIlk = sene;

                binler = sene / 1000;
                sene = sene - (binler * 1000);
                yuzler = sene / 100;
                sene = sene - (yuzler * 100);
                onlar = sene / 10;
                sene = sene - (onlar * 10);
                birler = sene;


                string binlerS = binler.ToString();
                string yuzlerS = yuzler.ToString();
                string onlarS = onlar.ToString();
                string birlerS = onlar.ToString();

                string[] ArapcaRakamlar = { "الأول", "الثاني", "الثالث", "الرابع", "الخامس", "السادس", "السابع", "الثامن", "التاسع", "العاشر" };

                binlerS = ArapcaRakamlar[binler];
                yuzlerS = ArapcaRakamlar[yuzler];
                onlarS = ArapcaRakamlar[onlar];

                // 0'lı basamaklar

                if (seneIlk % 10 == 0)
                {
                    if (seneIlk % 100 == 0)
                    {
                        if (seneIlk % 1000 == 0)
                        {
                            onlarS = "العاشر";
                            yuzlerS = "العاشر";
                            binlerS = ArapcaRakamlar[binler - 1];
                        }
                        else
                        {
                            onlarS = "العاشر";
                            yuzlerS = ArapcaRakamlar[yuzler - 1];
                        }

                    }
                    else
                    {
                        onlarS = ArapcaRakamlar[onlar - 1];
                    }

                }



                // birler basamağının 0 olması durumu
                if (birler == 0)
                {
                    birlerS = "العاشر";
                }

                else
                {
                    birlerS = ArapcaRakamlar[birler - 1];
                }

                if (txtYil.TextLength > 3)
                {
                    tarihY = " من العُشر [" + birlerS + "] من العَشر [" + onlarS + "] من العَقد [" + yuzlerS + "] من الألف [" + binlerS + "]";

                }
                else if (txtYil.TextLength > 2)
                {
                    tarihY = " من العُشر [" + birlerS + "] من العَشر [" + onlarS + "] من العَقد [" + yuzlerS + "]";

                }
                else
                {
                    tarihY = " من العُشر [" + birlerS + "] من العَشر [" + onlarS + "]";
                }

                #endregion

                #region AyYazi


                int a = cmbAy.SelectedIndex;

                string[] nisfAylar = { "الأول", "الثاني" };
                string[] südüsAylar = { "الأول", "الثاني", "الثالث", "الرابع", "الخامس", "السادس" };

                string nisfAy = "";
                string südüsAy = "";

                if (a < 6)
                {
                    nisfAy = nisfAylar[0];
                    südüsAy = südüsAylar[a];

                }
                else
                {
                    nisfAy = nisfAylar[1];

                    südüsAy = südüsAylar[a - 6];

                }
                tarihA = " من السدس [" + südüsAy + "] من النصف [" + nisfAy + "]";


                #endregion


                #region GunYazi

                int gun = Convert.ToInt32(txtGun.Text);

                string[] usrGunlar = { "الأول", "الثاني", "الثالث", "الرابع", "الخامس", "السادس",
                                        "السابع", "الثامن", "التاسع", "العاشر" };


                string usrGun = "";
                string sulusGun = "";

                if (gun < 11)
                {
                    sulusGun = usrGunlar[0];
                    usrGun = usrGunlar[gun - 1];
                }
                else if (gun > 10 && gun < 20)
                {
                    sulusGun = usrGunlar[1];
                    usrGun = usrGunlar[gun - 11];
                }

                else
                {
                    sulusGun = usrGunlar[2];
                    usrGun = usrGunlar[gun - 21];
                }

                tarihG = " مِن العُشر [" + usrGun + "] مِن الثُلث [" + sulusGun + "]";

                #endregion


                tarihSonuc = tarihG + " \n \n " + tarihA + " \n \n " + tarihY;
                lblTarih.Text = tarihSonuc;
            }
            else
            {
                MessageBox.Show("Bütün alanları doldurmanız gerekmektedir!!");
            }

        }



        private void txtTarih_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }



        private void txtAy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtYil_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            if (txtYil.TextLength > 3 && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtGun_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (txtGun.TextLength > 1 && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void btn1_Click_1(object sender, EventArgs e)
        {
            int x = 0;
            int y = 0;
            int z = 0;
            int yil = 0;

            #region Yil
            if (cmbTaban.SelectedIndex==0)
            {
                try
                {

                    int text1 = cmb1.SelectedIndex;
                    int text2 = cmb2.SelectedIndex;
                    int text3 = cmb3.SelectedIndex;


                    for (int i = 0; i < 10; i++)
                    {
                        if (text1 == i)
                        {
                            x = i + 1;
                            break;
                        }
                    }
                    for (int i = 0; i < 10; i++)
                    {
                        if (text2 == i)
                        {
                            y = i + 1;
                            break;
                        }
                    }
                    for (int i = 0; i < 10; i++)
                    {
                        if (text3 == i)
                        {
                            z = i + 1;
                            break;
                        }
                    }

                    yil = YilMethods.YilBul(x, y, z);
                    if (yil < 0)
                    {
                        lblSonucSene.Text = "Hatalı Giriş";
                    }
                    else
                    {
                        lblSonucSene.Text = yil.ToString();
                    }
                }
                catch (Exception hata)
                {
                    lblSonucSene.Text = hata.ToString();
                }
            }
            else if (cmbTaban.SelectedIndex==1)
            {
                try
                {

                    int text1 = cmb1.SelectedIndex;
                    int text2 = cmb2.SelectedIndex;
                    int text3 = cmb3.SelectedIndex;


                    for (int i = 0; i < 10; i++)
                    {
                        if (text1 == i)
                        {
                            x = i + 1;
                            break;
                        }
                    }
                    for (int i = 0; i < 10; i++)
                    {
                        if (text2 == i)
                        {
                            y = i + 1;
                            break;
                        }
                    }
                    for (int i = 0; i < 10; i++)
                    {
                        if (text3 == i)
                        {
                            z = i + 1;
                            break;
                        }
                    }

                    yil = YilMethods.YilBul40(x, y, z);
                    if (yil < 0)
                    {
                        lblSonucSene.Text = "Hatalı Giriş";
                    }
                    else
                    {
                        lblSonucSene.Text = yil.ToString();
                    }
                }
                catch (Exception hata)
                {
                    lblSonucSene.Text = hata.ToString();
                }
            }


            #endregion

            #region Ay
            string[] aylar1 = { "Muharrem", "Safer", "Rebiülevvel", "Rebiülâhir", "Cemâziyelevvel", "Cemâziyelâhir" };
            string[] aylar2 = { "Receb", "Şâban", "Ramazan", "Şevval", "Zilkade", "Zilhicce" };
            string ay = "";


            int a = cmb4.SelectedIndex;


            int b = cmb5.SelectedIndex;

            if (b == 0 && a > -1)
            {
                ay = aylar1[a];
            }
            else if (b == 1 && a > -1)
            {
                ay = aylar2[a];
            }


            lblSonucAy.Text = ay;

            #endregion

            #region Gün
            int gun = 0;
            int[] gunler1 = new int[10];
            int[] gunler2 = new int[10];
            int[] gunler3 = new int[10];

            for (int i = 0; i < 10; i++)
            {
                gunler1[i] = i + 1;
            }
            for (int i = 0; i < 10; i++)
            {
                gunler2[i] = i + 11;
            }
            for (int i = 0; i < 10; i++)
            {
                gunler3[i] = i + 21;
            }



            int A = cmb6.SelectedIndex;


            int B = cmb7.SelectedIndex;

            if (B == 0 && A > -1)
            {
                gun = gunler1[A];
            }
            else if (B == 1 && A > -1)
            {
                gun = gunler2[A];
            }
            else if (B == 2 && A > -1)
            {
                gun = gunler3[A];
            }

            lblSonucGun.Text = gun.ToString();

            #endregion

            #region Haftanın Günü
            string[] gunler = { "Pazar", "Pazartesi", "Salı", "Çarşamba", "Perşembe", "Cuma","Cumartesi" };
            string gunHft = "";
            int secim = cmbHaftaGunu.SelectedIndex;
           
            if (secim==-1)
            {
                labelSonucHaftaGunu.Text = "";
            }
            else
            {
                gunHft = gunler[secim];
                labelSonucHaftaGunu.Text = gunHft;
            }            

            #endregion
            labelSonucHaftaGunu.Font = new Font("Tahoma", 14F);
            lblSonucGun.Font = new Font("Tahoma", 14F);
            lblSonucAy.Font = new Font("Tahoma", 14F);
            lblSonucSene.Font = new Font("Tahoma", 14F);

            labelSonucHaftaGunu.ForeColor = Color.Blue;
            lblSonucGun.ForeColor = Color.Blue;
            lblSonucAy.ForeColor = Color.Blue;
            lblSonucSene.ForeColor = Color.Blue;
        }

        private void cmbAy_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbAy.ForeColor = Color.Black;
        }

        private void txtGun_TextChanged(object sender, EventArgs e)
        {
            if (txtGun.Text.Length > 1 && Char.IsDigit(txtGun.Text.ToCharArray().LastOrDefault()))
            {
                if (Convert.ToInt32(txtGun.Text) > 30)
                {
                    MessageBox.Show("Gün 30'dan büyük olamaz");
                    txtGun.Text = "";
                }
            }

        }


        public int tarihEbced = 0;
        public char[] harfler = {'ا','ب','ج','د','ه','و','ز','ح','ط', 'ي', 'ك', 'ل', 'م', 'ن',
            'س', 'ع', 'ف', 'ص', 'ق', 'ر', 'ش', 'ت', 'ث', 'خ', 'ذ', 'ض', 'ظ', 'غ' };
        public int[] ebcedDegerleri = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 20, 30, 40, 50, 60, 70, 80, 90, 100, 200, 300, 400, 500, 600, 700, 800, 900, 1000 };



        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

            tarihEbced = 0;
            char[] chars = richTextBox1.Text.ToCharArray();
            if (chars.Length > 0)
            {
                foreach (var krk in chars)
                {
                    if (EbcedMethods.IsArabicLetter(krk))
                    {
                        tarihEbced = tarihEbced + EbcedMethods.DegeriBul(krk);
                    }
                }
            }


            lblSonuc.Text = tarihEbced.ToString();

        }

        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar.ToString() == "ة")
            {

                MessageBox.Show("ة  harfi yerine ت harfini kullanabilirsiniz");
            }
            if (!EbcedMethods.IsArabicLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            if (Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = false;
            }
        }

        private void hicriGun_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (hicriGun.Text.Length > 0 && Convert.ToInt32(hicriGun.Text) > 30)
                {
                    MessageBox.Show("Gün 30'dan büyük olamaz");
                    hicriGun.Text = "1";
                }

                if (hicriGun.Text.Length > 0 && hicriYil.Text.Length > 0 && hicriAy.SelectedIndex > -1)
                {

                    char[] charsGun = hicriGun.Text.ToCharArray();
                    char[] charsYil = hicriYil.Text.ToCharArray();

                    foreach (var krk in charsGun)
                    {
                        if (Char.IsDigit(krk))
                        {
                            foreach (var krk2 in charsYil)
                            {
                                if (Char.IsDigit(krk2))
                                {

                                    string[] mAylar = { "Ocak", "Şubat","Mart","Nisan","Mayıs","Haziran","Temmuz",
                "Ağustos","Eylül","Ekim","Kasım","Aralık"};

                                    string mAy = "";
                                    MiladiTarih miladiTarih = new MiladiTarih();
                                    HicriTarih hicriTarih = new HicriTarih();
                                    string miladiT = "";

                                    hicriTarih.Day = Convert.ToInt32(hicriGun.Text);
                                    hicriTarih.Month = Convert.ToInt32(hicriAy.SelectedIndex + 1);
                                    hicriTarih.Year = Convert.ToInt32(hicriYil.Text);

                                    miladiTarih = HijriMethods.HicriToMiladi(hicriTarih);
                                    mAy = mAylar[miladiTarih.Month - 1];

                                    miladiT = miladiTarih.Day.ToString() + " " + mAy + " " + miladiTarih.Year.ToString() + " " + miladiTarih.DayOfWeek;
                                    lblMiladi.Text = miladiT;
                                    break;


                                }
                            }
                            break;
                        }
                    }
                }

            }
            catch 
            {

            }

            
        }

        private void hicriAy_SelectedIndexChanged(object sender, EventArgs e)
        {
            hicriAy.ForeColor = Color.Black;

            if (hicriGun.Text.Length > 0 && hicriYil.Text.Length > 0 && hicriAy.SelectedIndex > -1)
            {

                char[] charsGun = hicriGun.Text.ToCharArray();
                char[] charsYil = hicriYil.Text.ToCharArray();

                foreach (var krk in charsGun)
                {
                    if (Char.IsDigit(krk))
                    {
                        foreach (var krk2 in charsYil)
                        {
                            if (Char.IsDigit(krk2))
                            {

                                string[] mAylar = { "Ocak", "Şubat","Mart","Nisan","Mayıs","Haziran","Temmuz",
                "Ağustos","Eylül","Ekim","Kasım","Aralık"};

                                string mAy = "";
                                MiladiTarih miladiTarih = new MiladiTarih();
                                HicriTarih hicriTarih = new HicriTarih();
                                string miladiT = "";

                                hicriTarih.Day = Convert.ToInt32(hicriGun.Text);
                                hicriTarih.Month = Convert.ToInt32(hicriAy.SelectedIndex + 1);
                                hicriTarih.Year = Convert.ToInt32(hicriYil.Text);

                                miladiTarih = HijriMethods.HicriToMiladi(hicriTarih);
                                mAy = mAylar[miladiTarih.Month - 1];

                                miladiT = miladiTarih.Day.ToString() + " " + mAy + " " + miladiTarih.Year.ToString() + " " + miladiTarih.DayOfWeek;
                                lblMiladi.Text = miladiT;
                                break;
                            }
                        }
                        break;
                    }
                }
            }
        }

        private void hicriYil_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (hicriYil.Text.Length > 0 && Convert.ToInt32(hicriYil.Text) > 100000)
                {
                    MessageBox.Show("100000'den büyük yıllar hesaplanmamıştır.");
                    hicriYil.Text = "1";
                }
                if (hicriGun.Text.Length > 0 && hicriYil.Text.Length > 0 && hicriAy.SelectedIndex > -1)
                {

                    char[] charsGun = hicriGun.Text.ToCharArray();
                    char[] charsYil = hicriYil.Text.ToCharArray();

                    foreach (var krk in charsGun)
                    {
                        if (Char.IsDigit(krk))
                        {
                            foreach (var krk2 in charsYil)
                            {
                                if (Char.IsDigit(krk2))
                                {

                                    string[] mAylar = { "Ocak", "Şubat","Mart","Nisan","Mayıs","Haziran","Temmuz",
                "Ağustos","Eylül","Ekim","Kasım","Aralık"};

                                    string mAy = "";
                                    MiladiTarih miladiTarih = new MiladiTarih();
                                    HicriTarih hicriTarih = new HicriTarih();
                                    string miladiT = "";

                                    hicriTarih.Day = Convert.ToInt32(hicriGun.Text);
                                    hicriTarih.Month = Convert.ToInt32(hicriAy.SelectedIndex + 1);
                                    hicriTarih.Year = Convert.ToInt32(hicriYil.Text);

                                    miladiTarih = HijriMethods.HicriToMiladi(hicriTarih);
                                    mAy = mAylar[miladiTarih.Month - 1];

                                    miladiT = miladiTarih.Day.ToString() + " " + mAy + " " + miladiTarih.Year.ToString() + " " + miladiTarih.DayOfWeek;
                                    lblMiladi.Text = miladiT;
                                    break;

                                }
                            }
                            break;
                        }
                    }
                }

            }
            catch 
            {

            }

           
        }

        private void miladiYil_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (miladiYil.Text.Length > 0 && Convert.ToInt32(miladiYil.Text) > 2500)
                {
                    MessageBox.Show("2500'den büyük yıllar hesaplanmamıştır.");
                    miladiYil.Text = "1";
                }

                if (miladiGun.Text.Length > 0 && miladiYil.Text.Length > 0 && miladiAy.SelectedIndex > -1)
                {

                    char[] charsGun = miladiGun.Text.ToCharArray();
                    char[] charsYil = miladiYil.Text.ToCharArray();

                    foreach (var krk in charsGun)
                    {
                        if (Char.IsDigit(krk))
                        {
                            foreach (var krk2 in charsYil)
                            {
                                if (Char.IsDigit(krk2))
                                {


                                    string[] hAylar = { "Muharrem", "Safer","Rebiülevvel","Rebiülâhir","Cemâziyelevvel","Cemâziyelâhir",
                "Receb","Şâban","Ramazan","Şevval","Zilkâde","Zilhicce"};

                                    string hAy = "";
                                    MiladiTarih miladiTarih = new MiladiTarih();
                                    HicriTarih hicriTarih = new HicriTarih();
                                    string hicriT = "";

                                    miladiTarih.Day = Convert.ToInt32(miladiGun.Text);
                                    miladiTarih.Month = Convert.ToInt32(miladiAy.SelectedIndex + 1);
                                    miladiTarih.Year = Convert.ToInt32(miladiYil.Text);

                                    hicriTarih = HijriMethods.MiladiToHicri(miladiTarih);
                                    if (hicriTarih.Month == 0)
                                    {
                                        hAy = "";
                                    }
                                    else
                                    {
                                        hAy = hAylar[hicriTarih.Month - 1];
                                    }
                                    hicriT = hicriTarih.Day.ToString() + " " + hAy + " " + hicriTarih.Year.ToString() + " " + hicriTarih.DayOfWeek;
                                    lblHicri.Text = hicriT;
                                    break;

                                }
                            }
                            break;
                        }
                    }
                }

            }
            catch 
            {

            }
          
        }

        private void miladiGun_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (miladiGun.Text.Length > 0 && Convert.ToInt32(miladiGun.Text) > 31)
                {
                    MessageBox.Show("Gün 31'den büyük olamaz");
                    miladiGun.Text = "1";
                }

                if (miladiGun.Text.Length > 0 && miladiYil.Text.Length > 0 && miladiAy.SelectedIndex > -1)
                {

                    char[] charsGun = miladiGun.Text.ToCharArray();
                    char[] charsYil = miladiYil.Text.ToCharArray();

                    foreach (var krk in charsGun)
                    {
                        if (Char.IsDigit(krk))
                        {
                            foreach (var krk2 in charsYil)
                            {
                                if (Char.IsDigit(krk2))
                                {

                                    string[] hAylar = { "Muharrem", "Safer","Rebiülevvel","Rebiülâhir","Cemâziyelevvel","Cemâziyelâhir",
                "Receb","Şâban","Ramazan","Şevval","Zilkâde","Zilhicce"};

                                    string hAy = "";
                                    MiladiTarih miladiTarih = new MiladiTarih();
                                    HicriTarih hicriTarih = new HicriTarih();
                                    string hicriT = "";

                                    miladiTarih.Day = Convert.ToInt32(miladiGun.Text);
                                    miladiTarih.Month = Convert.ToInt32(miladiAy.SelectedIndex + 1);
                                    miladiTarih.Year = Convert.ToInt32(miladiYil.Text);

                                    hicriTarih = HijriMethods.MiladiToHicri(miladiTarih);
                                    if (hicriTarih.Month == 0)
                                    {
                                        hAy = "";
                                    }
                                    else
                                    {
                                        hAy = hAylar[hicriTarih.Month - 1];
                                    }
                                    hicriT = hicriTarih.Day.ToString() + " " + hAy + " " + hicriTarih.Year.ToString() + " " + hicriTarih.DayOfWeek;
                                    lblHicri.Text = hicriT;
                                    break;


                                }
                            }
                            break;
                        }
                    }
                }

            }
            catch 
            {

            }
          
        }

        private void miladiAy_SelectedIndexChanged(object sender, EventArgs e)
        {
            miladiAy.ForeColor = Color.Black;

            if (miladiGun.Text.Length > 0 && miladiYil.Text.Length > 0 && miladiAy.SelectedIndex > -1)
            {

                char[] charsGun = miladiGun.Text.ToCharArray();
                char[] charsYil = miladiYil.Text.ToCharArray();

                foreach (var krk in charsGun)
                {
                    if (Char.IsDigit(krk))
                    {
                        foreach (var krk2 in charsYil)
                        {
                            if (Char.IsDigit(krk2))
                            {

                                string[] hAylar = { "Muharrem", "Safer","Rebiülevvel","Rebiülâhir","Cemâziyelevvel","Cemâziyelâhir",
                "Receb","Şâban","Ramazan","Şevval","Zilkâde","Zilhicce"};

                                string hAy = "";
                                MiladiTarih miladiTarih = new MiladiTarih();
                                HicriTarih hicriTarih = new HicriTarih();
                                string hicriT = "";

                                miladiTarih.Day = Convert.ToInt32(miladiGun.Text);
                                miladiTarih.Month = Convert.ToInt32(miladiAy.SelectedIndex + 1);
                                miladiTarih.Year = Convert.ToInt32(miladiYil.Text);

                                hicriTarih = HijriMethods.MiladiToHicri(miladiTarih);
                                if (hicriTarih.Month == 0)
                                {
                                    hAy = "";
                                }
                                else
                                {
                                    hAy = hAylar[hicriTarih.Month - 1];
                                }
                                hicriT = hicriTarih.Day.ToString() + " " + hAy + " " + hicriTarih.Year.ToString() + " " + hicriTarih.DayOfWeek;
                                lblHicri.Text = hicriT;
                                break;


                            }
                        }
                        break;
                    }
                }
            }

        }

        private void hicriGun_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            if (hicriGun.TextLength > 1 && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void hicriYil_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            if (hicriYil.TextLength > 5 && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void miladiGun_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            if (miladiGun.TextLength > 1 && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void miladiYil_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            if (miladiYil.TextLength > 3 && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }
    }
}
