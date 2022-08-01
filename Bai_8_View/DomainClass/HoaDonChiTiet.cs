using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bai_8_View.DomainClass
{
    public partial class HoaDonChiTiet
    {
        [Key]
        public Guid IdHoaDon { get; set; }
        [Key]
        [Column("IdChiTietSP")]
        public Guid IdChiTietSp { get; set; }
        public int? SoLuong { get; set; }
        [Column(TypeName = "decimal(20, 0)")]
        public decimal? DonGia { get; set; }

        [ForeignKey(nameof(IdChiTietSp))]
        [InverseProperty(nameof(ChiTietSp.HoaDonChiTiet))]
        public virtual ChiTietSp IdChiTietSpNavigation { get; set; }
        [ForeignKey(nameof(IdHoaDon))]
        [InverseProperty(nameof(HoaDon.HoaDonChiTiet))]
        public virtual HoaDon IdHoaDonNavigation { get; set; }
    }
}
