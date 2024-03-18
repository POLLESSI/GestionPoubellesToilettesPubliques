namespace GestionPoubellesToilettesPublique2.API.Dtos
{
    public class AvatarDTO
    {
        public string? AvatarName { get; set; }
        public string? Description { get; set; }
        public Guid NUser_Id { get; set; }
        public bool Active { get; set; }
    }
}
