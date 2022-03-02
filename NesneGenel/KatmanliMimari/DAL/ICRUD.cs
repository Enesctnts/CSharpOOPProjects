using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface ICRUD<T>
    {
        List<T> Liste();
        void Ekle(T entity);
    }
}
