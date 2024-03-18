
namespace GestionPoubellesToilttesPubliques2.DAL.Entities
{
    public class Chat
    {
        public int Chat_Id { get; set; }
        public string? NewMessage { get; set; }
        public string? Author { get; set; }
        public int Evenement_Id { get; set; }
        public bool Active { get; set; } 
    }
}
