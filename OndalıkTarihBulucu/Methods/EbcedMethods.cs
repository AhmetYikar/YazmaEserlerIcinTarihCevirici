using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OndalıkTarihBulucu
{
    public static class EbcedMethods
    {
        public static bool IsArabicLetter(Char krk)
        {
            char[] harfler = {'ا','ب','ج','د','ه','و','ز','ح','ط', 'ي', 'ك', 'ل', 'م', 'ن',
            'س', 'ع', 'ف', 'ص', 'ق', 'ر', 'ش', 'ت', 'ث', 'خ', 'ذ', 'ض', 'ظ', 'غ' };

            foreach (var hrf in harfler)
            {
                if (hrf == krk)
                {
                    return true;
                }
            }

            return false;
        }




        public static int DegeriBul(Char krk)
        {
            int deger = 0;
            char[] harfler = {'ا','ب','ج','د','ه','و','ز','ح','ط', 'ي', 'ك', 'ل', 'م', 'ن',
            'س', 'ع', 'ف', 'ص', 'ق', 'ر', 'ش', 'ت', 'ث', 'خ', 'ذ', 'ض', 'ظ', 'غ' };
            int[] ebcedDegerleri = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 20, 30,
                40, 50, 60, 70, 80, 90, 100, 200, 300, 400, 500, 600, 700, 800, 900, 1000 };

            for (int i = 0; i < harfler.Length; i++)
            {
                if (krk == harfler[i])
                {
                    deger = deger + ebcedDegerleri[i];
                    break;
                }
            }


            return deger;
        }


    }
}
