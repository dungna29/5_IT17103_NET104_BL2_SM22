using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Bai_8_View.DomainClass;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bai_8_View.Context
{
    public partial class FpolyDBContext : DbContext
    {
        public FpolyDBContext()
        {
        }

        public FpolyDBContext(DbContextOptions<FpolyDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ChiTietSp> ChiTietSp { get; set; }
        public virtual DbSet<ChucVu> ChucVu { get; set; }
        public virtual DbSet<CuaHang> CuaHang { get; set; }
        public virtual DbSet<DongSp> DongSp { get; set; }
        public virtual DbSet<GioHang> GioHang { get; set; }
        public virtual DbSet<GioHangChiTiet> GioHangChiTiet { get; set; }
        public virtual DbSet<HoaDon> HoaDon { get; set; }
        public virtual DbSet<HoaDonChiTiet> HoaDonChiTiet { get; set; }
        public virtual DbSet<KhachHang> KhachHang { get; set; }
        public virtual DbSet<MauSac> MauSac { get; set; }
        public virtual DbSet<NhanVien> NhanVien { get; set; }
        public virtual DbSet<Nsx> Nsx { get; set; }
        public virtual DbSet<SanPham> SanPham { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=DUNGNAPC\\SQLEXPRESS;Initial Catalog=FINALASS_FPOLYSHOP_SM22_BL2_DUNGNA29;Persist Security Info=True;User ID=dungna34;Password=123456");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChiTietSp>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.GiaBan).HasDefaultValueSql("((0))");

                entity.Property(e => e.GiaNhap).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.IdDongSpNavigation)
                    .WithMany(p => p.ChiTietSp)
                    .HasForeignKey(d => d.IdDongSp)
                    .HasConstraintName("FK__ChiTietSP__IdDon__17036CC0");

                entity.HasOne(d => d.IdMauSacNavigation)
                    .WithMany(p => p.ChiTietSp)
                    .HasForeignKey(d => d.IdMauSac)
                    .HasConstraintName("FK__ChiTietSP__IdMau__160F4887");

                entity.HasOne(d => d.IdNsxNavigation)
                    .WithMany(p => p.ChiTietSp)
                    .HasForeignKey(d => d.IdNsx)
                    .HasConstraintName("FK__ChiTietSP__IdNsx__151B244E");

                entity.HasOne(d => d.IdSpNavigation)
                    .WithMany(p => p.ChiTietSp)
                    .HasForeignKey(d => d.IdSp)
                    .HasConstraintName("FK__ChiTietSP__IdSP__14270015");
            });

            modelBuilder.Entity<ChucVu>(entity =>
            {
                entity.HasIndex(e => e.Ma)
                    .HasName("UQ__ChucVu__3214CC9E0C3AE58D")
                    .IsUnique();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Ma).IsUnicode(false);
            });

            modelBuilder.Entity<CuaHang>(entity =>
            {
                entity.HasIndex(e => e.Ma)
                    .HasName("UQ__CuaHang__3214CC9EC6EE66B4")
                    .IsUnique();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Ma).IsUnicode(false);
            });

            modelBuilder.Entity<DongSp>(entity =>
            {
                entity.HasIndex(e => e.Ma)
                    .HasName("UQ__DongSP__3214CC9EFED1AA9A")
                    .IsUnique();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Ma).IsUnicode(false);
            });

            modelBuilder.Entity<GioHang>(entity =>
            {
                entity.HasIndex(e => e.Ma)
                    .HasName("UQ__GioHang__3214CC9E18998A02")
                    .IsUnique();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Ma).IsUnicode(false);

                entity.Property(e => e.Sdt).IsUnicode(false);

                entity.Property(e => e.TinhTrang).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.IdKhNavigation)
                    .WithMany(p => p.GioHang)
                    .HasForeignKey(d => d.IdKh)
                    .HasConstraintName("FK__GioHang__IdKH__123EB7A3");
            });

            modelBuilder.Entity<GioHangChiTiet>(entity =>
            {
                entity.HasKey(e => new { e.IdGioHang, e.IdChiTietSp })
                    .HasName("PK_GioHangCT");

                entity.Property(e => e.DonGia).HasDefaultValueSql("((0))");

                entity.Property(e => e.DonGiaKhiGiam).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.IdChiTietSpNavigation)
                    .WithMany(p => p.GioHangChiTiet)
                    .HasForeignKey(d => d.IdChiTietSp)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK2_IdChiTietSP");

                entity.HasOne(d => d.IdGioHangNavigation)
                    .WithMany(p => p.GioHangChiTiet)
                    .HasForeignKey(d => d.IdGioHang)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK1_IdGioHang");
            });

            modelBuilder.Entity<HoaDon>(entity =>
            {
                entity.HasIndex(e => e.Ma)
                    .HasName("UQ__HoaDon__3214CC9E6E4EEA67")
                    .IsUnique();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Ma).IsUnicode(false);

                entity.Property(e => e.Sdt).IsUnicode(false);

                entity.Property(e => e.TinhTrang).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.IdKhNavigation)
                    .WithMany(p => p.HoaDon)
                    .HasForeignKey(d => d.IdKh)
                    .HasConstraintName("FK__HoaDon__IdKH__114A936A");

                entity.HasOne(d => d.IdNvNavigation)
                    .WithMany(p => p.HoaDon)
                    .HasForeignKey(d => d.IdNv)
                    .HasConstraintName("FK__HoaDon__IdNV__1332DBDC");
            });

            modelBuilder.Entity<HoaDonChiTiet>(entity =>
            {
                entity.HasKey(e => new { e.IdHoaDon, e.IdChiTietSp })
                    .HasName("PK_HoaDonCT");

                entity.Property(e => e.DonGia).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.IdChiTietSpNavigation)
                    .WithMany(p => p.HoaDonChiTiet)
                    .HasForeignKey(d => d.IdChiTietSp)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK2");

                entity.HasOne(d => d.IdHoaDonNavigation)
                    .WithMany(p => p.HoaDonChiTiet)
                    .HasForeignKey(d => d.IdHoaDon)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK1");
            });

            modelBuilder.Entity<KhachHang>(entity =>
            {
                entity.HasIndex(e => e.Ma)
                    .HasName("UQ__KhachHan__3214CC9E5C217F5F")
                    .IsUnique();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Ma).IsUnicode(false);

                entity.Property(e => e.MatKhau).IsUnicode(false);

                entity.Property(e => e.Sdt).IsUnicode(false);
            });

            modelBuilder.Entity<MauSac>(entity =>
            {
                entity.HasIndex(e => e.Ma)
                    .HasName("UQ__MauSac__3214CC9E768FCFE7")
                    .IsUnique();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Ma).IsUnicode(false);
            });

            modelBuilder.Entity<NhanVien>(entity =>
            {
                entity.HasIndex(e => e.Ma)
                    .HasName("UQ__NhanVien__3214CC9E68F1B1CF")
                    .IsUnique();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Ma).IsUnicode(false);

                entity.Property(e => e.MatKhau).IsUnicode(false);

                entity.Property(e => e.Sdt).IsUnicode(false);

                entity.Property(e => e.TrangThai).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.IdChNavigation)
                    .WithMany(p => p.NhanVien)
                    .HasForeignKey(d => d.IdCh)
                    .HasConstraintName("FK__NhanVien__IdCH__0E6E26BF");

                entity.HasOne(d => d.IdCvNavigation)
                    .WithMany(p => p.NhanVien)
                    .HasForeignKey(d => d.IdCv)
                    .HasConstraintName("FK__NhanVien__IdCV__0F624AF8");

                entity.HasOne(d => d.IdGuiBcNavigation)
                    .WithMany(p => p.InverseIdGuiBcNavigation)
                    .HasForeignKey(d => d.IdGuiBc)
                    .HasConstraintName("FK__NhanVien__IdGuiB__10566F31");
            });

            modelBuilder.Entity<Nsx>(entity =>
            {
                entity.HasIndex(e => e.Ma)
                    .HasName("UQ__NSX__3214CC9E503318E9")
                    .IsUnique();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Ma).IsUnicode(false);
            });

            modelBuilder.Entity<SanPham>(entity =>
            {
                entity.HasIndex(e => e.Ma)
                    .HasName("UQ__SanPham__3214CC9E9F61B79B")
                    .IsUnique();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Ma).IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
