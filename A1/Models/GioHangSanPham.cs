using System.ComponentModel.DataAnnotations;

namespace A1.Models
{
    public class GioHangSanPham
    {
        [Key]
        public int Id { get; set; }
       public Guid? IdGH {  get; set; }
        public Guid? IdSP { get; set; }

        public int? Soluong {  get; set; }
        public int? TrangThai { get; set;}
    }
}
