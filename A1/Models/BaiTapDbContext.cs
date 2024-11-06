using Microsoft.EntityFrameworkCore;

namespace A1.Models
{
    public class BaiTapDbContext : DbContext
    {
        public BaiTapDbContext(DbContextOptions options) : base(options)
        {
        }

        public BaiTapDbContext()
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<SanPham> sanPhams { get; set; }
        public DbSet<GioHang> gioHang { get; set; }
        public DbSet<GioHangSanPham> GioHangSanPhams { get; set; }
    }
}
