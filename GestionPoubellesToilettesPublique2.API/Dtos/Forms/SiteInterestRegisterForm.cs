using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GestionPoubellesToilettesPublique2.API.Dtos.Forms
{
    public class SiteInterestRegisterForm
    {
        [Required]
        [MinLength(2)]
        [MaxLength(32)]
        [DisplayName("Site Name : ")]
        public string? SiteInterestName { get; set; }
        [Required]
        [MinLength(2)]
        [MaxLength(32)]
        [DisplayName("Type Of Site : ")]
        public string? SiteInterestType { get; set; }
        [Required]
        [MinLength(2)]
        [MaxLength(8)]
        [DisplayName("Latitude : ")]
        public string? PosLat { get; set; }
        [Required]
        [MinLength(3)]
        [MaxLength(9)]
        [DisplayName("Longitude : ")]
        public string? PosLong { get; set; }
        [Required]
        [MinLength(2)]
        [MaxLength(256)]
        [DisplayName("Description : ")]
        public string? Description { get; set; }
    }
}
