using BusinessGeneric.DAL;
using BusinessGeneric.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessGeneric.BLL
{
    public class GenericBLL<T> where T:class, IEntity
    {
        //GenericFilmDB bu kısımda Dependency Injection olmalı...
        GenericFilmDB db;
        public GenericBLL(GenericFilmDB genericFilmDB)
        {
            db = genericFilmDB;
        }

        public void Ekle(T entity)
        {
            db.Set<T>().Add(entity);
            db.SaveChanges();
        }

        public List<T> Listele()
        {
            return db.Set<T>().ToList();
        }
    }
}
