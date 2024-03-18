using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GestionPoubellesToilettesPublique2.API.Dtos.Forms
{
    public class MapRegisterForm
    {
        [Required(ErrorMessage = "Date of creation is required")]
        [DisplayName("Date Creation : ")]
        public DateTime DateCreation { get; set; }
        [Required(ErrorMessage = "Description is required")]
        [MinLength(2)]
        [MaxLength(32)]
        public string Description { get; set; }
    }
}
