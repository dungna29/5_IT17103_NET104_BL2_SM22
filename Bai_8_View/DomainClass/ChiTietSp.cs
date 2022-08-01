using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bai_8_View.DomainClass
{
    [Table("ChiTietSP")]
    public partial class ChiTietSp
    {
        public ChiTietSp()
        {
            GioHangChiTiet = new HashSet<GioHangChiTiet>();
            HoaDonChiTiet = new HashSet<HoaDonChiTiet>();
        }

        [Key]
        public Guid Id { get; set; }
        [Column("IdSP")]
        public Guid? IdSp { get; set; }
        public Guid? IdNsx { get; set; }
        public Guid? IdMauSac { get; set; }
        [Column("IdDongSP")]
        public Guid? IdDongSp { get; set; }
        [Column("NamBH")]
        public int? NamBh { get; set; }
        [StringLength(50)]
        public string MoTa { get; set; }
        public int? SoLuongTon { get; set; }
        [Column(TypeName = "decimal(20, 0)")]
        public decimal? GiaNhap { get; set; }
        [Column(TypeName = "decimal(20, 0)")]
        public decimal? GiaBan { get; set; }

        [ForeignKey(nameof(IdDongSp))]
        [InverseProperty(nameof(DongSp.ChiTietSp))]
        public virtual DongSp IdDongSpNavigation { get; set; }
        [ForeignKey(nameof(IdMauSac))]
        [InverseProperty(nameof(MauSac.ChiTietSp))]
        public virtual MauSac IdMauSacNavigation { get; set; }
        [ForeignKey(nameof(IdNsx))]
        [InverseProperty(nameof(Nsx.ChiTietSp))]
        public virtual Nsx IdNsxNavigation { get; set; }
        [ForeignKey(nameof(IdSp))]
        [InverseProperty(nameof(SanPham.ChiTietSp))]
        public virtual SanPham IdSpNavigation { get; set; }
        [InverseProperty("IdChiTietSpNavigation")]
        public virtual ICollection<GioHangChiTiet> GioHangChiTiet { get; set; }
        [InverseProperty("IdChiTietSpNavigation")]
        public virtual ICollection<HoaDonChiTiet> HoaDonChiTiet { get; set; }
    }
}
