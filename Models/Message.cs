namespace app.Models
{
    public class Message
    {
        public string Id { get; set; }
        public string IdUser { get; set; }
        public string MessageSend { get; set; }
        public DateTime DateOfCreation { get; set; }
    }
}