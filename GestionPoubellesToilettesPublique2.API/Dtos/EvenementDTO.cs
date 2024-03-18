namespace GestionPoubellesToilettesPublique2.API.Dtos
{
    public class EvenementDTO
    {
        public DateTime EvenementDate { get; set; }
        public string? EvenementName { get; set; }
        public string? EvenementDescription { get; set; }
        public string? PosLat { get; set; }
        public string? PosLong { get; set; }
        public bool Positif { get; set; }
        public bool Active { get; set; }
    }
}
