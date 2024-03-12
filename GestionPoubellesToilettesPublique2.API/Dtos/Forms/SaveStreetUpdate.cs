using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GestionPoubellesToilettesPublique2.API.Dtos.Forms
{
    public class SaveStreetUpdate
    {
        [Required(ErrorMessage = "Save street id is required")]
        [DisplayName("Save Street Id : ")]
        public int SaveStreet_Id { get; set; }
        [Required(ErrorMessage = "The name of Save street is required")]
        [MinLength(2)]
        [MaxLength(64)]
        [DisplayName("Street name : ")]
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
        [Required(ErrorMessage = "Start longitude is required")]
        [MinLength(2)]
        [MaxLength(8)]
        [DisplayName("Start Longitude : ")]
        public string? StartLongitude { get; set; }
        [Required(ErrorMessage = "End longitude is required")]
        [MinLength(2)]
        [MaxLength(8)]
        [DisplayName("End longitude : ")]
        public string? EndLongitude { get; set; }
        [Required(ErrorMessage = "Security Score is required")]
        [MaxLength(1)]
        [DisplayName("Security Score : ")]
        public string? SecurityScore { get; set; }
    }
}
