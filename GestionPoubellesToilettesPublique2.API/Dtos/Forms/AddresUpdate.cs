using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GestionPoubellesToilettesPublique2.API.Dtos.Forms
{
    public class AddresUpdate
    {
        [Required]
        [DisplayName("Id adresse : ")]
        public int Addres_Id { get; set; }
        [Required]
        [MaxLength(64)]
        [DisplayName("Rue : ")]
        public string? Rue { get; set; }
        [Required]
        [MaxLength (4)]
        [DisplayName("Numero : ")]
        public string? Numero { get; set; }
        [Required]
        [MaxLength(8)]
        [DisplayName("Code Postal : ")]
        public string? CP { get; set; }
        [Required]
        [MaxLength(64)]
        [DisplayName("Ville : ")]
        public string? Pays { get; set; }
    }
}
