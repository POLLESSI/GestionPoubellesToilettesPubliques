using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GestionPoubellesToilettesPublique2.API.Dtos.Forms
{
    public class IncivilityUpdate
    {
        [Required]
        [DisplayName("Id incivilité : ")]
        public int Incivility_Id { get; set; }
        [Required]
        [DisplayName("Numero Mat. : ")]
        public string? Num_Mat { get; set; }
        [Required]
        [MinLength(2)]
        [MaxLength(8)]
        [DisplayName("Latitude : ")]
        public string? PosLat { get; set; }
        [Required]
        [MinLength(3)]
        [MaxLength(9)]
        [DisplayName("Longitude : ")]
        public string? PosLonG { get; set; }
        [Required]
        [DisplayName("Address id : ")]
        public int Addres_Id { get; set; }
        [Required]
        [DisplayName("Sévère? : ")]
        public bool Severe { get; set; }
        [Required]
        [DisplayName("Absorbé? : ")]
        public bool Absorbed { get; set; }
    }
}
