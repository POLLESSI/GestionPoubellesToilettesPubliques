using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GestionPoubellesToilettesPublique2.API.Dtos.Forms
{
    public class LoginNUser
    {
        [Required(ErrorMessage = "Email is required !!! ")]
        [MaxLength(64)]
        [EmailAddress]
        [DisplayName("Email : ")]
        public string? Email { get; set; }
        [Required(ErrorMessage = "The password is required !!! ")]
        [MaxLength(64)]
        [DisplayName("Password : ")]
        public string? Password { get; set; }
    }
}
