using app.Repositories;
using System.Collections.ObjectModel;
using System.Runtime.InteropServices;

namespace app.Models
{
    public class Group
    {
        public string Id { get; set; }
        public string GroupName { get; set; }
        public List<string> IdUsers { get; set; }
        public DateTime DateGroupCreation { get; set; }
        public string ImageGroup { get; set; }   
        public List<Message> ListOfMessages { get; set; } 
    }
}
