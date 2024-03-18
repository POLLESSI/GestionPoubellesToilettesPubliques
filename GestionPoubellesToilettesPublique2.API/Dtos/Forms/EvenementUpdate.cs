using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GestionPoubellesToilettesPublique2.API.Dtos.Forms
{
    public class EvenementUpdate
    {
        [Required]
        [DisplayName("Id event : ")]
        public int Evenement_Id { get; set; }

        //public DateTime EvenementDate { get; set; }
        [Required]
        [MinLength(2)]
        [MaxLength(32)]
        [DisplayName("Event's name : ")]
        public string? EvenementName { get; set; }
        [Required]
        [MinLength(2)]
        [MaxLength(256)]
        [DisplayName("Event's description : ")]
        public string? EvenementDescription { get; set; }
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
        [DisplayName("Positif? Yes? No?")]
        public bool Positif { get; set; }
    }
}
