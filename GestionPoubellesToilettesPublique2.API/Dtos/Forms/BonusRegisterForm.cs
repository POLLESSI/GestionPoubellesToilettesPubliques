using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GestionPoubellesToilettesPublique2.API.Dtos.Forms
{
    public class BonusRegisterForm
    {
        [Required]
        [MinLength(2)]
        [MaxLength(32)]
        [DisplayName("Bonus Type : ")]
        public string? BonusType { get; set; }
        [Required]
        [MinLength(2)]
        [MaxLength(256)]
        [DisplayName("Description : ")]
        public string? BonusDescription { get; set; }
        [Required]
        [MinLength(2)]
        [MaxLength(64)]
        [DisplayName("Application : ")]
        public string? Application { get; set; }
    }
}
