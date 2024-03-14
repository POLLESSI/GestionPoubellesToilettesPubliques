using GestionPoubellesToilettesPublique2.API.Controllers;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GestionPoubellesToilettesPublique2.API.Dtos.Forms
{
    public class GarbageCanRegisterForm
    {
        [Required]
        [DisplayName("Numero mat. : ")]
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
        public string? PosLong { get; set; }
        [Required]
        [DisplayName("Address Id : ")]
        public int Addres_Id { get; set; }
        [Required]
        [DisplayName("Est plein? : ")]
        public bool IsFull { get; set; }
        [Required]
        [DisplayName("Dégradation? : ")]
        public bool Degradation { get; set; }

    }
}
