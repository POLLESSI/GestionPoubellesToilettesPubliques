
namespace GestionPoubellesToilttesPubliques2.DAL.Entities
{
    public class Avatar
    {
        public int Avatar_Id { get; set; }
        public string? AvatarName { get; set; }
        public string? Description { get; set; }
        public int NUser_Id { get; set; }
        public bool Active { get; set; }
    }
}
