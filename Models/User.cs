namespace app.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }  
        public string Password { get; set; }
        public string Role { get; set; }
        public List<Group> ListGroup { get; set; }
        public List<MessageOneToOne> ListMessageOneToOne { get; set; }      
    }
}
