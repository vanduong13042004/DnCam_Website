using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DnCam_Backend.Models;

[Table("DanhMuc")]
public partial class DanhMuc
{
    [Key]
    public int MaDanhMuc { get; set; }

    [StringLength(100)]
    public string TenDanhMuc { get; set; } = null!;

    [StringLength(500)]
    public string? MoTa { get; set; }

    [InverseProperty("MaDanhMucNavigation")]
    public virtual ICollection<SanPham> SanPhams { get; set; } = new List<SanPham>();
}
