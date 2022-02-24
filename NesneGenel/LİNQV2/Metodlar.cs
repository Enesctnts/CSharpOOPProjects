using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LİNQV2
{
    static class Metodlar
    {
        public static int KareAl(this int sayi)
        {
            return sayi * sayi;
        }

        public static int KupAl(this int sayi)
        {
            return sayi * sayi*sayi;
        }
        public static int IkiyeBol(this int sayi)
        {
            return sayi / 2;
        }

        public static string TersCevir(this string str)
        {
            string strYeni = "";
            for (int i = (str.Length-1); i >= 0; i--)
            {
                strYeni += str[i];
            }
            return strYeni;
        }

        public static string Eko(this string str,int defa)
        {
            string strYeni = "";
            for (int i = 0; i < defa; i++)
            {
                strYeni += str + " ";

            }
            return strYeni;
        }

    }
}
