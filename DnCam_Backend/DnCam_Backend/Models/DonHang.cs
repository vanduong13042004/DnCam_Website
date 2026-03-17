using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DnCam_Backend.Models;

[Table("DonHang")]
public partial class DonHang
{
    [Key]
    public int MaDonHang { get; set; }

    public int MaNguoiDung { get; set; }

    [StringLength(100)]
    public string TenNguoiNhan { get; set; } = null!;

    [Column("SDTNguoiNhan")]
    [StringLength(15)]
    [Unicode(false)]
    public string SdtnguoiNhan { get; set; } = null!;

    [StringLength(500)]
    public string DiaChiGiaoHang { get; set; } = null!;

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? PhiGiaoHang { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal TongTien { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PhuongThucThanhToan { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? TrangThai { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? NgayTao { get; set; }

    [InverseProperty("MaDonHangNavigation")]
    public virtual ICollection<ChiTietDonHang> ChiTietDonHangs { get; set; } = new List<ChiTietDonHang>();

    [ForeignKey("MaNguoiDung")]
    [InverseProperty("DonHangs")]
    public virtual NguoiDung MaNguoiDungNavigation { get; set; } = null!;
}
