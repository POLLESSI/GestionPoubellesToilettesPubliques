
namespace GestionPoubellesToilttesPubliques2.DAL.Entities
{
    public class Addres
    {
        public int Addres_Id { get; set; }
        public string? Rue { get; set; }
        public string? Numero { get; set; }
        public string? CP { get; set; }
        public string? Ville { get; set; }
        public string? Pays { get; set; }
        public bool Active { get; set; }
    }
}
