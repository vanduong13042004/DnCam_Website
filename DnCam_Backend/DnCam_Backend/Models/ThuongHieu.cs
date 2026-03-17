using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DnCam_Backend.Models;

[Table("ThuongHieu")]
public partial class ThuongHieu
{
    [Key]
    public int MaThuongHieu { get; set; }

    [StringLength(100)]
    public string TenThuongHieu { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string? LogoThuongHieu { get; set; }

    [InverseProperty("MaThuongHieuNavigation")]
    public virtual ICollection<SanPham> SanPhams { get; set; } = new List<SanPham>();
}
