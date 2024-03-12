namespace GestionPoubellesToilettesPublique2.API.Dtos
{
    public class Message
    {
        public string? Author { get; set; }
        public string? NewMessage { get; set; }
        public DateTime SendingDate { get; set; } = DateTime.UtcNow;
        public bool IsPrivate { get; set; } = false;
    }
}
