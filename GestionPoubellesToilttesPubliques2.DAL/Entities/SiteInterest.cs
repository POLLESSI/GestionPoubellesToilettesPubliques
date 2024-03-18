
namespace GestionPoubellesToilttesPubliques2.DAL.Entities
{
    public class SiteInterest
    {
        public int SiteInterest_Id { get; set; }
        public string? SiteInterestName { get; set; }
        public string? SiteInterestType { get; set; }
        public string? PosLat { get; set; }
        public string? PosLong { get; set; } 
        public string? Description { get; set; }
        public bool Active { get; set; }
    }
}
