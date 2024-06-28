using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forum.Domain
{
    public class User
    {
        public User(string name , string password )
        {
            Name = name;
            Password = password;
            JoinedAt = DateTime.Now ;
        }
        public int Id {  get; set; }
        public string Name { get; }
        public string Password { get; }
        public DateTime JoinedAt { get; }
        public List<Post>? Posts { get; set; } = new List<Post>();
        public List<Comment>? Comments { get; set; } =new List<Comment>();
    }
}
