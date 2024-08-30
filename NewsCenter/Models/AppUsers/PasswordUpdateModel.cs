using System.ComponentModel.DataAnnotations;

namespace NewsCenter.Models.AppUsers
{
    public class PasswordUpdateModel
    {

        public string Email { get; set; }

        
        [Required(ErrorMessage = "Şifre zorunludur")]

        [MinLength(5, ErrorMessage = "Şifre en az 5 karakter olmalıdır.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Şifre tekrarı zorunludur")]

        [Compare("Password", ErrorMessage = "Şifreler eşleşmiyor.")]
        public string PasswordConfirm { get; set; }

    }
}
