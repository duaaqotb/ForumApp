using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forum.Domain
{
    public class Post
    {
        public Post(int id , string text , string userName)
        {
            Id = id;
            Text = text;
            CreatedAt = DateTime.Now; ;
            UserName = userName;
        }
        public int Id { get; }
        public string Text { get; }
        public DateTime CreatedAt { get; }
        public string UserName { get; }
        public User User { get; set; }
        public int UserId { get; set; }
        public List<Comment>? Comments { get; set; }= new List<Comment>();
    }
}
