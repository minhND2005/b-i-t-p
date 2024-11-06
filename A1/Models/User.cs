using System.ComponentModel.DataAnnotations;

namespace A1.Models
{
    public class User
    {
        [Key]
        public Guid? Id { get; set; } 
       
        public string? Name { get; set; }
        [StringLength(450, MinimumLength = 10, ErrorMessage = "UserName phải có độ dài từ 10 đến 450 ký tự")]
        public string? UserName { get; set; }
       
        public string? Password { get; set; }

        [RegularExpression(@"^\d{3}-\d{3}-\d{4}$", ErrorMessage = "Số điện thoại phải theo định dạng 10 chữ số: xxx-xxx-xxxx")]
        public string? Phone { get; set; }
      
        public DateTime? NgaySinh { get; set; }

        public List<SanPham> sanPhams { get; set; }
    }
}
