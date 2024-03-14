using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GestionPoubellesToilettesPublique2.API.Dtos.Forms
{
    public class AddresRegisterForm
    {
        [Required]
        [MinLength(2)]
        [MaxLength(64)]
        [DisplayName("Rue : ")]
        public string? Rue { get; set; }
        [Required]
        [MinLength(2)]
        [MaxLength(4)]
        [DisplayName("Numero : ")]
        public string? Numero { get; set; }
        [Required]
        [MinLength(2)]
        [MaxLength(8)]
        [DisplayName("CP : ")]
        public string? CP { get; set; }
        [Required]
        [MinLength(2)]
        [MaxLength(64)]
        [DisplayName("Ville : ")]
        public string? Ville { get; set; }
        [Required]
        [MinLength(2)]
        [MaxLength(64)]
        [DisplayName("Pays : ")]
        public string? Pays { get; set; }
    }
}
