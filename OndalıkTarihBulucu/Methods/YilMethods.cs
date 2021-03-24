using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OndalıkTarihBulucu
{
    public static class YilMethods
    {
        public static int YilBul(int a, int b, int c)
        {
            int sonuc = 100 * (c - 1) +
                10 * (b - 1) +
                a;

            return sonuc;
        }


        //Bir asrın 40 sene alındığı tarihler için
        public static int YilBul40(int a, int b, int c)
        {
            int sonuc = 40 * (c - 1) +
                10 * (b - 1) +
                a;

            return sonuc;
        }
    }
}
