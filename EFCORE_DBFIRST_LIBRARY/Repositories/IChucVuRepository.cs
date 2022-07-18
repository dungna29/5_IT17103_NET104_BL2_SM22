using System;
using System.Collections.Generic;
using System.Text;
using EFCORE_DBFIRST_LIBRARY.DomainClass;

namespace EFCORE_DBFIRST_LIBRARY.Repositories
{
    public interface IChucVuRepository
    {
        //Không sử dụng private
        //Phương thức không có thân code
        //Để mặc là public

        /// <summary>
        /// Thêm đối tượng vào SQL
        /// </summary>
        /// <param name="obj">Đối tượng Chức vụ</param>
        /// <returns></returns>
        bool Add(ChucVu obj);

        bool Update(ChucVu obj);

        bool Delete(ChucVu obj);

        List<ChucVu> GetAll();
    }
}