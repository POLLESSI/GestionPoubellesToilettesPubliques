using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GestionPoubellesToilettesPublique2.API.Dtos.Forms
{
    public class AvatarRegisterForm
    {
        public string? AvatarName { get; set; }
        public string? Description { get; set; }
        public Guid NUser_Id { get; set; }
    }
}
