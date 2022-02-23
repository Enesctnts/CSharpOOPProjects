using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventOrnekV2
{
    public class Depo : IEnumerable
    {
        List<Urun> _depo;
        public Depo(int kapasite)
        {
            _depo = new List<Urun>(kapasite);
        }
        public event EventHandler DepoBos;
        public event EventHandler DepoDolu;
        
        public void Ekle(Urun urun)
        {

            if (_depo.Count < _depo.Capacity)
            {
                _depo.Add(urun);
            }

            else if (DepoDolu != null)
            {
                DepoDolu(this, new EventArgs());
            }
        }

        public void Cıkar(Urun urun)
        {
            
            if (_depo.Count > 0)
            {
                _depo.Remove(urun);
            }

            else if (DepoBos != null)
            {
                DepoBos(this, new EventArgs());
            }
        }

        public IEnumerator GetEnumerator()
        {

            return _depo.GetEnumerator();

        }
    }
}
