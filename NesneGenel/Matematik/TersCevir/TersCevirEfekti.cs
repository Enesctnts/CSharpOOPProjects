using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SDK;
namespace TersCevir
{
    public class TersCevirEfekti : ISDK
    {
        public string EklentiAdi => "Ters Cevirme Efekti...";

        public string Islem(string str)
        {
            string strYeni = "";
            for (int i = str.Length-1; i>=0; i--)
            {
                strYeni += str[i];
            }
            return strYeni;
        }
    }
}
