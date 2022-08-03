using EFCORE_DBFIRST_LIBRARY.DomainClass;
using EFCORE_DBFIRST_LIBRARY.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace Bai_9_CachTaoView.Services
{
    public class QLChucVuService : IQLChucVuService
    {
        //Đây là ví dụ thì chỉ có 4 chức năng, nhưng trong bài toán thật sẽ có thể có các chứng năng, tìm kiếm chức vụ, lọc chức vụ...., Tại đây sẽ gọi đến rất nhiều repo khác nhau để phục vụ bài toán.
        private IChucVuRepository _iChucVuRepository;

        public QLChucVuService()
        {
            _iChucVuRepository = new ChucVuRepository();
        }

        public bool Create(ChucVu cv)
        {
            if (cv == null) return false;
            if (_iChucVuRepository.Add(cv))
            {
                return true;
            }
            return false;
        }

        public bool Delete(ChucVu cv)
        {
            if (cv == null) return false;
            var temp = _iChucVuRepository.GetAll().FirstOrDefault(c => c.Id == cv.Id);
            temp.Ten = cv.Ten;
            temp.Ma = cv.Ma;
            if (_iChucVuRepository.Delete(temp))
            {
                return true;
            }
            return false;
        }

        public List<ChucVu> GetAll()
        {
            return _iChucVuRepository.GetAll();
        }

        public bool Update(ChucVu cv)
        {
            if (cv == null) return false;
            var temp = _iChucVuRepository.GetAll().FirstOrDefault(c => c.Id == cv.Id);
            temp.Ten = cv.Ten;
            temp.Ma = cv.Ma;
            if (_iChucVuRepository.Update(temp))
            {
                return true;
            }
            return false;
        }
    }
}