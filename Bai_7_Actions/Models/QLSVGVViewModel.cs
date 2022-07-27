using System.Collections.Generic;
using Bai_7_Actions.DomainClass;

namespace Bai_7_Actions.Models
{
    public class QLSVGVViewModel
    {
        public IEnumerable<GiangVien> GiangViens { get; set; }
        public IEnumerable<SinhVien> SinhViens { get; set; }
    }
}