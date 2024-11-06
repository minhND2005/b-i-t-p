using System.ComponentModel.DataAnnotations;

namespace A1.Models
{
    public class SanPham
    {
        [Key]
        public Guid? IdSP { get; set; }
        public string? SpName { get; set; }
        public float? price { get; set; }
        public ICollection<GioHangSanPham> CartProducts { get; set; } // Mối quan hệ nhiều-nhiều với Product
    }
}

