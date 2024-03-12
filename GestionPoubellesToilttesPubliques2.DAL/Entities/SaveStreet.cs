
namespace GestionPoubellesToilttesPubliques2.DAL.Entities
{
    public class SaveStreet
    {
        public int SaveStreet_Id { get; set; }
        public string? StreetName { get; set; }
        public string? StartLatitude { get; set; }
        public string? EndLatitude { get; set; }
        public string? StartLongitude { get; set; }
        public string? EndLongitude { get; set; }
        public string? SecurityScore { get; set; }
        public bool Active { get; set; }
    }
}
