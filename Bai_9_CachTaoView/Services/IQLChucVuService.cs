using EFCORE_DBFIRST_LIBRARY.DomainClass;
using System.Collections.Generic;

namespace Bai_9_CachTaoView.Services
{
    public interface IQLChucVuService
    {
        //Các chức năng bài toán cần.

        public bool Create(ChucVu cv);

        public bool Update(ChucVu cv);

        public bool Delete(ChucVu cv);

        public List<ChucVu> GetAll();
    }
}