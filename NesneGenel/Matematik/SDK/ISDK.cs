using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK
{
    public interface ISDK
    {
        string EklentiAdi { get; }
        string Islem(string str);
    }
}
