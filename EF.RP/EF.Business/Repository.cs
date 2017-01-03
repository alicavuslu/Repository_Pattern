using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Data.Objects;
using EF.Data;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Entity.Core.Objects;
//using System.Data.Linq;

namespace EF.Bussines
{
    public class Repository<T> where T : class
    {
        ObjectContext _context;
        IObjectSet<T> _objectSet;

        //Context Oluşturuyoruz

        //DenemeEntities db = new DenemeEntities();

        public Repository()
        {
            // ObjectContext nesnesi oluşturyoruz.

            //_context = (ObjectContext)db;
            _objectSet = _context.CreateObjectSet<T>();
        }

        // Entity Göre listeleme yapan generic metodumuz
        public List<T> Listele()
        {
            List<T> liste = _objectSet.ToList();
            return liste;
        }

        // Lambda syntax kullnarak sorgularımızı yaptığımız metot
        public List<T> SorguyaGoreListele(Expression<Func<T, bool>> where)
        {
            return _objectSet.Where(where).ToList();
        }

    }
}