using System;
using EFCORE_DBFIRST_LIBRARY.DomainClass;
using EFCORE_DBFIRST_LIBRARY.Repositories;

namespace EF_CACH_GOI_TANG_DAL
{
    internal class Program
    {
        private static IChucVuRepository _iChucVuRepository;

        //Add Ref với  EFCORE_DBFIRST_LIBRARY
        private static void Main(string[] args)
        {
            _iChucVuRepository = new ChucVuRepository();
            _iChucVuRepository.Add(new ChucVu() { Id = Guid.Empty, Ma = "Dungna", Ten = "C#" });
            foreach (var x in _iChucVuRepository.GetAll())
            {
                Console.WriteLine(x.Ten + " " + x.Ma);
            }
        }
    }
}