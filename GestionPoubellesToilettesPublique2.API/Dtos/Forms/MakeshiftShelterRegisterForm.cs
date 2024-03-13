using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GestionPoubellesToilettesPublique2.API.Dtos.Forms
{
    public class MakeshiftShelterRegisterForm
    {
        [Required(ErrorMessage = "Latitude is required")]
        [MinLength(2)]
        [MaxLength(8)]
        [DisplayName("Latitude : ")]
        public string? Latitude { get; set; }
        [Required(ErrorMessage = "Longitude is required")]
        [MinLength(3)]
        [MaxLength(9)]
        [DisplayName("Longitude : ")]
        public string? Longitude { get; set; }
        [Required(ErrorMessage = "Description is reequired")]
        [MinLength(2)]
        [MaxLength(128)]
        [DisplayName("Description : ")]
        public string? Description { get; set; }
    }
}
