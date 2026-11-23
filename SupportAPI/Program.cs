
using Microsoft.EntityFrameworkCore;
using SupportAPI.Data;

var builder = WebApplication.CreateBuilder(args);

// Đăng ký kết nối SQL Server
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection")
    )
);

var app = builder.Build();

// API kiểm tra ứng dụng
app.MapGet("/", () => "Customer Support API is running!");

// API kiểm tra kết nối Database
app.MapGet("/test-db", async (AppDbContext db) =>
{
    bool connected = await db.Database.CanConnectAsync();

    return connected
        ? Results.Ok("Ket noi SQL Server thanh cong!")
        : Results.Problem("Khong the ket noi SQL Server!");
});


app.Run();
