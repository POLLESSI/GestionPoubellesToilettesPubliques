
namespace GestionPoubellesToilttesPubliques2.DAL.Entities
{
    public class Monument
    {
        public int Monument_Id { get; set; }
        public string? MonumentName { get; set; }
        public string? Description { get; set; }
        public string? PosLat { get; set; }
        public string? PosLong { get; set; }
        public bool Active { get; set; }
    }
}
