using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GestionPoubellesToilettesPublique2.API.Dtos.Forms
{
    public class RecompenseUpdate
    {
        [Required]
        [DisplayName("Recompense Id : ")]
        public int Recompense_Id { get; set; }
        [Required]
        [MinLength(2)]
        [MaxLength(32)]
        [DisplayName("Definition : ")]
        public string? Definition { get; set; }
        [Required]
        [MinLength(1)]
        [DisplayName("Points : ")]
        public string? Point { get; set; }
        [Required]
        [MinLength(2)]
        [MaxLength(256)]
        [DisplayName("Implication : ")]
        public string? Implication { get; set; }
    }
}
