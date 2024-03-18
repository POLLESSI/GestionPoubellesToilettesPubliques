using Microsoft.AspNetCore.Cors;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GestionPoubellesToilettesPublique2.API.Dtos.Forms
{
    public class RecompenseRegisterForm
    {
        [Required]
        [MinLength(2)]
        [MaxLength(32)]
        [DisplayName("Definition : ")]
        public string? Definition { get; set; }
        [Required]
        [MinLength(1)]
        [DisplayName("Point : ")]
        public string? Point { get; set; }
        [Required]
        [MinLength(2)]
        [MaxLength(256)]
        [DisplayName("Implication : ")]
        public string? Implacation { get; set; }
    }
}
