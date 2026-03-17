using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DnCam_Backend.Models;

namespace DnCam_Backend.Controllers
{
    [Route("api/[controller]")] // Đường dẫn sẽ là api/sanpham
    [ApiController]
    public class SanPhamController : ControllerBase
    {
        private readonly DnCamContext _context;

        // Hàm khởi tạo: Tiêm (Inject) database vào để dùng
        public SanPhamController(DnCamContext context)
        {
            _context = context;
        }

        // GET: api/sanpham
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SanPham>>> GetSanPhams()
        {
            // Lấy toàn bộ danh sách sản phẩm từ SQL Server
            return await _context.SanPhams.ToListAsync();
        }
    }
}