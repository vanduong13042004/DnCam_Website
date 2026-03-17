using Microsoft.EntityFrameworkCore;
using DnCam_Backend.Models;

var builder = WebApplication.CreateBuilder(args);

// --- 1. ĐĂNG KÝ CÁC DỊCH VỤ (SERVICES) ---

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Đăng ký DbContext để kết nối SQL Server
builder.Services.AddDbContext<DnCamContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Cấu hình CORS (Để web React ở cổng 5173 có thể gọi được API này)
builder.Services.AddCors(options => {
    options.AddPolicy("AllowAll", policy => {
        policy.AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});

var app = builder.Build();

// --- 2. CẤU HÌNH LUỒNG XỬ LÝ (MIDDLEWARE) ---

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Kích hoạt CORS (Phải đặt trước UseAuthorization)
app.UseCors("AllowAll");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();