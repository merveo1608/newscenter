using System.ComponentModel.DataAnnotations;

namespace NewsCenter.Models.AppUsers
{
    public class ForgotPasswordViewModel
    {
            [Required] //zorunluluk
            [EmailAddress] //veri email formatında olmak zorundadır
            public string Email { get; set; }
    }
}
