
namespace GestionPoubellesToilttesPubliques2.DAL.Entities
{
    public class GarbageCan
    {
        public int GarbageCan_Id { get; set; }
        public string? Num_Mat { get; set; }
        public string? PosLat { get; set; }
        public string? PosLong { get; set; }
        public int Addres_Id { get; set; }
        public bool IsFull { get; set; }
        public bool Degradation { get; set; }
        public bool Active { get; set; }
    }
}
