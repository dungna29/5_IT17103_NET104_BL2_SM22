using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bai_8_View.DomainClass
{
    public partial class NhanVien
    {
        public NhanVien()
        {
            HoaDon = new HashSet<HoaDon>();
            InverseIdGuiBcNavigation = new HashSet<NhanVien>();
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
        [StringLength(10)]
        public string GioiTinh { get; set; }
        [Column(TypeName = "date")]
        public DateTime? NgaySinh { get; set; }
        [StringLength(100)]
        public string DiaChi { get; set; }
        [StringLength(30)]
        public string Sdt { get; set; }
        public string MatKhau { get; set; }
        [Column("IdCH")]
        public Guid? IdCh { get; set; }
        [Column("IdCV")]
        public Guid? IdCv { get; set; }
        [Column("IdGuiBC")]
        public Guid? IdGuiBc { get; set; }
        public int? TrangThai { get; set; }

        [ForeignKey(nameof(IdCh))]
        [InverseProperty(nameof(CuaHang.NhanVien))]
        public virtual CuaHang IdChNavigation { get; set; }
        [ForeignKey(nameof(IdCv))]
        [InverseProperty(nameof(ChucVu.NhanVien))]
        public virtual ChucVu IdCvNavigation { get; set; }
        [ForeignKey(nameof(IdGuiBc))]
        [InverseProperty(nameof(NhanVien.InverseIdGuiBcNavigation))]
        public virtual NhanVien IdGuiBcNavigation { get; set; }
        [InverseProperty("IdNvNavigation")]
        public virtual ICollection<HoaDon> HoaDon { get; set; }
        [InverseProperty(nameof(NhanVien.IdGuiBcNavigation))]
        public virtual ICollection<NhanVien> InverseIdGuiBcNavigation { get; set; }
    }
}
