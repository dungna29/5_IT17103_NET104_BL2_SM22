using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bai_8_View.DomainClass
{
    public partial class GioHang
    {
        public GioHang()
        {
            GioHangChiTiet = new HashSet<GioHangChiTiet>();
        }

        [Key]
        public Guid Id { get; set; }
        [Column("IdKH")]
        public Guid? IdKh { get; set; }
        [Column("IdNV")]
        public Guid? IdNv { get; set; }
        [StringLength(20)]
        public string Ma { get; set; }
        [Column(TypeName = "date")]
        public DateTime? NgayTao { get; set; }
        [Column(TypeName = "date")]
        public DateTime? NgayThanhToan { get; set; }
        [StringLength(50)]
        public string TenNguoiNhan { get; set; }
        [StringLength(100)]
        public string DiaChi { get; set; }
        [StringLength(30)]
        public string Sdt { get; set; }
        public int? TinhTrang { get; set; }

        [ForeignKey(nameof(IdKh))]
        [InverseProperty(nameof(KhachHang.GioHang))]
        public virtual KhachHang IdKhNavigation { get; set; }
        [InverseProperty("IdGioHangNavigation")]
        public virtual ICollection<GioHangChiTiet> GioHangChiTiet { get; set; }
    }
}
