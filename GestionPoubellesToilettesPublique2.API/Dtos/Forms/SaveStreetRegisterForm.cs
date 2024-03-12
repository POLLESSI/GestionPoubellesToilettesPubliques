using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GestionPoubellesToilettesPublique2.API.Dtos.Forms
{
    public class SaveStreetRegisterForm
    {
        [Required(ErrorMessage = "Street name is required")]
        [MinLength(2)]
        [MaxLength(64)]
        [DisplayName("Sreet name : ")]
        public string? StreetName { get; set; }
        [Required(ErrorMessage = "Start latitude is required")]
        [MinLength(2)]
        [MaxLength(8)]
        [DisplayName("Start latitude : ")]
        public string? StartLatitude { get; set; }
        [Required(ErrorMessage = "End Latitude is required")]
        [MinLength(2)]
        [MaxLength(8)]
        [DisplayName("End latitude : ")]
        public string? EndLatitude { get; set; }
        [Required(ErrorMessage = "Start Longitude is required")]
        [MinLength(2)]
        [MaxLength(8)]
        [DisplayName("Start longitude : ")]
        public string? StartLongitude { get; set; }
        [Required(ErrorMessage = "End Longitude is required")]
        [MinLength(2)]
        [MaxLength(8)]
        [DisplayName("End Longitude : ")]
        public string? EndLongitude { get; set; }
        [Required(ErrorMessage = "Security Score is required")]
        [MaxLength(1)]
        [DisplayName("Security score : ")]
        public string? SecutityScore { get; set; }
    }
}
