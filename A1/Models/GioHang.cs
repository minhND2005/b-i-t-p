using System.ComponentModel.DataAnnotations;

namespace A1.Models
{
    public class GioHang
    {
        [Key]
        public Guid? IdGH { get; set; }
        public int? Name { get; set; }

        public Guid? SPid { get; set; }

        public ICollection<GioHangSanPham> CartProducts { get; set; }
    }
}
