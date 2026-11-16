using Microsoft.EntityFrameworkCore;

namespace HotelManagement.Models;

// File partial riêng: khi scaffold lại DB, EF Core Power Tools sẽ ghi đè
// HotelManagementContext.cs nhưng KHÔNG làm mất cấu hình trong file này.
public partial class HotelManagementContext
{
    // Đổi Server cho đúng máy của bạn:
    // "." | "localhost" | @".\SQLEXPRESS" | @"(localdb)\MSSQLLocalDB"
    private const string ConnectionString =
        @"Server=(localdb)\MSSQLLocalDB;Database=HotelManagement;Trusted_Connection=True;TrustServerCertificate=True;";

    // Constructor không tham số: new HotelManagementContext()
    public HotelManagementContext() { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
            optionsBuilder.UseSqlServer(ConnectionString);
    }
}
