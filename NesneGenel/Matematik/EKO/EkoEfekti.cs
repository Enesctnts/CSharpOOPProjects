using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using SDK;
namespace EKO
{
    public class EkoEfekti : ISDK
    {
        public string EklentiAdi { get => "Eko Efekti..."; }

        public string Islem(string str)
        {
            string strYeni = "";

            for (int i = 0; i < 3; i++)
            {
                strYeni += str + " ";
            }

            return strYeni;
        }
    }
}
