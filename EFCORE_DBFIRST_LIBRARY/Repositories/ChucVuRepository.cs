using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EFCORE_DBFIRST_LIBRARY.Context;
using EFCORE_DBFIRST_LIBRARY.DomainClass;

namespace EFCORE_DBFIRST_LIBRARY.Repositories
{
    public class ChucVuRepository : IChucVuRepository
    {
        private FpolyDBContext _fpolyDbContext;

        public ChucVuRepository()
        {
            _fpolyDbContext = new FpolyDBContext();
        }

        public bool Add(ChucVu obj)
        {
            //Phải check null tham số
            if (obj == null) return false;
            _fpolyDbContext.ChucVus.Add(obj);
            _fpolyDbContext.SaveChanges();
            return true;
        }

        public bool Update(ChucVu obj)
        {
            if (obj == null) return false;
            _fpolyDbContext.ChucVus.Update(obj);
            _fpolyDbContext.SaveChanges();
            return true;
        }

        public bool Delete(ChucVu obj)
        {
            if (obj == null) return false;
            _fpolyDbContext.ChucVus.Remove(obj);
            _fpolyDbContext.SaveChanges();
            return true;
        }

        public List<ChucVu> GetAll()
        {
            return _fpolyDbContext.ChucVus.ToList();
        }
    }
}