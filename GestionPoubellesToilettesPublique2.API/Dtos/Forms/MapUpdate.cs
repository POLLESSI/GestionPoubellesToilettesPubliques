using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GestionPoubellesToilettesPublique2.API.Dtos.Forms
{
    public class MapUpdate
    {
        [Required]
        [DisplayName("Id map : ")]
        public int Map_Id { get; set; }
        [Required]
        [DisplayName("Date of creation : ")]
        public DateTime DateCreation { get; set; }
        [Required]
        [MinLength(2)]
        [MaxLength(32)]
        [DisplayName("Description : ")]
        public string? Description { get; set; }
    }
}
