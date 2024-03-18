
namespace GestionPoubellesToilttesPubliques2.DAL.Entities
{
    public class Evenement
    {
        public int Evenement_Id { get; set; }
        public DateTime EvenementDate { get; set; }
        public string? EvenementName { get; set; }
        public string? EvenementDescription { get; set; }
        public string? PosLat { get; set; }
        public string? PosLong { get; set; }
        public bool positif { get; set; }
    }
}
