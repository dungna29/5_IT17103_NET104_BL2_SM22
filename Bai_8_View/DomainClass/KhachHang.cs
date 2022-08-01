using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bai_8_View.DomainClass
{
    public partial class KhachHang
    {
        public KhachHang()
        {
            GioHang = new HashSet<GioHang>();
            HoaDon = new HashSet<HoaDon>();
        }

        [Key]
        public Guid Id { get; set; }
        [StringLength(20)]
        public string Ma { get; set; }
        [StringLength(30)]
        public string Ten { get; set; }
        [StringLength(30)]
        public string TenDem { get; set; }
        [StringLength(30)]
        public string Ho { get; set; }
        [Column(TypeName = "date")]
        public DateTime? NgaySinh { get; set; }
        [StringLength(30)]
        public string Sdt { get; set; }
        [StringLength(100)]
        public string DiaChi { get; set; }
        [StringLength(50)]
        public string ThanhPho { get; set; }
        [StringLength(50)]
        public string QuocGia { get; set; }
        public string MatKhau { get; set; }

        [InverseProperty("IdKhNavigation")]
        public virtual ICollection<GioHang> GioHang { get; set; }
        [InverseProperty("IdKhNavigation")]
        public virtual ICollection<HoaDon> HoaDon { get; set; }
    }
}
