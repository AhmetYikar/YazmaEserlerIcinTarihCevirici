using OndalıkTarihBulucu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OndalıkTarihBulucu.Methods
{
    public static class HijriMethods
    {

        //Number Approximation
        public static double getInt(double fNumber)
        {
            double intPart;
            if (fNumber < -0.0000001)
            {
                intPart = Math.Ceiling(fNumber - 0.0000001);
            }
            else
            {
                intPart = Math.Floor(fNumber + 0.0000001);
            }
            return intPart;
        }
        public static MiladiTarih HicriToMiladi(HicriTarih hicriTarih)
        {
            //convert Lunar year from 1 to 1900  
            double jd;
            double i, j, k, L, n;
            int d, m, y;
            int theDay;
            string[] daysOfWeek = {"Pazartesi","Salı","Çarşamba","Perşembe","Cuma","Cumartesi","Pazar" };

            string dayOfWeek;
            //Lunar day  
            d = hicriTarih.Day;
           
            //get the number of Lunar month  
            m = hicriTarih.Month;
            //Lunar year  
            y = hicriTarih.Year;
            jd = getInt((11 * y + 3) / 30) + 354 * y + 30 * m - getInt((m - 1) / 2) + d + 1948440 - 385;
    //day of the week  
    theDay = (int)(jd % 7);
            
            dayOfWeek = daysOfWeek[theDay];
            if (jd > 2299160)
            {
                L = jd + 68569;
                n = getInt((4 * L) / 146097);
                L = L - getInt((146097 * n + 3) / 4);
                i = getInt((4000 * (L + 1)) / 1461001);
                L = L - getInt((1461 * i) / 4) + 31;
                j = getInt((80 * L) / 2447);
                d = (int)(L - getInt((2447 * j) / 80));
                L = getInt(j / 11);
                m = (int)(j + 2 - 12 * L);
                y = (int)(100 * (n - 49) + i + L);
            }
            else
            {
                j = jd + 1402;
                k = getInt((j - 1) / 1461);
                L = j - 1461 * k;
                n = getInt((L - 1) / 365) - getInt(L / 1461);
                i = L - 365 * n + 30;
                j = getInt((80 * i) / 2447);
                d = (int)(i - getInt((2447 * j) / 80));
                i = getInt(j / 11);
                m = (int)(j + 2 - 12 * i);
                y = (int)(4 * k + n + i - 4716);
            }
            //return Solar date  
            MiladiTarih miladiTarih = new MiladiTarih();
            miladiTarih.Day = d;
            miladiTarih.Month = m;
            miladiTarih.Year = y;
            miladiTarih.DayOfWeek = dayOfWeek;
            return miladiTarih;            
        }
        public static HicriTarih MiladiToHicri(MiladiTarih miladiTarih)
        {
            //convert Solar year from 622 to 2500  
            HicriTarih hicriTarih = new HicriTarih();
            double jd;
            double j, L, n;
            int d, m, y;
            int theDay;
            string[] daysOfWeek = { "Pazartesi", "Salı", "Çarşamba", "Perşembe", "Cuma", "Cumartesi", "Pazar" };

            string dayOfWeek;
            //Solar day  
            d = miladiTarih.Day;
            //get the number of Solar month  
            m = miladiTarih.Month;
            // Solar year  
            y = miladiTarih.Year;
            if ((y > 1582) || ((y == 1582) && (m > 10)) || ((y == 1582) && (m == 10) && (d > 14)))
            {
                jd = getInt((1461 * (y + 4800 + getInt((m - 14) / 12))) / 4) + getInt((367 * (m - 2 - 12 * (getInt((m - 14) / 12)))) / 12) - getInt((3 * (getInt((y + 4900 + getInt((m - 14) / 12)) / 100))) / 4) + d - 32075;
            }
            else
            {
                jd = 367 * y - getInt((7 * (y + 5001 + getInt((m - 9) / 7))) / 4) + getInt((275 * m) / 9) + d + 1729777;
            }
            //Solar year >= 622  
            if (jd < 1948440)
            {                
                return hicriTarih;
            }
            //Solar year <= 2500  
            if (jd > 2621734)
            {
                return hicriTarih;
            }
            //day of the week  
            theDay = (int)(jd % 7);
            dayOfWeek = daysOfWeek[theDay];
            L = jd - 1948440 + 10632;
            n = getInt((L - 1) / 10631);
            L = L - 10631 * n + 354;
            j = (getInt((10985 - L) / 5316)) * (getInt((50 * L) / 17719)) + (getInt(L / 5670)) * (getInt((43 * L) / 15238));
            L = L - (getInt((30 - j) / 15)) * (getInt((17719 * j) / 50)) - (getInt(j / 16)) * (getInt((15238 * j) / 43)) + 29;
            m = (int)(getInt((24 * L) / 709));
            d = (int)(L - getInt((709 * m) / 24));
            y = (int)(30 * n + j - 30);
            //display Lunar date  

            hicriTarih.Day = d;
            hicriTarih.Month = m;
            hicriTarih.Year = y;
            hicriTarih.DayOfWeek = dayOfWeek;
            return hicriTarih;
        }
    }
}
