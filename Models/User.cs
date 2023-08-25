namespace app.Models
{
    public class User
    {
        public string Id { get; set; }
        public string UserName { get; set; }  
        public string Password { get; set; }
        public string Role { get; set; }
        public List<Group> ListGroup { get; set; }
        public List<MessageOneToOne> ListMessageOneToOne { get; set; }    
        
        public void GenerateId()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public void SetUserName(string userName)
        {
            this.UserName = userName;
        }

        public void SetPassword(string password)
        {
            this.Password = password;
        }

        public void SetRules(string role)
        {
            this.Role = role;
        }
    }
}
