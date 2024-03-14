
namespace GestionPoubellesToilttesPubliques2.DAL.Entities
{
    public class Incivility
    {
        public int Incivility_Id { get; set; }
        public string? Num_Mat { get; set; }
        public string? PosLat { get; set; }
        public string? PosLong { get; set; }
        public int Addres_Id { get; set; }
        public bool Severe { get; set; }
        public bool Absorbed { get; set; }
        public bool Active { get; set; }
    }
}
