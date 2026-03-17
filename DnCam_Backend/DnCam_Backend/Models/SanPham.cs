using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DnCam_Backend.Models;

[Table("SanPham")]
public partial class SanPham
{
    [Key]
    public int MaSanPham { get; set; }

    public int MaDanhMuc { get; set; }

    public int MaThuongHieu { get; set; }

    [StringLength(200)]
    public string TenSanPham { get; set; } = null!;

    public string? MoTa { get; set; }

    public string? MoTaChiTiet { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal GiaBan { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? HinhAnhDaiDien { get; set; }

    public int SoLuongTon { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? NgayTao { get; set; }

    [InverseProperty("MaSanPhamNavigation")]
    public virtual ICollection<ChiTietDonHang> ChiTietDonHangs { get; set; } = new List<ChiTietDonHang>();

    [ForeignKey("MaDanhMuc")]
    [InverseProperty("SanPhams")]
    public virtual DanhMuc MaDanhMucNavigation { get; set; } = null!;

    [ForeignKey("MaThuongHieu")]
    [InverseProperty("SanPhams")]
    public virtual ThuongHieu MaThuongHieuNavigation { get; set; } = null!;
}
