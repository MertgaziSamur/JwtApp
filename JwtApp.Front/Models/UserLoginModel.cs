using System.ComponentModel.DataAnnotations;

namespace JwtApp.Front.Models
{
    public class UserLoginModel
    {
        [Required(ErrorMessage = "Kullanıcı adı gereklidir.")]
        public string UserName { get; set; } = null!;
        [Required(ErrorMessage = "Şifre gereklidir.")]
        public string Password { get; set; } = null!;
    }
}
