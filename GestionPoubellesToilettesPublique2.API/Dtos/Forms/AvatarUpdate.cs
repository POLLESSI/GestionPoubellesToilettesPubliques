using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GestionPoubellesToilettesPublique2.API.Dtos.Forms
{
    public class AvatarUpdate
    {
        [Required]
        [DisplayName("Id Avatar : ")]
        public int Avatar_Id { get; set; }
        [Required]
        [MinLength(2)]
        [MaxLength(32)]
        [DisplayName("Avatar name : ")]
        public string? AvatarName { get; set; }
        [Required]
        [MinLength(2)]
        [MaxLength(256)]
        [DisplayName("Description : ")]
        public string? Description { get; set; }
        [Required]
        [DisplayName("Id NUser (Guid) : ")]
        public Guid NUser_Id { get; set; }
    }
}
