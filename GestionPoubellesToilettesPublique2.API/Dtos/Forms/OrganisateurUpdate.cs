using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GestionPoubellesToilettesPublique2.API.Dtos.Forms
{
    public class OrganisateurUpdate
    {
        [Required]
        [DisplayName("Id Organisateur : ")]
        public int Organisateur_Id { get; set; }
        [Required]
        [MinLength(2)]
        [MaxLength(32)]
        [DisplayName("Company Name : ")]
        public string? CompanyName { get; set; }
        [Required]
        [MinLength(8)]
        [MaxLength(16)]
        [DisplayName("Business Number : ")]
        public string? BusinessNumber { get; set; }
        [Required]
        [DisplayName("Id User : ")]
        public int NUser_Id { get; set; }
    }
}
