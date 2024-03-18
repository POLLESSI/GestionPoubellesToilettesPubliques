using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GestionPoubellesToilettesPublique2.API.Dtos.Forms
{
    public class OrganisateurRegisterForm
    {
        [Required]
        [MinLength(1)]
        [MaxLength(32)]
        [DisplayName("Company Name : ")]
        public string? CompanyName { get; set; }
        [Required]
        [MinLength(8)]
        [MaxLength(16)]
        [DisplayName("Business Number : ")]
        public string? BusinessNumber { get; set; }
        [Required]
        [DisplayName("User Id : ")]
        public int NUser_Id { get; set; }
    }
}
